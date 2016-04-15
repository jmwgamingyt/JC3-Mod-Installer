namespace Installer
{
    partial class XmlGen
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
            this.id = new System.Windows.Forms.TextBox();
            this.modder = new System.Windows.Forms.TextBox();
            this.ver = new System.Windows.Forms.TextBox();
            this.dir = new System.Windows.Forms.TextBox();
            this.Gen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(12, 12);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(260, 20);
            this.id.TabIndex = 0;
            // 
            // modder
            // 
            this.modder.Location = new System.Drawing.Point(12, 38);
            this.modder.Name = "modder";
            this.modder.Size = new System.Drawing.Size(260, 20);
            this.modder.TabIndex = 1;
            // 
            // ver
            // 
            this.ver.Location = new System.Drawing.Point(12, 64);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(260, 20);
            this.ver.TabIndex = 2;
            // 
            // dir
            // 
            this.dir.Location = new System.Drawing.Point(12, 90);
            this.dir.Name = "dir";
            this.dir.Size = new System.Drawing.Size(260, 20);
            this.dir.TabIndex = 3;
            // 
            // Gen
            // 
            this.Gen.Location = new System.Drawing.Point(12, 117);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(260, 23);
            this.Gen.TabIndex = 4;
            this.Gen.Text = "Generate Xml";
            this.Gen.UseVisualStyleBackColor = true;
            this.Gen.Click += new System.EventHandler(this.Gen_Click);
            // 
            // XmlGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 147);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.dir);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.modder);
            this.Controls.Add(this.id);
            this.Name = "XmlGen";
            this.ShowIcon = false;
            this.Text = "XmlGen";
            this.Load += new System.EventHandler(this.XmlGen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox modder;
        private System.Windows.Forms.TextBox ver;
        private System.Windows.Forms.TextBox dir;
        private System.Windows.Forms.Button Gen;
    }
}