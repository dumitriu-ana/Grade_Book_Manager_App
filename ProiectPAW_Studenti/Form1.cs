using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using System.ComponentModel;
using System.Data;

using System.Drawing.Printing;

using System.Text;
using System.Threading.Tasks;


namespace ProiectPAW_Studenti
{

    public partial class Form1 : Form
    {
        Student s;
        List<Student> listaStudenti;
        string conexiuneString;

        bool verificaIncarcareDate = false;
        private const int margine = 20;
        Color culoareBari = Color.Green;
        Color culoareText = Color.Black;
        Font fontText = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);

        public Form1()
        {
            listaStudenti = new List<Student>();
            InitializeComponent();
            conexiuneString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=StudentiProiect.accdb";
        }


        private int[] extragereValoriDinString(string str)
        {
            string[] vector = str.Split(',');
            int[] vectorInt = new int[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                vectorInt[i] = Convert.ToInt32(vector[i]);
            }
            return vectorInt;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "")
            {
                errorProvider1.SetError(tbId, "Adauga text");
            }
            if (tbNume.Text == "")
            {
                errorProvider1.SetError(tbNume, "Adauga text");
            }
            else if (tbMaterii.Text == "")
            {
                errorProvider1.SetError(tbMaterii, "Adauga text");
            }
            else if (tbNote.Text == "")
            {
                errorProvider1.SetError(tbNote, "Adauga note");

            }
            else if (tbNumarCredite.Text == "")
            {
                errorProvider1.SetError(tbNumarCredite, "Adauga note");

            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    string nume = tbNume.Text;
                    int id = Convert.ToInt32(tbId.Text);

                    string[] vectorMaterii = tbMaterii.Text.Split(',');
                    int[] vectorCredite = extragereValoriDinString(tbNumarCredite.Text);

                    int[] vectorNote = extragereValoriDinString(tbNote.Text);

                    s = new Student(id, nume, vectorMaterii, vectorCredite, vectorNote);

                    s.calculMedie();
                    listaStudenti.Add(s);

                    MessageBox.Show(s.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    tbId.Clear();
                    tbMaterii.Clear();
                    tbNumarCredite.Clear();
                    tbNume.Clear();
                    tbNote.Clear();

                }
            }

        }

        private void btnAfisareStudentiForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(listaStudenti);
            form2.Show();
        }

        private void btnAdaugareLV_Click(object sender, EventArgs e)
        {
            foreach (Student s in listaStudenti)
            {
                ListViewItem lvi = new ListViewItem(s.Id.ToString());
                lvi.SubItems.Add(s.Nume);
                string materii_den="";
                string materii_credite = "";
                string materii_note = "";
                for(int i=0; i<s.Materie.Length; i++)
                {
                    materii_den = materii_den + (s.Materie[i].Denumire).ToString() +" ";
                    materii_credite = materii_credite + (s.Materie[i].NumarCredite).ToString()+" ";
                    materii_note = materii_note + s.Note[i]+ " ";
                }
                lvi.SubItems.Add(materii_den);
                lvi.SubItems.Add(materii_credite);
                lvi.SubItems.Add(materii_note);
                float med = s.Medie;
                lvi.SubItems.Add(med.ToString());
                int t = s.calculTaxe();
                lvi.SubItems.Add(t.ToString());

                lvStudenti.Items.Add(lvi);
            }

        }

        private void btnAdaugaNota_Click(object sender, EventArgs e)
        {
            if(lvStudenti.SelectedItems.Count>0)
            {
                int idSelectat = Convert.ToInt32(lvStudenti.SelectedItems[0].SubItems[0].Text);
                //int idSelectat = 1;
                Student s = new Student();
                //int gasit = 0;
                foreach (Student i in listaStudenti)
                {
                    if (idSelectat == i.Id)
                    {
                        s = i;
                        //gasit = 1;
                    }
                }

                Form3 form3 = new Form3(s);
                form3.Show();
            }
            else
            {
                MessageBox.Show("Nu a fost selectat un student!");
            }

        }

        private void lvStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPopulare_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(conexiuneString);
            OleDbCommand interogare = new OleDbCommand("SELECT * FROM TabelStudenti", conexiune);

            try
            {
                conexiune.Open();
                OleDbDataReader reader = interogare.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["ID"].ToString());
                    itm.SubItems.Add(reader["Nume"].ToString());
                    itm.SubItems.Add(reader["Materii"].ToString());
                    itm.SubItems.Add(reader["Medie"].ToString());
                    itm.SubItems.Add(reader["NumarCredite"].ToString());
                    itm.SubItems.Add(reader["Note"].ToString());
                    itm.SubItems.Add(reader["Taxa"].ToString());
                    lvStudenti.Items.Add(itm);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }


        private void btnAdaugareinBD_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(conexiuneString);
            OleDbCommand interogare = new OleDbCommand();

            try
            {
                

                conexiune.Open();
                interogare.Connection = conexiune;
        
                Student student = new Student(Convert.ToInt32(tbId.Text), tbNume.Text, tbMaterii.Text.Split(','), extragereValoriDinString(tbNumarCredite.Text), extragereValoriDinString(tbNote.Text));

                interogare.CommandText = "INSERT INTO TabelStudenti VALUES (?,?,?,?,?,?,?)";
                interogare.Parameters.Add("ID", OleDbType.Integer).Value = student.Id;
                interogare.Parameters.Add("Nume", OleDbType.Char, 25).Value = tbNume.Text;
                interogare.Parameters.Add("Materii", OleDbType.Char, 25).Value = tbMaterii.Text;
                interogare.Parameters.Add("NumarCredite", OleDbType.Char, 25).Value = tbNumarCredite.Text;
                interogare.Parameters.Add("Note", OleDbType.Char, 25).Value = tbNote.Text;

                student.calculMedie();
                interogare.Parameters.Add("Medie", OleDbType.Integer).Value = student.Medie;
                float t = student.calculTaxe();
                interogare.Parameters.Add("Taxa", OleDbType.Numeric).Value = t;
                listaStudenti.Add(student);
                interogare.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(conexiuneString);
            OleDbCommand interogare = new OleDbCommand();

            try
            {
                conexiune.Open();
                foreach (ListViewItem itm in lvStudenti.Items)
                {
                    if (itm.Selected)
                    {
                        int ID = Convert.ToInt32(itm.SubItems[0].Text);
                        interogare.CommandText = "DELETE FROM TabelStudenti WHERE ID=" + ID;
                        interogare.Connection = conexiune;
                        interogare.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
            lvStudenti.Items.Clear();
            btnPopulare_Click(sender, e);
        }

        private void salveazaMediiInFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.Filter = "(*.txt)|*.txt"; //ca la extensie sa apara doar txt
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            //    foreach (Student s in listaStudenti)
            //    {
            //        string mesaj = s.Nume + "," + s.Medie;
            //        sw.WriteLine(mesaj);
            //    }
            //    sw.Close();
            //    //tbStudenti.Clear();
            //}
        }

        private void afiseazaGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Date.txt");
            string linie = "";
            while ((linie = sr.ReadLine()) != null)
            {
                string nume = linie.Split(',')[0];
                float medie = float.Parse(linie.Split(',')[1]);
                Student s = new Student(nume, medie);
                listaStudenti.Add(s);
                verificaIncarcareDate = true;
            }
            sr.Close();
            MessageBox.Show("Datele despre mediile studentilor vor aparea in grafic!");
            panel1.Invalidate();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (verificaIncarcareDate)
            {
                Graphics g = e.Graphics;
                Rectangle rectangle = new Rectangle(panel1.ClientRectangle.X + margine,
                    panel1.ClientRectangle.Y + 4 * margine, panel1.ClientRectangle.Width - 2 * margine,
                    panel1.ClientRectangle.Height - 5 * margine);
                Pen pen = new Pen(Color.Black, 3);
                g.DrawRectangle(pen, rectangle);

                double latime = rectangle.Width / listaStudenti.Count / 3;
                double distanta = (rectangle.Width - listaStudenti.Count * latime) / (listaStudenti.Count + 1);
                double vMax = listaStudenti.Max(max => max.Medie)+1;

                Brush brBari = new SolidBrush(culoareBari);
                Brush brText = new SolidBrush(culoareText);

                Rectangle[] rectangles = new Rectangle[listaStudenti.Count];
                for (int i = 0; i < listaStudenti.Count; i++)
                {
                    rectangles[i] = new Rectangle((int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rectangle.Location.Y + rectangle.Height - listaStudenti[i].Medie / vMax * rectangle.Height),
                        (int)(latime),
                        (int)(listaStudenti[i].Medie / vMax * rectangle.Height));
                    g.DrawString((listaStudenti[i].Medie).ToString(), fontText, brText, new Point(
                        rectangles[i].Location.X, rectangles[i].Location.Y - fontText.Height));
                }

                g.FillRectangles(brBari, rectangles);

                for (int i = 0; i < listaStudenti.Count - 1; i++)
                {
                    g.DrawLine(pen, new Point((int)(rectangles[i].Location.X + latime / 2),
                        rectangles[i].Location.Y), new Point((int)(rectangles[i + 1].Location.X + latime / 2),
                        rectangles[i + 1].Location.Y));
                }
            }
        }

        private void bariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                culoareBari = cd.Color;
            }
            panel1.Invalidate();
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                culoareText = cd.Color;
            }
            panel1.Invalidate();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                fontText = fd.Font;
            }
            panel1.Invalidate();
        }

        private void pp(object sender, PrintPageEventArgs e)
        {
            if (verificaIncarcareDate)
            {
                Graphics g = e.Graphics;
                Rectangle rectangle = new Rectangle(panel1.ClientRectangle.X + margine,
                    panel1.ClientRectangle.Y + 4 * margine, panel1.ClientRectangle.Width - 2 * margine,
                    panel1.ClientRectangle.Height - 5 * margine);
                Pen pen = new Pen(Color.Black, 3);
                g.DrawRectangle(pen, rectangle);

                double latime = rectangle.Width / listaStudenti.Count / 3;
                double distanta = (rectangle.Width - listaStudenti.Count * latime) / (listaStudenti.Count + 1);
                double vMax = listaStudenti.Max(max => max.Medie) + 1;

                Brush brBari = new SolidBrush(culoareBari);
                Brush brText = new SolidBrush(culoareText);

                Rectangle[] rectangles = new Rectangle[listaStudenti.Count];
                for (int i = 0; i < listaStudenti.Count; i++)
                {
                    rectangles[i] = new Rectangle((int)(rectangle.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rectangle.Location.Y + rectangle.Height - listaStudenti[i].Medie / vMax * rectangle.Height),
                        (int)(latime),
                        (int)(listaStudenti[i].Medie / vMax * rectangle.Height));
                    g.DrawString((listaStudenti[i].Medie).ToString(), fontText, brText, new Point(
                        rectangles[i].Location.X, rectangles[i].Location.Y - fontText.Height));
                }

                g.FillRectangles(brBari, rectangles);

                for (int i = 0; i < listaStudenti.Count - 1; i++)
                {
                    g.DrawLine(pen, new Point((int)(rectangles[i].Location.X + latime / 2),
                        rectangles[i].Location.Y), new Point((int)(rectangles[i + 1].Location.X + latime / 2),
                        rectangles[i + 1].Location.Y));
                }
            }
        }

        private void printPreviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pp);
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            ppd.Document = pd;
            ppd.ShowDialog();
        }

        private void salvare_bmp(Control c, string nume_fisier)
        {
            Bitmap bmp = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(bmp, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y,
                c.ClientRectangle.Width, c.ClientRectangle.Height));
            bmp.Save(nume_fisier);
            bmp.Dispose();
        }
        private void salvareBmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvare_bmp(panel1, "Grafic_" + DateTime.Now.ToString("dd-MM-yyyy") + ".bmp");
            MessageBox.Show("Fisierul bmp a fost salvat");
        }
    }
}
