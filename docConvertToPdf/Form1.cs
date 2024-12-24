using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrapeCity.Documents.Word;
using GrapeCity.Documents.Word.Layout;
using System.IO.Compression;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace docConvertToPdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        DialogResult resultOpen, resultOut;
        private void btnSelectOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Word Dosyası | *.doc;*.docx";
            openFileDialog1.Title = "Dönüştürelecek Dosya Seçin";

            resultOpen = openFileDialog1.ShowDialog();
            if (resultOpen == DialogResult.OK)
            {
                txtSelectOpenFile.Text = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSelectOpenFile.Text != "" && txtSelectOutFile.Text != "")
            {
                try
                {
                    string fileName = Path.GetFileNameWithoutExtension(txtSelectOpenFile.Text);
                    bool isIn = false;

                    if (Path.GetExtension(txtSelectOpenFile.Text) != ".docx")
                    {
                        try
                        {
                            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

                            Document doc = wordApp.Documents.Open(txtSelectOpenFile.Text);
                            doc.SaveAs2("c:\\templete\\converted.docx", WdSaveFormat.wdFormatXMLDocument);
                            doc.Close();
                            wordApp.Quit();

                            isIn = true;
                        }
                        catch (Exception ex)
                        {

                        }

                    }

                    var wordFile = new GcWordDocument();
                    if (isIn != true)
                    {
                        wordFile.Load(txtSelectOpenFile.Text);
                    }
                    else
                    {
                        wordFile.Load("c:\\templete\\converted.docx");
                    }

                    using (var layout = new GcWordLayout(wordFile))
                    {
                        PdfOutputSettings outputSettings = new PdfOutputSettings();
                        outputSettings.CompressionLevel = CompressionLevel.Fastest;
                        outputSettings.ConformanceLevel = GrapeCity.Documents.Pdf.PdfAConformanceLevel.PdfA1a;

                        layout.SaveAsPdf(txtSelectOutFile.Text + "\\Converted_" + fileName + ".pdf", null, outputSettings);
                    }

                    try
                    {
                        File.Delete("c:\\templete\\converted.docx");
                    }
                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message);
                    }
                }
                catch(Exception mEx)
                {
                    MessageBox.Show("Hatalı Giriş");
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSelectOutFile.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void btnSelectOutFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            resultOut = folderBrowserDialog1.ShowDialog();

            if (resultOut == DialogResult.OK)
            {
                txtSelectOutFile.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
