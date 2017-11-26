namespace CsFloor_Muhasebe
{
    partial class Anasayfa
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
            this.faturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teklifToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teklifKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturaToolStripMenuItem,
            this.teklifToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // faturaToolStripMenuItem
            // 
            this.faturaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.faturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faturaKayıtToolStripMenuItem,
            this.faturaListeleToolStripMenuItem});
            this.faturaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faturaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.faturaToolStripMenuItem.Name = "faturaToolStripMenuItem";
            this.faturaToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.faturaToolStripMenuItem.Text = "Fatura";
            this.faturaToolStripMenuItem.Click += new System.EventHandler(this.faturaToolStripMenuItem_Click);
            // 
            // faturaKayıtToolStripMenuItem
            // 
            this.faturaKayıtToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.faturaKayıtToolStripMenuItem.Name = "faturaKayıtToolStripMenuItem";
            this.faturaKayıtToolStripMenuItem.Size = new System.Drawing.Size(229, 36);
            this.faturaKayıtToolStripMenuItem.Text = "Fatura Kayıt";
            this.faturaKayıtToolStripMenuItem.Click += new System.EventHandler(this.faturaKayıtToolStripMenuItem_Click);
            // 
            // faturaListeleToolStripMenuItem
            // 
            this.faturaListeleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.faturaListeleToolStripMenuItem.Name = "faturaListeleToolStripMenuItem";
            this.faturaListeleToolStripMenuItem.Size = new System.Drawing.Size(229, 36);
            this.faturaListeleToolStripMenuItem.Text = "Fatura Listele";
            this.faturaListeleToolStripMenuItem.Click += new System.EventHandler(this.faturaListeleToolStripMenuItem_Click);
            // 
            // teklifToolStripMenuItem
            // 
            this.teklifToolStripMenuItem.BackColor = System.Drawing.Color.Olive;
            this.teklifToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teklifKayıtToolStripMenuItem});
            this.teklifToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teklifToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.teklifToolStripMenuItem.Name = "teklifToolStripMenuItem";
            this.teklifToolStripMenuItem.Size = new System.Drawing.Size(67, 36);
            this.teklifToolStripMenuItem.Text = "Teklif";
            // 
            // teklifKayıtToolStripMenuItem
            // 
            this.teklifKayıtToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.teklifKayıtToolStripMenuItem.Name = "teklifKayıtToolStripMenuItem";
            this.teklifKayıtToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.teklifKayıtToolStripMenuItem.Text = "Teklif Kayıt";
            this.teklifKayıtToolStripMenuItem.Click += new System.EventHandler(this.teklifKayıtToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(848, 7);
            this.toolStripContainer1.Location = new System.Drawing.Point(8, 8);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(848, 97);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CsFloor_Muhasebe.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(861, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 418);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem faturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teklifToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teklifKayıtToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}