
namespace ProiectPAW_Studenti
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbMaterii = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbNumarCredite = new System.Windows.Forms.TextBox();
            this.btnAfisareStudentiForm2 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lvStudenti = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColNrMaterii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumarCredite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMedie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTaxa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdaugareLV = new System.Windows.Forms.Button();
            this.btnAdaugaNota = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnPopulare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnAdaugareinBD = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaMediiInFisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afiseazaGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareBmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificareGraficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.culoareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Materii";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Note";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date Student";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(291, 191);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(119, 24);
            this.tbId.TabIndex = 8;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(194, 243);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(214, 24);
            this.tbNume.TabIndex = 9;
            // 
            // tbMaterii
            // 
            this.tbMaterii.Location = new System.Drawing.Point(129, 313);
            this.tbMaterii.Name = "tbMaterii";
            this.tbMaterii.Size = new System.Drawing.Size(281, 24);
            this.tbMaterii.TabIndex = 13;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(129, 440);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(281, 24);
            this.tbNote.TabIndex = 14;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdauga.Image = ((System.Drawing.Image)(resources.GetObject("btnAdauga.Image")));
            this.btnAdauga.Location = new System.Drawing.Point(129, 470);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(281, 38);
            this.btnAdauga.TabIndex = 15;
            this.btnAdauga.Text = "Adauga Student in listaStudenti";
            this.btnAdauga.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Numar Credite";
            // 
            // tbNumarCredite
            // 
            this.tbNumarCredite.Location = new System.Drawing.Point(129, 376);
            this.tbNumarCredite.Name = "tbNumarCredite";
            this.tbNumarCredite.Size = new System.Drawing.Size(281, 24);
            this.tbNumarCredite.TabIndex = 17;
            // 
            // btnAfisareStudentiForm2
            // 
            this.btnAfisareStudentiForm2.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAfisareStudentiForm2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAfisareStudentiForm2.BackgroundImage")));
            this.btnAfisareStudentiForm2.Location = new System.Drawing.Point(129, 514);
            this.btnAfisareStudentiForm2.Name = "btnAfisareStudentiForm2";
            this.btnAfisareStudentiForm2.Size = new System.Drawing.Size(281, 40);
            this.btnAfisareStudentiForm2.TabIndex = 18;
            this.btnAfisareStudentiForm2.Text = "Afiseaza studentii pentru salvare";
            this.btnAfisareStudentiForm2.UseVisualStyleBackColor = false;
            this.btnAfisareStudentiForm2.Click += new System.EventHandler(this.btnAfisareStudentiForm2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lvStudenti
            // 
            this.lvStudenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNume,
            this.ColNrMaterii,
            this.colNumarCredite,
            this.colNote,
            this.colMedie,
            this.colTaxa});
            this.lvStudenti.FullRowSelect = true;
            this.lvStudenti.GridLines = true;
            this.lvStudenti.HideSelection = false;
            this.lvStudenti.Location = new System.Drawing.Point(582, 110);
            this.lvStudenti.Name = "lvStudenti";
            this.lvStudenti.Size = new System.Drawing.Size(833, 119);
            this.lvStudenti.TabIndex = 19;
            this.lvStudenti.UseCompatibleStateImageBehavior = false;
            this.lvStudenti.View = System.Windows.Forms.View.Details;
            this.lvStudenti.SelectedIndexChanged += new System.EventHandler(this.lvStudenti_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 32;
            // 
            // colNume
            // 
            this.colNume.Text = "Nume";
            this.colNume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colNume.Width = 138;
            // 
            // ColNrMaterii
            // 
            this.ColNrMaterii.Text = "Materii";
            this.ColNrMaterii.Width = 92;
            // 
            // colNumarCredite
            // 
            this.colNumarCredite.DisplayIndex = 4;
            this.colNumarCredite.Text = "Nr. Credite";
            this.colNumarCredite.Width = 88;
            // 
            // colNote
            // 
            this.colNote.DisplayIndex = 5;
            this.colNote.Text = "Note";
            this.colNote.Width = 90;
            // 
            // colMedie
            // 
            this.colMedie.DisplayIndex = 3;
            this.colMedie.Text = "Medie";
            this.colMedie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colMedie.Width = 51;
            // 
            // colTaxa
            // 
            this.colTaxa.Text = "Taxa";
            this.colTaxa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdaugareLV
            // 
            this.btnAdaugareLV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdaugareLV.BackgroundImage")));
            this.btnAdaugareLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugareLV.Location = new System.Drawing.Point(582, 61);
            this.btnAdaugareLV.Name = "btnAdaugareLV";
            this.btnAdaugareLV.Size = new System.Drawing.Size(232, 32);
            this.btnAdaugareLV.TabIndex = 20;
            this.btnAdaugareLV.Text = "Afisare Studenti in LV";
            this.btnAdaugareLV.UseVisualStyleBackColor = true;
            this.btnAdaugareLV.Click += new System.EventHandler(this.btnAdaugareLV_Click);
            // 
            // btnAdaugaNota
            // 
            this.btnAdaugaNota.Location = new System.Drawing.Point(1245, 78);
            this.btnAdaugaNota.Name = "btnAdaugaNota";
            this.btnAdaugaNota.Size = new System.Drawing.Size(169, 26);
            this.btnAdaugaNota.TabIndex = 21;
            this.btnAdaugaNota.Text = "Adauga Nota";
            this.btnAdaugaNota.UseVisualStyleBackColor = true;
            this.btnAdaugaNota.Click += new System.EventHandler(this.btnAdaugaNota_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 612);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 24);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // btnPopulare
            // 
            this.btnPopulare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPopulare.BackgroundImage")));
            this.btnPopulare.Location = new System.Drawing.Point(582, 235);
            this.btnPopulare.Name = "btnPopulare";
            this.btnPopulare.Size = new System.Drawing.Size(313, 43);
            this.btnPopulare.TabIndex = 24;
            this.btnPopulare.Text = "Populare cu studenti din baza de date";
            this.btnPopulare.UseVisualStyleBackColor = true;
            this.btnPopulare.Click += new System.EventHandler(this.btnPopulare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStergere.BackgroundImage")));
            this.btnStergere.Location = new System.Drawing.Point(1217, 235);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(205, 43);
            this.btnStergere.TabIndex = 26;
            this.btnStergere.Text = "Stergere student";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnAdaugareinBD
            // 
            this.btnAdaugareinBD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdaugareinBD.BackgroundImage")));
            this.btnAdaugareinBD.Location = new System.Drawing.Point(129, 560);
            this.btnAdaugareinBD.Name = "btnAdaugareinBD";
            this.btnAdaugareinBD.Size = new System.Drawing.Size(281, 38);
            this.btnAdaugareinBD.TabIndex = 27;
            this.btnAdaugareinBD.Text = "Adauga Student in Baza de Date";
            this.btnAdaugareinBD.UseVisualStyleBackColor = true;
            this.btnAdaugareinBD.Click += new System.EventHandler(this.btnAdaugareinBD_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modificareGraficToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1434, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaMediiInFisierTextToolStripMenuItem,
            this.afiseazaGraficToolStripMenuItem,
            this.printPreviToolStripMenuItem,
            this.salvareBmpToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // salveazaMediiInFisierTextToolStripMenuItem
            // 
            this.salveazaMediiInFisierTextToolStripMenuItem.Name = "salveazaMediiInFisierTextToolStripMenuItem";
            this.salveazaMediiInFisierTextToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.salveazaMediiInFisierTextToolStripMenuItem.Text = "Salveaza medii in fisier text";
            this.salveazaMediiInFisierTextToolStripMenuItem.Click += new System.EventHandler(this.salveazaMediiInFisierTextToolStripMenuItem_Click);
            // 
            // afiseazaGraficToolStripMenuItem
            // 
            this.afiseazaGraficToolStripMenuItem.Name = "afiseazaGraficToolStripMenuItem";
            this.afiseazaGraficToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.afiseazaGraficToolStripMenuItem.Text = "Afiseaza Grafic";
            this.afiseazaGraficToolStripMenuItem.Click += new System.EventHandler(this.afiseazaGraficToolStripMenuItem_Click);
            // 
            // printPreviToolStripMenuItem
            // 
            this.printPreviToolStripMenuItem.Name = "printPreviToolStripMenuItem";
            this.printPreviToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.printPreviToolStripMenuItem.Text = "Print preview";
            this.printPreviToolStripMenuItem.Click += new System.EventHandler(this.printPreviToolStripMenuItem_Click);
            // 
            // salvareBmpToolStripMenuItem
            // 
            this.salvareBmpToolStripMenuItem.Name = "salvareBmpToolStripMenuItem";
            this.salvareBmpToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.salvareBmpToolStripMenuItem.Text = "Salvare bmp";
            this.salvareBmpToolStripMenuItem.Click += new System.EventHandler(this.salvareBmpToolStripMenuItem_Click);
            // 
            // modificareGraficToolStripMenuItem
            // 
            this.modificareGraficToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.culoareToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.modificareGraficToolStripMenuItem.Name = "modificareGraficToolStripMenuItem";
            this.modificareGraficToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.modificareGraficToolStripMenuItem.Text = "Modificare grafic";
            // 
            // culoareToolStripMenuItem
            // 
            this.culoareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bariToolStripMenuItem,
            this.textToolStripMenuItem});
            this.culoareToolStripMenuItem.Name = "culoareToolStripMenuItem";
            this.culoareToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.culoareToolStripMenuItem.Text = "Culoare";
            // 
            // bariToolStripMenuItem
            // 
            this.bariToolStripMenuItem.Name = "bariToolStripMenuItem";
            this.bariToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.bariToolStripMenuItem.Text = "Bari";
            this.bariToolStripMenuItem.Click += new System.EventHandler(this.bariToolStripMenuItem_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(633, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 363);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(38, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 31);
            this.label3.TabIndex = 30;
            this.label3.Text = "Proiect Situatii Note Studenti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1434, 657);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdaugareinBD);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnPopulare);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAdaugaNota);
            this.Controls.Add(this.btnAdaugareLV);
            this.Controls.Add(this.lvStudenti);
            this.Controls.Add(this.btnAfisareStudentiForm2);
            this.Controls.Add(this.tbNumarCredite);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.tbMaterii);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbMaterii;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbNumarCredite;
        private System.Windows.Forms.Button btnAfisareStudentiForm2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListView lvStudenti;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNume;
        private System.Windows.Forms.ColumnHeader ColNrMaterii;
        private System.Windows.Forms.ColumnHeader colMedie;
        private System.Windows.Forms.Button btnAdaugareLV;
        private System.Windows.Forms.ColumnHeader colNumarCredite;
        private System.Windows.Forms.ColumnHeader colNote;
        private System.Windows.Forms.Button btnAdaugaNota;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ColumnHeader colTaxa;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnPopulare;
        private System.Windows.Forms.Button btnAdaugareinBD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaMediiInFisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afiseazaGraficToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareBmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificareGraficToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem culoareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

