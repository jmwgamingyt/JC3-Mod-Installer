using System;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using Microsoft.Win32;

namespace Mod_Installer___Manager
{

    public partial class Main : Form
    {
        static string jc3dir = @"C:\Program Files (x86)\Steam\steamapps\common\Just Cause 3", file = "mod.xml", path, dir = jc3dir + path;
        static bool sky;


        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (var key = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 225540"))
            {
                dir = (string)key.GetValue("InstallLocation");
            }

            switch (FileSystem.FileExists(file))
            {
                case true:
                    {
                        XmlReaderSettings settings = new XmlReaderSettings();
                        XmlReader reader = XmlReader.Create(file, settings);
                        reader.ReadToFollowing("dropzone");
                        string dropzone = reader.GetAttribute("type");
                        if (dropzone == "dropzone_sky_fortress")
                        {
                            path = @"\dropzone_sky_fortress\__UNKNOWN\";
                            dir = jc3dir + path;
                        }
                        else if (dropzone == "dropzone")
                        {
                            path = @"\";
                            dir = jc3dir + path;
                            button3.Enabled = false;
                        }
                        reader.Close();
                    }
                    break;
                case false:
                    {
                        button2.Enabled = button3.Enabled = false;
                        MessageBox.Show("Couldn't Find A Mod, Please Load A Custom File");
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlCreator form = new XmlCreator();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            XmlReader reader = XmlReader.Create(file, settings);
            reader.ReadToFollowing("mod");
            string modid = reader.GetAttribute("id");
            string modder = reader.GetAttribute("modder");
            string modver = reader.GetAttribute("ver");
            string moddir = reader.GetAttribute("dir");
            if (path == @"\") moddir = "dropzone";
            DialogResult result = MessageBox.Show("Do You Want To Install " + modid + " V" + modver + " By " + modder, "", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    {
                        if (Path.GetDirectoryName(file) == "") FileSystem.CopyDirectory(moddir, jc3dir + path + moddir, true);
                        else FileSystem.CopyDirectory(Path.GetDirectoryName(file) + @"\" + moddir, jc3dir + path + moddir, true);
                        if (path == @"\dropzone_sky_fortress\__UNKNOWN\")
                        {
                            FileSystem.CopyFile(openFileDialog.FileName, jc3dir + path + modder + "-" + modid + ".xml", true);
                            FileSystem.CurrentDirectory = jc3dir + @"\dropzone_sky_fortress\";
                            System.Diagnostics.Process.Start(jc3dir + @"\dropzone_sky_fortress\SkyFortressPacker.exe");
                        }
                        Application.Exit();
                    }
                    break;
                case DialogResult.No:
                    {
                        MessageBox.Show("Didn't Install");
                    }
                    break;
            }
            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            XmlReader reader = XmlReader.Create(file, settings);
            reader.ReadToFollowing("mod");
            string modid = reader.GetAttribute("id"), modver = reader.GetAttribute("ver"),
                moddir = reader.GetAttribute("dir"), modder = reader.GetAttribute("modder");
            switch (path == @"\dropzone_sky_fortress\__UNKNOWN\")
            {
                case true:
                    {
                        sky = true;
                    }
                    break;
                case false:
                    {
                        sky = false;
                    }
                    break;
            }
            reader.Close();
            DialogResult result = MessageBox.Show("Are You Sure You Want To Uninstall " + modid + " V" + modver + " By " + modder, "", MessageBoxButtons.YesNo);
            switch (result)
            {
                case DialogResult.Yes:
                    {

                        FileSystem.DeleteDirectory(dir + @"\" + moddir, DeleteDirectoryOption.DeleteAllContents);
                        FileSystem.DeleteFile(dir + @"\" + modder + "-" + modid + ".xml");
                        if (sky == true)
                        {
                            FileSystem.CurrentDirectory = jc3dir + @"\dropzone_sky_fortress\";
                            System.Diagnostics.Process.Start(jc3dir + @"\dropzone_sky_fortress\SkyFortressPacker.exe");
                        }
                        Application.Exit();
                    }
                    break;
                case DialogResult.No:
                    {
                        MessageBox.Show("Didn't Uninstall");
                    }
                    break;
            }
        }

        private void Intro_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + 0.01;
            if (Opacity == 1) Intro.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            switch (result)
            {
                case DialogResult.Cancel:
                    {
                        MessageBox.Show("Cancelled");
                    }
                    break;
                case DialogResult.OK:
                    {
                        file = openFileDialog.FileName;
                        XmlReaderSettings settings = new XmlReaderSettings();
                        XmlReader reader = XmlReader.Create(file, settings);
                        reader.ReadToFollowing("dropzone");
                        string dropzone = reader.GetAttribute("type");
                        if (dropzone == "dropzone_sky_fortress")
                        {
                            path = @"\dropzone_sky_fortress\__UNKNOWN\";
                            dir = Path.GetDirectoryName(file);
                        }
                        else if (dropzone == "dropzone")
                        {
                            path = @"\";
                            dir = Path.GetDirectoryName(file);
                            button3.Enabled = false;
                        }
                        reader.Close();

                        button2.Enabled = button3.Enabled = true;
                    }
                    break;
            }

        }
    }
}
