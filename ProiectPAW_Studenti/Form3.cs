using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPAW_Studenti
{
    public partial class Form3 : Form
    {
        Student s;
        Disciplina[] vector; 
        public Form3(Student s)
        {
            InitializeComponent();
            this.s = s;
            this.vector = new Disciplina[s.Materie.Length + 1];
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdaugaNota_Click(object sender, EventArgs e)
        {
            //adaug o noua materie pentru stud s
            //string[] den = ;
            int[] cr = new int[s.Materie.Length + 1];
            int[] n = new int[s.Materie.Length + 1];
            //copiez datele
            string[] den = new string[s.Materie.Length+1];
            for(int i=0; i<s.Materie.Length; i++)
            {
                den[i] = s.Materie[i].Denumire;
                cr[i] = s.Materie[i].NumarCredite;
                n[i] = s.Note[i];
            }
            int nr = s.Materie.Length;
            den[nr] = tbDenumire.Text;
            cr[nr] = Convert.ToInt32(tbNumarCredite.Text);
            n[nr] = Convert.ToInt32(tbNota.Text);

            Student sNou = new Student(s.Id, s.Nume, den, cr, n);
           
            s = sNou;
            s.calculMedie();
            MessageBox.Show(s.ToString());

        }
    }
}
