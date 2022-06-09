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

namespace ejemplo_picturebox
{
    public partial class Form1 : Form
    {

        private string path;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "JPEG(*.JPG)|*.JPG|BMP(*.BMP)|*.BMP";
            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                path = Abrir.FileName;
                pictureBox1.Image = Image.FromFile(Abrir.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Copy(path, "images/image.jpg", true);
        }
    }
}
