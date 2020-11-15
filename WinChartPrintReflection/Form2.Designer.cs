namespace WinChartPrintReflection
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.프린트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프린터선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프린트용지설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.프린트미리보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인쇄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프린트ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 프린트ToolStripMenuItem
            // 
            this.프린트ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.프린터선택ToolStripMenuItem,
            this.프린트용지설정ToolStripMenuItem,
            this.프린트미리보기ToolStripMenuItem,
            this.인쇄ToolStripMenuItem});
            this.프린트ToolStripMenuItem.Name = "프린트ToolStripMenuItem";
            this.프린트ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.프린트ToolStripMenuItem.Text = "프린트";
            // 
            // 프린터선택ToolStripMenuItem
            // 
            this.프린터선택ToolStripMenuItem.Name = "프린터선택ToolStripMenuItem";
            this.프린터선택ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.프린터선택ToolStripMenuItem.Text = "프린터 선택";
            this.프린터선택ToolStripMenuItem.Click += new System.EventHandler(this.프린터선택ToolStripMenuItem_Click);
            // 
            // 프린트용지설정ToolStripMenuItem
            // 
            this.프린트용지설정ToolStripMenuItem.Name = "프린트용지설정ToolStripMenuItem";
            this.프린트용지설정ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.프린트용지설정ToolStripMenuItem.Text = "프린트 용지설정";
            this.프린트용지설정ToolStripMenuItem.Click += new System.EventHandler(this.프린트용지설정ToolStripMenuItem_Click);
            // 
            // 프린트미리보기ToolStripMenuItem
            // 
            this.프린트미리보기ToolStripMenuItem.Name = "프린트미리보기ToolStripMenuItem";
            this.프린트미리보기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.프린트미리보기ToolStripMenuItem.Text = "프린트 미리보기";
            this.프린트미리보기ToolStripMenuItem.Click += new System.EventHandler(this.프린트미리보기ToolStripMenuItem_Click);
            // 
            // 인쇄ToolStripMenuItem
            // 
            this.인쇄ToolStripMenuItem.Name = "인쇄ToolStripMenuItem";
            this.인쇄ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.인쇄ToolStripMenuItem.Text = "인쇄";
            this.인쇄ToolStripMenuItem.Click += new System.EventHandler(this.인쇄ToolStripMenuItem_Click);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 프린트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프린터선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프린트용지설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 프린트미리보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인쇄ToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}