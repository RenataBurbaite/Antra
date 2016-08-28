namespace LD5
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
            this.skaitymasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skaitytiKeliautojusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skaitytiViešbučiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.išvedimasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.išvestiKeliautojusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.išvestiViešbučiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skaitymasToolStripMenuItem,
            this.išvedimasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // skaitymasToolStripMenuItem
            // 
            this.skaitymasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skaitytiKeliautojusToolStripMenuItem,
            this.skaitytiViešbučiusToolStripMenuItem});
            this.skaitymasToolStripMenuItem.Name = "skaitymasToolStripMenuItem";
            this.skaitymasToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.skaitymasToolStripMenuItem.Text = "Skaitymas";
            // 
            // skaitytiKeliautojusToolStripMenuItem
            // 
            this.skaitytiKeliautojusToolStripMenuItem.Name = "skaitytiKeliautojusToolStripMenuItem";
            this.skaitytiKeliautojusToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.skaitytiKeliautojusToolStripMenuItem.Text = "Skaityti keliautojus";
            this.skaitytiKeliautojusToolStripMenuItem.Click += new System.EventHandler(this.skaitytiKeliautojusToolStripMenuItem_Click);
            // 
            // skaitytiViešbučiusToolStripMenuItem
            // 
            this.skaitytiViešbučiusToolStripMenuItem.Name = "skaitytiViešbučiusToolStripMenuItem";
            this.skaitytiViešbučiusToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.skaitytiViešbučiusToolStripMenuItem.Text = "Skaityti viešbučius";
            this.skaitytiViešbučiusToolStripMenuItem.Click += new System.EventHandler(this.skaitytiViešbučiusToolStripMenuItem_Click);
            // 
            // išvedimasToolStripMenuItem
            // 
            this.išvedimasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.išvestiKeliautojusToolStripMenuItem,
            this.išvestiViešbučiusToolStripMenuItem});
            this.išvedimasToolStripMenuItem.Name = "išvedimasToolStripMenuItem";
            this.išvedimasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.išvedimasToolStripMenuItem.Text = "Išvedimas";
            // 
            // išvestiKeliautojusToolStripMenuItem
            // 
            this.išvestiKeliautojusToolStripMenuItem.Name = "išvestiKeliautojusToolStripMenuItem";
            this.išvestiKeliautojusToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.išvestiKeliautojusToolStripMenuItem.Text = "Išvesti keliautojus";
            this.išvestiKeliautojusToolStripMenuItem.Click += new System.EventHandler(this.išvestiKeliautojusToolStripMenuItem_Click);
            // 
            // išvestiViešbučiusToolStripMenuItem
            // 
            this.išvestiViešbučiusToolStripMenuItem.Name = "išvestiViešbučiusToolStripMenuItem";
            this.išvestiViešbučiusToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.išvestiViešbučiusToolStripMenuItem.Text = "Išvesti viešbučius";
            this.išvestiViešbučiusToolStripMenuItem.Click += new System.EventHandler(this.išvestiViešbučiusToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 398);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem skaitymasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skaitytiKeliautojusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skaitytiViešbučiusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem išvedimasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem išvestiKeliautojusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem išvestiViešbučiusToolStripMenuItem;
    }
}

