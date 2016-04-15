using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class XmlGen : Form
    {
        public XmlGen()
        {
            InitializeComponent();
        }

        private void XmlGen_Load(object sender, EventArgs e)
        {
            Main.read();
            id.Text = Main.id;
            modder.Text = Main.modder;
            ver.Text = Main.ver;
            dir.Text = Main.sky_fortress_dropzone_dir;
        }

        private void Gen_Click(object sender, EventArgs e)
        {
            Main.id = id.Text;
            Main.modder = modder.Text;
            Main.ver = ver.Text;
            Main.sky_fortress_dropzone_dir = dir.Text;
            Main.write();
        }
    }
}
