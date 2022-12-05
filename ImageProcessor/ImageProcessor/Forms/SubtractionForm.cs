using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageProcessor
{
    public partial class SubtractionForm : Form
    {
        Bitmap image, background, processed;
        public SubtractionForm()
        {
            InitializeComponent();
        }

        private void OpenImageDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            image = new Bitmap(OpenImageDialog.FileName);
            pictureBox1.Image = image;
        }

        private void OpenBackgroundDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            background = new Bitmap(OpenBackgroundDialog.FileName);
            pictureBox2.Image = background;
        }

        private void LoadBackground_Click(object sender, EventArgs e)
        {
            OpenBackgroundDialog.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            OpenImageDialog.ShowDialog();
        }
    }
}
