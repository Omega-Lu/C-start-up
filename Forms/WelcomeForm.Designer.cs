namespace WindowsFormsApp6.Forms
{
    partial class WelcomeForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.wELCOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELLOWORLDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cALCULATORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(30, 624);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wELCOMEToolStripMenuItem,
            this.hELLOWORLDToolStripMenuItem,
            this.cALCULATORToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(919, 28);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // wELCOMEToolStripMenuItem
            // 
            this.wELCOMEToolStripMenuItem.Name = "wELCOMEToolStripMenuItem";
            this.wELCOMEToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.wELCOMEToolStripMenuItem.Text = "WELCOME";
            this.wELCOMEToolStripMenuItem.Click += new System.EventHandler(this.wELCOMEToolStripMenuItem_Click);
            // 
            // hELLOWORLDToolStripMenuItem
            // 
            this.hELLOWORLDToolStripMenuItem.Name = "hELLOWORLDToolStripMenuItem";
            this.hELLOWORLDToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.hELLOWORLDToolStripMenuItem.Text = "HELLO WORLD";
            this.hELLOWORLDToolStripMenuItem.Click += new System.EventHandler(this.hELLOWORLDToolStripMenuItem_Click);
            // 
            // cALCULATORToolStripMenuItem
            // 
            this.cALCULATORToolStripMenuItem.Name = "cALCULATORToolStripMenuItem";
            this.cALCULATORToolStripMenuItem.Size = new System.Drawing.Size(110, 34);
            this.cALCULATORToolStripMenuItem.Text = "CALCULATOR";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 652);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem wELCOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELLOWORLDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cALCULATORToolStripMenuItem;
    }
}