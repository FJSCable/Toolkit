using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using PdfiumViewer;


namespace FJS_TOOLKIT
{
    public partial class FJS_PDF_2_JPG : Form
    {
        private string exeDirectory;
        public FJS_PDF_2_JPG()
        {
            InitializeComponent();
            exeDirectory = Path.GetDirectoryName(Application.ExecutablePath);

            AllowDrop = true;
            DragDrop += FJS_PDF_2_JPG_DragDrop;
            DragEnter += FJS_PDF_2_JPG_DragEnter;
        }

        

        private void FJS_PDF_2_JPG_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void FJS_PDF_2_JPG_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                if (Path.GetExtension(file).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
                {
                    ConvertPdfToPng(file);
                }
            }
        }

        private void ConvertPdfToPng(string pdfFilePath)
        {
            try
            {
                using (PdfDocument pdfDocument = PdfDocument.Load(pdfFilePath))
                {
                    if (pdfDocument.PageCount > 0)
                    {
                        string pdfFileName = Path.GetFileNameWithoutExtension(pdfFilePath);
                        string outputPngPath = Path.Combine(exeDirectory, pdfFileName + ".png");

                        using (Image pdfImage = pdfDocument.Render(0, 300, 300, true))
                        {
                            using (Bitmap bitmap = new Bitmap(pdfImage))
                            {
                                bitmap.Save(outputPngPath, System.Drawing.Imaging.ImageFormat.Png);
                                MessageBox.Show("Conversion Complete: " + pdfFileName + ".png", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MessageBox.Show("Output Path: " + outputPngPath, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No pages in the PDF: " + pdfFilePath, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error converting PDF to PNG: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            
        }

        private void FJS_PDF_2_JPG_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void FJS_PDF_2_JPG_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
