namespace Telecom
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fizica = new System.Windows.Forms.RadioButton();
            this.juridica = new System.Windows.Forms.RadioButton();
            this.pf = new System.Windows.Forms.CheckBox();
            this.info = new System.Windows.Forms.CheckBox();
            this.cs = new System.Windows.Forms.CheckBox();
            this.mesaj = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nume = new System.Windows.Forms.TextBox();
            this.adresa = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.continuare = new System.Windows.Forms.Button();
            this.inchide = new System.Windows.Forms.Button();
            this.renunta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(137, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bine ati venit la Telecom serviciul clienti";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.juridica);
            this.groupBox1.Controls.Add(this.fizica);
            this.groupBox1.Location = new System.Drawing.Point(69, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // fizica
            // 
            this.fizica.AutoSize = true;
            this.fizica.Location = new System.Drawing.Point(25, 19);
            this.fizica.Name = "fizica";
            this.fizica.Size = new System.Drawing.Size(97, 17);
            this.fizica.TabIndex = 0;
            this.fizica.TabStop = true;
            this.fizica.Text = "Persoana fizica";
            this.fizica.UseVisualStyleBackColor = true;
            // 
            // juridica
            // 
            this.juridica.AutoSize = true;
            this.juridica.Location = new System.Drawing.Point(330, 19);
            this.juridica.Name = "juridica";
            this.juridica.Size = new System.Drawing.Size(106, 17);
            this.juridica.TabIndex = 1;
            this.juridica.TabStop = true;
            this.juridica.Text = "Persoana juridica";
            this.juridica.UseVisualStyleBackColor = true;
            // 
            // pf
            // 
            this.pf.AutoSize = true;
            this.pf.Location = new System.Drawing.Point(85, 172);
            this.pf.Name = "pf";
            this.pf.Size = new System.Drawing.Size(86, 17);
            this.pf.TabIndex = 2;
            this.pf.Text = "Plata factura";
            this.pf.UseVisualStyleBackColor = true;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(85, 205);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(104, 17);
            this.info.TabIndex = 3;
            this.info.Text = "Informatii factura";
            this.info.UseVisualStyleBackColor = true;
            // 
            // cs
            // 
            this.cs.AutoSize = true;
            this.cs.Location = new System.Drawing.Point(85, 241);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(116, 17);
            this.cs.TabIndex = 4;
            this.cs.Text = "Contractare servicii";
            this.cs.UseVisualStyleBackColor = true;
            this.cs.CheckedChanged += new System.EventHandler(this.cs_CheckedChanged);
            // 
            // mesaj
            // 
            this.mesaj.AutoSize = true;
            this.mesaj.Location = new System.Drawing.Point(324, 172);
            this.mesaj.Name = "mesaj";
            this.mesaj.Size = new System.Drawing.Size(0, 13);
            this.mesaj.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parola";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nume
            // 
            this.nume.Location = new System.Drawing.Point(138, 273);
            this.nume.Name = "nume";
            this.nume.Size = new System.Drawing.Size(100, 20);
            this.nume.TabIndex = 9;
            // 
            // adresa
            // 
            this.adresa.Location = new System.Drawing.Point(138, 304);
            this.adresa.Name = "adresa";
            this.adresa.Size = new System.Drawing.Size(100, 20);
            this.adresa.TabIndex = 10;
            // 
            // parola
            // 
            this.parola.Location = new System.Drawing.Point(138, 332);
            this.parola.Name = "parola";
            this.parola.PasswordChar = '*';
            this.parola.Size = new System.Drawing.Size(100, 20);
            this.parola.TabIndex = 11;
            // 
            // continuare
            // 
            this.continuare.BackColor = System.Drawing.Color.LimeGreen;
            this.continuare.Location = new System.Drawing.Point(68, 369);
            this.continuare.Name = "continuare";
            this.continuare.Size = new System.Drawing.Size(105, 23);
            this.continuare.TabIndex = 12;
            this.continuare.Text = "Eliberare numar";
            this.continuare.UseVisualStyleBackColor = false;
            this.continuare.Click += new System.EventHandler(this.continuare_Click);
            // 
            // inchide
            // 
            this.inchide.BackColor = System.Drawing.Color.LimeGreen;
            this.inchide.Location = new System.Drawing.Point(250, 369);
            this.inchide.Name = "inchide";
            this.inchide.Size = new System.Drawing.Size(105, 23);
            this.inchide.TabIndex = 13;
            this.inchide.Text = "Inchidere";
            this.inchide.UseVisualStyleBackColor = false;
            this.inchide.Visible = false;
            this.inchide.Click += new System.EventHandler(this.inchide_Click);
            // 
            // renunta
            // 
            this.renunta.BackColor = System.Drawing.Color.LimeGreen;
            this.renunta.Location = new System.Drawing.Point(432, 369);
            this.renunta.Name = "renunta";
            this.renunta.Size = new System.Drawing.Size(105, 23);
            this.renunta.TabIndex = 14;
            this.renunta.Text = "Stergere";
            this.renunta.UseVisualStyleBackColor = false;
            this.renunta.Click += new System.EventHandler(this.renunta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 405);
            this.ControlBox = false;
            this.Controls.Add(this.renunta);
            this.Controls.Add(this.inchide);
            this.Controls.Add(this.continuare);
            this.Controls.Add(this.parola);
            this.Controls.Add(this.adresa);
            this.Controls.Add(this.nume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mesaj);
            this.Controls.Add(this.cs);
            this.Controls.Add(this.info);
            this.Controls.Add(this.pf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Serviciul clienti";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton juridica;
        private System.Windows.Forms.RadioButton fizica;
        private System.Windows.Forms.CheckBox pf;
        private System.Windows.Forms.CheckBox info;
        private System.Windows.Forms.CheckBox cs;
        private System.Windows.Forms.Label mesaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nume;
        private System.Windows.Forms.TextBox adresa;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.Button continuare;
        private System.Windows.Forms.Button inchide;
        private System.Windows.Forms.Button renunta;
    }
}

