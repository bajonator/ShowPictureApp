using ShowPictureApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowPictureApp
{
    public partial class Main : Form
    {
        string filePath;
        public Main()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileName();
            pbImage.Image = LoadImage();
            tbSourceImage.Text = filePath;
        }

        private Image LoadImage()
        {
            if (filePath != null && File.Exists(filePath))
            {
                byte[] image = File.ReadAllBytes(filePath);
                using (MemoryStream ms = new MemoryStream(image))
                {
                    btnClearPicture.Enabled = true;
                    return Image.FromStream(ms);
                }
            }
            return null;
        }

        private void OpenFileName()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
        }

        private void btnClearPicture_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
            tbSourceImage.Text = null;
            btnClearPicture.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(pbImage.Image != null)
                Properties.Settings.Default.fileSourceImage = filePath;
            else
                Properties.Settings.Default.fileSourceImage = "";

            Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filePath = Properties.Settings.Default.fileSourceImage;
            if (filePath != "")
            {
                pbImage.Image = LoadImage();
            }
        }
    }
}
