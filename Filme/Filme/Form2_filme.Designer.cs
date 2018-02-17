namespace Filme
{
    partial class Form2_filme
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_actori = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBox_film = new System.Windows.Forms.ComboBox();
            this.tBox_an = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagina cu filme";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nume film";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "An aparitie";
            // 
            // lb_actori
            // 
            this.lb_actori.FormattingEnabled = true;
            this.lb_actori.Location = new System.Drawing.Point(388, 55);
            this.lb_actori.Name = "lb_actori";
            this.lb_actori.Size = new System.Drawing.Size(135, 95);
            this.lb_actori.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Actori";
            // 
            // cBox_film
            // 
            this.cBox_film.FormattingEnabled = true;
            this.cBox_film.Location = new System.Drawing.Point(121, 52);
            this.cBox_film.Name = "cBox_film";
            this.cBox_film.Size = new System.Drawing.Size(121, 21);
            this.cBox_film.TabIndex = 8;
            this.cBox_film.SelectedIndexChanged += new System.EventHandler(this.cBox_film_SelectedIndexChanged);
            // 
            // tBox_an
            // 
            this.tBox_an.Location = new System.Drawing.Point(121, 98);
            this.tBox_an.Name = "tBox_an";
            this.tBox_an.Size = new System.Drawing.Size(82, 20);
            this.tBox_an.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Adauga film";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(340, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Iesire";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(20, 124);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(314, 180);
            this.webBrowser1.TabIndex = 13;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Form2_filme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 329);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tBox_an);
            this.Controls.Add(this.cBox_film);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_actori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2_filme";
            this.Text = "Form2_filme";
            this.Load += new System.EventHandler(this.Form2_filme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_actori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBox_film;
        private System.Windows.Forms.TextBox tBox_an;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}