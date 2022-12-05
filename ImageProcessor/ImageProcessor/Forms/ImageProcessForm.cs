using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ImageProcessorLib;

namespace ImageProcessor
{
    public partial class ImageProcessForm : Form
    {
        Bitmap loaded, processed;
        public ImageProcessForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
                    
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(OpenFileDialog.FileName);
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

        private void Subtraction_Click(object sender, EventArgs e)
        {
            SubtractionForm form2 = new SubtractionForm();
            form2.ShowDialog();
        }

        private void Greyscale_Click(object sender, EventArgs e)
        {
            ImageProcessLib.Greyscale(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }
    }
}
