namespace Restaurant
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listam = new System.Windows.Forms.CheckedListBox();
            this.listab = new System.Windows.Forms.CheckedListBox();
            this.nrmasa = new System.Windows.Forms.ComboBox();
            this.comanda = new System.Windows.Forms.Button();
            this.preluat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meniul zilei";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preparate culinare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bauturi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Masa";
            // 
            // listam
            // 
            this.listam.CheckOnClick = true;
            this.listam.FormattingEnabled = true;
            this.listam.Location = new System.Drawing.Point(56, 114);
            this.listam.Name = "listam";
            this.listam.Size = new System.Drawing.Size(120, 94);
            this.listam.TabIndex = 4;
            // 
            // listab
            // 
            this.listab.CheckOnClick = true;
            this.listab.FormattingEnabled = true;
            this.listab.Location = new System.Drawing.Point(56, 233);
            this.listab.Name = "listab";
            this.listab.Size = new System.Drawing.Size(120, 94);
            this.listab.TabIndex = 5;
            // 
            // nrmasa
            // 
            this.nrmasa.FormattingEnabled = true;
            this.nrmasa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.nrmasa.Location = new System.Drawing.Point(113, 330);
            this.nrmasa.Name = "nrmasa";
            this.nrmasa.Size = new System.Drawing.Size(122, 21);
            this.nrmasa.TabIndex = 6;
            // 
            // comanda
            // 
            this.comanda.Location = new System.Drawing.Point(56, 367);
            this.comanda.Name = "comanda";
            this.comanda.Size = new System.Drawing.Size(75, 23);
            this.comanda.TabIndex = 7;
            this.comanda.Text = "Comanda";
            this.comanda.UseVisualStyleBackColor = true;
            this.comanda.Click += new System.EventHandler(this.comanda_Click);
            // 
            // preluat
            // 
            this.preluat.Location = new System.Drawing.Point(243, 367);
            this.preluat.Name = "preluat";
            this.preluat.Size = new System.Drawing.Size(75, 23);
            this.preluat.TabIndex = 8;
            this.preluat.Text = "Preluat";
            this.preluat.UseVisualStyleBackColor = true;
            this.preluat.Click += new System.EventHandler(this.preluat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 402);
            this.Controls.Add(this.preluat);
            this.Controls.Add(this.comanda);
            this.Controls.Add(this.nrmasa);
            this.Controls.Add(this.listab);
            this.Controls.Add(this.listam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox listam;
        private System.Windows.Forms.CheckedListBox listab;
        private System.Windows.Forms.ComboBox nrmasa;
        private System.Windows.Forms.Button comanda;
        private System.Windows.Forms.Button preluat;
    }
}

