using System;
using System.Drawing;
using System.Windows.Forms;
using ImageProcessorLib;

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
            loadPicture.Image = image;
        }

        private void OpenBackgroundDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            background = new Bitmap(OpenBackgroundDialog.FileName);
            loadBg.Image = background;
        }

        private void LoadBackground_Click(object sender, EventArgs e)
        {
            OpenBackgroundDialog.ShowDialog();
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            ImageProcessLib.Subtract(ref image, ref background, ref processed);
            processedPicture.Image = processed;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog.Filter = "Bitmap Image|*.bmp";
            SaveFileDialog.Title = "Save an Image File";
            SaveFileDialog.ShowDialog();
        }

        private void SaveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            processedPicture.Image.Save(SaveFileDialog.FileName);
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
