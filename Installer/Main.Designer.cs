namespace Installer
{
    partial class Main
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
            this.install = new System.Windows.Forms.Button();
            this.uninstall = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // install
            // 
            this.install.Location = new System.Drawing.Point(12, 12);
            this.install.Name = "install";
            this.install.Size = new System.Drawing.Size(260, 23);
            this.install.TabIndex = 0;
            this.install.Text = "Install Mod";
            this.install.UseVisualStyleBackColor = true;
            this.install.Click += new System.EventHandler(this.install_Click);
            // 
            // uninstall
            // 
            this.uninstall.Location = new System.Drawing.Point(12, 41);
            this.uninstall.Name = "uninstall";
            this.uninstall.Size = new System.Drawing.Size(260, 23);
            this.uninstall.TabIndex = 1;
            this.uninstall.Text = "Uninstall Mod";
            this.uninstall.UseVisualStyleBackColor = true;
            this.uninstall.Click += new System.EventHandler(this.uninstall_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(12, 70);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(260, 23);
            this.load.TabIndex = 2;
            this.load.Text = "Load Custom XML File";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.load);
            this.Controls.Add(this.uninstall);
            this.Controls.Add(this.install);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Installer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button install;
        private System.Windows.Forms.Button uninstall;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

