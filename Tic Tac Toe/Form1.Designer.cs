namespace Tic_Tac_Toe
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWGAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A6 = new System.Windows.Forms.Button();
            this.A5 = new System.Windows.Forms.Button();
            this.A4 = new System.Windows.Forms.Button();
            this.A9 = new System.Windows.Forms.Button();
            this.A8 = new System.Windows.Forms.Button();
            this.A7 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hELPToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(335, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWGAMEToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.fileToolStripMenuItem.Text = "FILE";
            // 
            // nEWGAMEToolStripMenuItem
            // 
            this.nEWGAMEToolStripMenuItem.Name = "nEWGAMEToolStripMenuItem";
            this.nEWGAMEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nEWGAMEToolStripMenuItem.Text = "NEW GAME";
            this.nEWGAMEToolStripMenuItem.Click += new System.EventHandler(this.NEWGAMEToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.EXITToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBOUTToolStripMenuItem});
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.hELPToolStripMenuItem.Text = "HELP";
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.aBOUTToolStripMenuItem.Text = "ABOUT";
            this.aBOUTToolStripMenuItem.Click += new System.EventHandler(this.ABOUTToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(24, 49);
            this.A1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(90, 90);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(120, 49);
            this.A2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(90, 90);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(216, 49);
            this.A3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(90, 90);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // A6
            // 
            this.A6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A6.Location = new System.Drawing.Point(216, 143);
            this.A6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A6.Name = "A6";
            this.A6.Size = new System.Drawing.Size(90, 90);
            this.A6.TabIndex = 6;
            this.A6.UseVisualStyleBackColor = true;
            this.A6.Click += new System.EventHandler(this.button_click);
            // 
            // A5
            // 
            this.A5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A5.Location = new System.Drawing.Point(120, 143);
            this.A5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A5.Name = "A5";
            this.A5.Size = new System.Drawing.Size(90, 90);
            this.A5.TabIndex = 5;
            this.A5.UseVisualStyleBackColor = true;
            this.A5.Click += new System.EventHandler(this.button_click);
            // 
            // A4
            // 
            this.A4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A4.Location = new System.Drawing.Point(24, 146);
            this.A4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A4.Name = "A4";
            this.A4.Size = new System.Drawing.Size(90, 90);
            this.A4.TabIndex = 4;
            this.A4.UseVisualStyleBackColor = true;
            this.A4.Click += new System.EventHandler(this.button_click);
            // 
            // A9
            // 
            this.A9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A9.Location = new System.Drawing.Point(216, 240);
            this.A9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A9.Name = "A9";
            this.A9.Size = new System.Drawing.Size(90, 90);
            this.A9.TabIndex = 9;
            this.A9.UseVisualStyleBackColor = true;
            this.A9.Click += new System.EventHandler(this.button_click);
            // 
            // A8
            // 
            this.A8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A8.Location = new System.Drawing.Point(120, 240);
            this.A8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A8.Name = "A8";
            this.A8.Size = new System.Drawing.Size(90, 90);
            this.A8.TabIndex = 8;
            this.A8.UseVisualStyleBackColor = true;
            this.A8.Click += new System.EventHandler(this.button_click);
            // 
            // A7
            // 
            this.A7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A7.Location = new System.Drawing.Point(24, 240);
            this.A7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A7.Name = "A7";
            this.A7.Size = new System.Drawing.Size(90, 90);
            this.A7.TabIndex = 7;
            this.A7.UseVisualStyleBackColor = true;
            this.A7.Click += new System.EventHandler(this.button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(335, 347);
            this.Controls.Add(this.A9);
            this.Controls.Add(this.A8);
            this.Controls.Add(this.A7);
            this.Controls.Add(this.A6);
            this.Controls.Add(this.A5);
            this.Controls.Add(this.A4);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWGAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A6;
        private System.Windows.Forms.Button A5;
        private System.Windows.Forms.Button A4;
        private System.Windows.Forms.Button A9;
        private System.Windows.Forms.Button A8;
        private System.Windows.Forms.Button A7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

