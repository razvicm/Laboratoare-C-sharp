namespace form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.valtva = new System.Windows.Forms.Label();
            this.valoare = new System.Windows.Forms.TextBox();
            this.tva = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pret produs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Procent TVA";
            // 
            // valtva
            // 
            this.valtva.AutoSize = true;
            this.valtva.Location = new System.Drawing.Point(59, 172);
            this.valtva.Name = "valtva";
            this.valtva.Size = new System.Drawing.Size(65, 13);
            this.valtva.TabIndex = 2;
            this.valtva.Text = "Pret cu TVA";
            // 
            // valoare
            // 
            this.valoare.Location = new System.Drawing.Point(202, 57);
            this.valoare.Name = "valoare";
            this.valoare.Size = new System.Drawing.Size(100, 20);
            this.valoare.TabIndex = 3;
            this.valoare.TextChanged += new System.EventHandler(this.pret_TextChanged);
            // 
            // tva
            // 
            this.tva.Location = new System.Drawing.Point(202, 107);
            this.tva.Name = "tva";
            this.tva.Size = new System.Drawing.Size(100, 20);
            this.tva.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculeaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Iesire";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tva);
            this.Controls.Add(this.valoare);
            this.Controls.Add(this.valtva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcul TVA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valtva;
        private System.Windows.Forms.TextBox valoare;
        private System.Windows.Forms.TextBox tva;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

