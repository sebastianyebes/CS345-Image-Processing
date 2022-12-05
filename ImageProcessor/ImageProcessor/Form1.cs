using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ImageProcessorLib;

namespace ImageProcessor
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();           
        }

        private void saveFileDialog1_FileOk(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }

        private void Inversion_Click(object sender, EventArgs e)
        {
            ImageProcessLib.Inversion(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }

        private void Sepia_Click(object sender, EventArgs e)
        {
            ImageProcessLib.Sepia(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }

        private void Greyscale_Click(object sender, EventArgs e)
        {
            ImageProcessLib.Greyscale(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }
    }
}
