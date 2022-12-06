namespace ImageProcessor
{
    partial class ImageProcessForm
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
            System.Windows.Forms.TextBox textBox6;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.processedImage = new System.Windows.Forms.PictureBox();
            this.Histogram = new System.Windows.Forms.Button();
            this.Sepia = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Greyscale = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Inversion = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyImage = new System.Windows.Forms.Button();
            textBox6 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox6
            // 
            textBox6.BackColor = System.Drawing.SystemColors.Menu;
            textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox6.Location = new System.Drawing.Point(135, 354);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new System.Drawing.Size(133, 20);
            textBox6.TabIndex = 17;
            textBox6.Text = "Original Image";
            textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // originalImage
            // 
            this.originalImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalImage.Location = new System.Drawing.Point(55, 64);
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(299, 284);
            this.originalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originalImage.TabIndex = 1;
            this.originalImage.TabStop = false;
            // 
            // processedImage
            // 
            this.processedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.processedImage.Location = new System.Drawing.Point(426, 64);
            this.processedImage.Name = "processedImage";
            this.processedImage.Size = new System.Drawing.Size(299, 284);
            this.processedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processedImage.TabIndex = 2;
            this.processedImage.TabStop = false;
            // 
            // Histogram
            // 
            this.Histogram.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Histogram.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Histogram.Location = new System.Drawing.Point(881, 255);
            this.Histogram.Name = "Histogram";
            this.Histogram.Size = new System.Drawing.Size(95, 32);
            this.Histogram.TabIndex = 12;
            this.Histogram.Text = "Histogram";
            this.Histogram.UseVisualStyleBackColor = true;
            this.Histogram.Click += new System.EventHandler(this.Histogram_Click);
            // 
            // Sepia
            // 
            this.Sepia.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sepia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sepia.Location = new System.Drawing.Point(770, 255);
            this.Sepia.Name = "Sepia";
            this.Sepia.Size = new System.Drawing.Size(95, 32);
            this.Sepia.TabIndex = 13;
            this.Sepia.Text = "Sepia";
            this.Sepia.UseVisualStyleBackColor = true;
            this.Sepia.Click += new System.EventHandler(this.Sepia_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtraction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Subtraction.Location = new System.Drawing.Point(814, 305);
            this.Subtraction.MinimumSize = new System.Drawing.Size(95, 32);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(112, 32);
            this.Subtraction.TabIndex = 15;
            this.Subtraction.Text = "Subtraction";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.Subtraction_Click);
            // 
            // Greyscale
            // 
            this.Greyscale.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Greyscale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Greyscale.Location = new System.Drawing.Point(770, 203);
            this.Greyscale.Name = "Greyscale";
            this.Greyscale.Size = new System.Drawing.Size(95, 32);
            this.Greyscale.TabIndex = 16;
            this.Greyscale.Text = "Greyscale";
            this.Greyscale.UseVisualStyleBackColor = true;
            this.Greyscale.Click += new System.EventHandler(this.Greyscale_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(510, 354);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Processed Image";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(758, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(241, 20);
            this.textBox2.TabIndex = 19;
            this.textBox2.Text = "\"A Picture Paints a Million Bytes\"";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Inversion
            // 
            this.Inversion.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inversion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Inversion.Location = new System.Drawing.Point(881, 203);
            this.Inversion.Name = "Inversion";
            this.Inversion.Size = new System.Drawing.Size(95, 32);
            this.Inversion.TabIndex = 22;
            this.Inversion.Text = "Inversion";
            this.Inversion.UseVisualStyleBackColor = true;
            this.Inversion.Click += new System.EventHandler(this.Inversion_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            this.OpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CopyImage
            // 
            this.CopyImage.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CopyImage.Location = new System.Drawing.Point(814, 156);
            this.CopyImage.Name = "CopyImage";
            this.CopyImage.Size = new System.Drawing.Size(112, 32);
            this.CopyImage.TabIndex = 23;
            this.CopyImage.Text = "Copy Image";
            this.CopyImage.UseVisualStyleBackColor = true;
            this.CopyImage.Click += new System.EventHandler(this.CopyImage_Click);
            // 
            // ImageProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 419);
            this.Controls.Add(this.CopyImage);
            this.Controls.Add(this.Inversion);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(textBox6);
            this.Controls.Add(this.Greyscale);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Sepia);
            this.Controls.Add(this.Histogram);
            this.Controls.Add(this.processedImage);
            this.Controls.Add(this.originalImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1044, 466);
            this.Name = "ImageProcessForm";
            this.Text = "Image Processor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.PictureBox processedImage;
        private System.Windows.Forms.Button Histogram;
        private System.Windows.Forms.Button Sepia;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Greyscale;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Inversion;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button CopyImage;
    }
}

