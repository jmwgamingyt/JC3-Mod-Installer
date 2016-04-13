namespace Mod_Installer___Manager
{
    partial class XmlCreator
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
            this.button1 = new System.Windows.Forms.Button();
            this.modType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.modID = new System.Windows.Forms.TextBox();
            this.modderID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.modVer = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.modDir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modType
            // 
            this.modType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modType.FormattingEnabled = true;
            this.modType.Items.AddRange(new object[] {
            "dropzone",
            "dropzone_sky_fortress"});
            this.modType.Location = new System.Drawing.Point(95, 6);
            this.modType.Name = "modType";
            this.modType.Size = new System.Drawing.Size(177, 21);
            this.modType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mod Type :";
            // 
            // modID
            // 
            this.modID.Location = new System.Drawing.Point(95, 59);
            this.modID.Name = "modID";
            this.modID.Size = new System.Drawing.Size(177, 20);
            this.modID.TabIndex = 3;
            // 
            // modderID
            // 
            this.modderID.Location = new System.Drawing.Point(95, 33);
            this.modderID.Name = "modderID";
            this.modderID.Size = new System.Drawing.Size(177, 20);
            this.modderID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modder Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mod ID :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mod Version :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mod Folder :";
            // 
            // modVer
            // 
            this.modVer.Location = new System.Drawing.Point(95, 87);
            this.modVer.Name = "modVer";
            this.modVer.Size = new System.Drawing.Size(177, 20);
            this.modVer.TabIndex = 9;
            // 
            // modDir
            // 
            this.modDir.Location = new System.Drawing.Point(95, 117);
            this.modDir.Name = "modDir";
            this.modDir.Size = new System.Drawing.Size(177, 20);
            this.modDir.TabIndex = 10;
            // 
            // XmlCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 173);
            this.Controls.Add(this.modDir);
            this.Controls.Add(this.modVer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modderID);
            this.Controls.Add(this.modID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modType);
            this.Controls.Add(this.button1);
            this.Name = "XmlCreator";
            this.Text = "XmlCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox modType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox modID;
        private System.Windows.Forms.TextBox modderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox modVer;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox modDir;
    }
}