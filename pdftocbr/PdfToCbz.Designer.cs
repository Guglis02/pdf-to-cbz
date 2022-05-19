
namespace pdftocbr
{
    partial class PdfToCbz
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
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnSelectPdf = new System.Windows.Forms.Button();
            this.openPdfDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblFileName = new System.Windows.Forms.Label();
            this.sliderDpi = new System.Windows.Forms.TrackBar();
            this.lblDpi = new System.Windows.Forms.Label();
            this.barConvert = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.sliderDpi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 92);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(576, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Converter\r\n Arquivo";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnSelectPdf
            // 
            this.btnSelectPdf.Location = new System.Drawing.Point(12, 12);
            this.btnSelectPdf.Name = "btnSelectPdf";
            this.btnSelectPdf.Size = new System.Drawing.Size(119, 23);
            this.btnSelectPdf.TabIndex = 1;
            this.btnSelectPdf.Text = "Selecionar Arquivo";
            this.btnSelectPdf.UseVisualStyleBackColor = true;
            this.btnSelectPdf.Click += new System.EventHandler(this.btnSelectPdf_Click);
            // 
            // openPdfDialog
            // 
            this.openPdfDialog.Filter = "Pdf Files|*.pdf";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(137, 17);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(109, 13);
            this.lblFileName.TabIndex = 2;
            this.lblFileName.Text = "Selecione um arquivo";
            // 
            // sliderDpi
            // 
            this.sliderDpi.BackColor = System.Drawing.SystemColors.Control;
            this.sliderDpi.LargeChange = 1;
            this.sliderDpi.Location = new System.Drawing.Point(12, 41);
            this.sliderDpi.Minimum = 1;
            this.sliderDpi.Name = "sliderDpi";
            this.sliderDpi.Size = new System.Drawing.Size(234, 45);
            this.sliderDpi.TabIndex = 3;
            this.sliderDpi.Value = 5;
            this.sliderDpi.Scroll += new System.EventHandler(this.sliderDpi_Scroll);
            this.sliderDpi.ValueChanged += new System.EventHandler(this.sliderDpi_ValueChanged);
            // 
            // lblDpi
            // 
            this.lblDpi.AutoSize = true;
            this.lblDpi.Location = new System.Drawing.Point(253, 50);
            this.lblDpi.Name = "lblDpi";
            this.lblDpi.Size = new System.Drawing.Size(0, 13);
            this.lblDpi.TabIndex = 4;
            // 
            // barConvert
            // 
            this.barConvert.Location = new System.Drawing.Point(12, 121);
            this.barConvert.Name = "barConvert";
            this.barConvert.Size = new System.Drawing.Size(576, 23);
            this.barConvert.TabIndex = 5;
            // 
            // PdfToCbz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 147);
            this.Controls.Add(this.barConvert);
            this.Controls.Add(this.lblDpi);
            this.Controls.Add(this.sliderDpi);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnSelectPdf);
            this.Controls.Add(this.btnConvert);
            this.Name = "PdfToCbz";
            this.Text = "PdfToCbz";
            this.Load += new System.EventHandler(this.PdfToCbr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sliderDpi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnSelectPdf;
        private System.Windows.Forms.OpenFileDialog openPdfDialog;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TrackBar sliderDpi;
        private System.Windows.Forms.Label lblDpi;
        private System.Windows.Forms.ProgressBar barConvert;
    }
}

