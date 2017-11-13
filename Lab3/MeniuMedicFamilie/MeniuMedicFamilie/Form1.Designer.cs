namespace MeniuMedicFamilie
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planificatiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numarTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oreLibereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientiToolStripMenuItem,
            this.listareToolStripMenuItem1,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientiToolStripMenuItem
            // 
            this.pacientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programareToolStripMenuItem,
            this.oreLibereToolStripMenuItem});
            this.pacientiToolStripMenuItem.Name = "pacientiToolStripMenuItem";
            this.pacientiToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pacientiToolStripMenuItem.Text = "Pacienti";
            // 
            // listareToolStripMenuItem1
            // 
            this.listareToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.planificatiToolStripMenuItem,
            this.numarTotalToolStripMenuItem});
            this.listareToolStripMenuItem1.Name = "listareToolStripMenuItem1";
            this.listareToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.listareToolStripMenuItem1.Text = "Listare";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // planificatiToolStripMenuItem
            // 
            this.planificatiToolStripMenuItem.Name = "planificatiToolStripMenuItem";
            this.planificatiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.planificatiToolStripMenuItem.Text = "Planificati";
            this.planificatiToolStripMenuItem.Click += new System.EventHandler(this.planificatiToolStripMenuItem_Click);
            // 
            // numarTotalToolStripMenuItem
            // 
            this.numarTotalToolStripMenuItem.Name = "numarTotalToolStripMenuItem";
            this.numarTotalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.numarTotalToolStripMenuItem.Text = "Numar total";
            this.numarTotalToolStripMenuItem.Click += new System.EventHandler(this.numarTotalToolStripMenuItem_Click);
            // 
            // programareToolStripMenuItem
            // 
            this.programareToolStripMenuItem.Name = "programareToolStripMenuItem";
            this.programareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.programareToolStripMenuItem.Text = "Programare";
            this.programareToolStripMenuItem.Click += new System.EventHandler(this.programareToolStripMenuItem_Click);
            // 
            // oreLibereToolStripMenuItem
            // 
            this.oreLibereToolStripMenuItem.Name = "oreLibereToolStripMenuItem";
            this.oreLibereToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oreLibereToolStripMenuItem.Text = "Ore libere";
            this.oreLibereToolStripMenuItem.Click += new System.EventHandler(this.oreLibereToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 366);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Medic de familie";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oreLibereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem planificatiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numarTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
    }
}

