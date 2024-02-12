
namespace ProiectPAW_Studenti
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbNumarCredite = new System.Windows.Forms.TextBox();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdaugaNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDenumire
            // 
            this.tbDenumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDenumire.Location = new System.Drawing.Point(406, 141);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(162, 27);
            this.tbDenumire.TabIndex = 0;
            this.tbDenumire.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNumarCredite
            // 
            this.tbNumarCredite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumarCredite.Location = new System.Drawing.Point(406, 197);
            this.tbNumarCredite.Name = "tbNumarCredite";
            this.tbNumarCredite.Size = new System.Drawing.Size(162, 27);
            this.tbNumarCredite.TabIndex = 1;
            // 
            // tbNota
            // 
            this.tbNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNota.Location = new System.Drawing.Point(406, 251);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(162, 27);
            this.tbNota.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Denumire materie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numar de credite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota obtinuta";
            // 
            // btnAdaugaNota
            // 
            this.btnAdaugaNota.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdaugaNota.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdaugaNota.BackgroundImage")));
            this.btnAdaugaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaNota.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdaugaNota.Location = new System.Drawing.Point(299, 316);
            this.btnAdaugaNota.Name = "btnAdaugaNota";
            this.btnAdaugaNota.Size = new System.Drawing.Size(212, 36);
            this.btnAdaugaNota.TabIndex = 6;
            this.btnAdaugaNota.Text = "Adauga nota";
            this.btnAdaugaNota.UseVisualStyleBackColor = false;
            this.btnAdaugaNota.Click += new System.EventHandler(this.btnAdaugaNota_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdaugaNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.tbNumarCredite);
            this.Controls.Add(this.tbDenumire);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbNumarCredite;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdaugaNota;
    }
}