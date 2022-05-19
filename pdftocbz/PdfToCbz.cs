using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfiumViewer;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;

namespace pdftocbz
{
    public partial class PdfToCbz : Form
    {
		public string file;
		public int dpi = 0;

        public PdfToCbz()
        {
            InitializeComponent();
			this.dpi = sliderDpi.Value * 50;
			lblDpi.Text = $"DPI = {dpi}";
		}

        private void btnConvert_Click(object sender, EventArgs e)
        {
			string projectDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
			string fileName = Path.GetFileNameWithoutExtension(file);
			string filePath = Path.GetDirectoryName(file);
			string outputDir = projectDir + $@"\Temp\{fileName}";
			string cbzDir = $@"{filePath}\{fileName}";

			barConvert.Value = 0;

			if (!Directory.Exists(outputDir))
			{
				Directory.CreateDirectory(outputDir);
			}

			try
			{
				using (var document = PdfDocument.Load(file))
				{
					var pageCount = document.PageCount;

					for (int i = 0; i < pageCount; i++)
					{
						using (var image = document.Render(i, dpi, dpi, PdfRenderFlags.CorrectFromDpi))
						{
							var encoder = ImageCodecInfo.GetImageEncoders()
								.First(c => c.FormatID == ImageFormat.Jpeg.Guid);
							var encParams = new EncoderParameters(1);
							encParams.Param[0] = new EncoderParameter(
								System.Drawing.Imaging.Encoder.Quality, 100L);

							image.Save($@"{outputDir}\" + fileName + ' ' + i + '_' + pageCount + ".jpg", encoder, encParams);
							barConvert.Value = (i + 1) * 100 / pageCount;
						}
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			if (File.Exists(cbzDir + ".cbz"))
            {
				int i = 1;
                while (File.Exists(cbzDir + $" ({i}).cbz")) 
				{
					i++;
				}
				cbzDir = cbzDir + $" ({i}).cbz";
            } else
            {
				cbzDir = cbzDir + ".cbz";
            }

			ZipFile.CreateFromDirectory(outputDir, cbzDir);

			if (Directory.Exists(outputDir))
			{
				DirectoryInfo di = new DirectoryInfo($@"{outputDir}\");
				foreach (FileInfo file in di.GetFiles())
                {
					file.Delete();
                }
				Directory.Delete(outputDir);
			}

			barConvert.Value = 100;
		}

		private void btnSelectPdf_Click(object sender, EventArgs e)
        {
			if (openPdfDialog.ShowDialog() == DialogResult.OK)
			{
				this.file = openPdfDialog.FileName;
				lblFileName.Text = Path.GetFileName(file);
				barConvert.Value = 0;
			}
        }

		private void sliderDpi_ValueChanged(object sender, EventArgs e)
        {
			dpi = sliderDpi.Value * 50;
			lblDpi.Text = $"DPI = {dpi}";
        }

		private void PdfToCbr_Load(object sender, EventArgs e)
        {

        }

        private void sliderDpi_Scroll(object sender, EventArgs e)
        {

        }
    }
}
