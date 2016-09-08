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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public FileStream Fs;
        string _mergeFolder;
        public Form1()
        {
            InitializeComponent();
        }
        List<string> Packets = new List<string>();
        //Merge file is stored in drive
        string _saveFileFolder = @"c:\";
        readonly int _nNoofFiles = 20;
        //Code Under Brows button:                  
        private void brows_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                txtBrowsFile.Text = openFileDialog1.FileName;
                Fs = new FileStream(txtBrowsFile.Text, FileMode.Open, FileAccess.Read);
                int fileLength = (int)Fs.Length / 1024;
                string name = Path.GetFileName(txtBrowsFile.Text);
            }
            catch (Exception ex)
            {
                lblSendingResult.Text = "EXCEPTION:" + ex;
            }
        }
        //Code Under Split button:
        private void btnSplit_Click(object sender, EventArgs e)
        {
            SplitFile(txtBrowsFile.Text, Convert.ToInt32(_nNoofFiles));
            for (int i = 0; i < _nNoofFiles; i++)
            {
                listBox1.Items.Add(Packets[i]);
            }
        }
        public bool SplitFile(string sourceFile, int nNoofFiles)
        {
            try
            {
                FileStream fs = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
                int sizeofEachFile = (int)Math.Ceiling((double)fs.Length / nNoofFiles);
                for (int i = 0; i < nNoofFiles; i++)
                {
                    string baseFileName = Path.GetFileNameWithoutExtension(sourceFile);
                    string extension = Path.GetExtension(sourceFile);
                    FileStream outputFile = new FileStream(Path.GetDirectoryName(sourceFile) + "\\" + baseFileName + "." +
                        i.ToString().PadLeft(5, Convert.ToChar("0")) + extension + ".tmp", FileMode.Create, FileAccess.Write);
                    _mergeFolder = Path.GetDirectoryName(sourceFile);
                    int bytesRead = 0;
                    byte[] buffer = new byte[sizeofEachFile];
                    if ((bytesRead = fs.Read(buffer, 0, sizeofEachFile)) > 0)
                    {
                        outputFile.Write(buffer, 0, bytesRead);
                        //outp.Write(buffer, 0, BytesRead);
                        string packet = baseFileName + "." + i.ToString().PadLeft(3, Convert.ToChar("0")) + extension;
                        Packets.Add(packet);
                    }
                    outputFile.Close();
                }
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

            return false;
        }
        //Code Under Merge button:
        //Files have been merged and saved at location C:\\"
        private void btnMergeFile_Click(object sender, EventArgs e)
        {
            if (_mergeFolder == null)
            {
                _mergeFolder = Path.GetDirectoryName(txtBrowsFile.Text);
            }
            MergeFile(_mergeFolder);
        }
        public bool MergeFile(string inputfoldername1)
        {
            try
            {
                string[] tmpfiles = Directory.GetFiles(inputfoldername1, "*.tmp");
                FileStream outPutFile = null;
                string prevFileName = "";
                foreach (string tempFile in tmpfiles)
                {
                    string fileName = Path.GetFileNameWithoutExtension(tempFile);
                    if (fileName == null)
                    {
                        throw new Exception("File name is invalid!");
                    }
                    string baseFileName = fileName.Substring(0, fileName.IndexOf(Convert.ToChar(".")));
                    string extension = Path.GetExtension(fileName);
                    if (!prevFileName.Equals(baseFileName))
                    {
                        if (outPutFile != null)
                        {
                            outPutFile.Flush();
                            outPutFile.Close();
                        }
                        outPutFile = new FileStream(inputfoldername1 + "\\" + baseFileName + extension, FileMode.OpenOrCreate, FileAccess.Write);
                    }
                    int bytesRead = 0;
                    byte[] buffer = new byte[1024];
                    FileStream inputTempFile = new FileStream(tempFile, FileMode.OpenOrCreate, FileAccess.Read);
                    while ((bytesRead = inputTempFile.Read(buffer, 0, 1024)) > 0)
                        outPutFile.Write(buffer, 0, bytesRead);
                    inputTempFile.Close();
                    //File.Delete(tempFile);
                    prevFileName = baseFileName;
                }
                outPutFile.Close();
                lblSendingResult.Text = "Files have been merged and saved at location C:\\";
                return true;
            }
            catch(Exception ex)
            {
                // ignored
            }
            return false;
        }
    }
}
