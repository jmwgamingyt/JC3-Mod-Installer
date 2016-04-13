using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;


namespace Installer
{
    public partial class Main : Form
    {
        static string dir,
            file = "mod.xml",
            id = "Mod ID",
            ver = "Mod Version",
            modder = "Modder Name",
            sky_fortress_dropzone_dir = "Folder To Copy To Sky Fortress Packer",
            installer_dir = FileSystem.CurrentDirectory;

        private void uninstall_Click(object sender, EventArgs e)
        {
            read();
            if(FileSystem.DirectoryExists(dir + @"dropzone_sky_fortress\__UNKNOWN\" + sky_fortress_dropzone_dir))
            {
                DialogResult result = MessageBox.Show("Are You Sure You Want To Uninstall " + id + " V" + ver + " By " + modder, "", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        {
                            FileSystem.DeleteDirectory(dir + @"dropzone_sky_fortress\__UNKNOWN\" + sky_fortress_dropzone_dir,DeleteDirectoryOption.DeleteAllContents);
                            FileSystem.DeleteFile(dir + @"dropzone_sky_fortress\__UNKNOWN\" + modder + "_" + id + ".xml");
                            repack();
                        }
                        break;
                }
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            switch(result)
            {
                case DialogResult.OK:
                    {
                        file = openFileDialog1.FileName;
                        installer_dir = Path.GetDirectoryName(file);
                        read();
                    }
                    break;
            }
        }

        private void install_Click(object sender, EventArgs e)
        {
            read();
            DialogResult result = MessageBox.Show("Are You Sure You Want To Install " + id + " V" + ver + " By " + modder, "", MessageBoxButtons.YesNo);
            switch(result)
            {
                case DialogResult.Yes:
                    {
                        FileSystem.CopyDirectory(installer_dir + @"\" + sky_fortress_dropzone_dir, dir + @"dropzone_sky_fortress\__UNKNOWN\" + sky_fortress_dropzone_dir, true);
                        FileSystem.CopyFile(file, dir + @"dropzone_sky_fortress\__UNKNOWN\" + modder + "_" + id + ".xml", true);
                        repack();
                    }
                    break;
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (var key = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Steam App 225540"))
            {
                dir = ((string)key.GetValue("InstallLocation")+@"\");
            }
            read();
        }
        public void read()
        {
            using (XmlReader xmlr = XmlReader.Create(file))
            {
                xmlr.ReadToFollowing("mod");
                id = xmlr.GetAttribute("id");
                ver = xmlr.GetAttribute("ver");
                modder = xmlr.GetAttribute("modder");
                sky_fortress_dropzone_dir = xmlr.GetAttribute("sky_fortress_dropzone_dir");
            }
        }
        public void write()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.NewLineOnAttributes = true;
            settings.Indent = true;
            using (XmlWriter xmlw = XmlWriter.Create(file,settings))
            {
                xmlw.WriteStartDocument();
                xmlw.WriteStartElement("mod");
                xmlw.WriteAttributeString("id", id);
                xmlw.WriteAttributeString("ver", ver);
                xmlw.WriteAttributeString("modder", modder);
                xmlw.WriteAttributeString("sky_fortress_dropzone_dir", sky_fortress_dropzone_dir);
                xmlw.WriteEndElement();
                xmlw.WriteEndDocument();
            }
        }
        public void repack()
        {

            FileSystem.CurrentDirectory = dir + @"dropzone_sky_fortress";
            System.Diagnostics.Process.Start(dir + @"dropzone_sky_fortress\SkyFortressPacker.exe");
            FileSystem.CurrentDirectory = installer_dir;
        }
    }
}
