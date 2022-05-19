using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace CompressionSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isFolder = true;

        private void CompressDirectory(string DirectoryPath, string OutputFilePath, int CompressionLevel = 9)
        {
            try
            {
                string[] filenames = Directory.GetFiles(DirectoryPath);
                using (ZipOutputStream OutputStream = new ZipOutputStream(File.Create(OutputFilePath)))
                {
                    OutputStream.SetLevel(CompressionLevel);
                    byte[] buffer = new byte[4096];
                    foreach (string file in filenames)
                    {
                        ZipEntry entry = new ZipEntry(Path.GetFileName(file));
                        entry.DateTime = DateTime.Now;
                        OutputStream.PutNextEntry(entry);

                        using (FileStream fs = File.OpenRead(file))
                        {
                            int sourceBytes;

                            do
                            {
                                sourceBytes = fs.Read(buffer, 0, buffer.Length);
                                OutputStream.Write(buffer, 0, sourceBytes);
                            } while (sourceBytes > 0);
                        }
                    }

                    OutputStream.Finish();
                    OutputStream.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception during processing {0}", ex);
            }
        }

        private static void CompressFile(string inputPath, string outputPath)
        {
            FileInfo outFileInfo = new FileInfo(outputPath);
            FileInfo inFileInfo = new FileInfo(inputPath);

            // Create the output directory if it does not exist
            if (!Directory.Exists(outFileInfo.Directory.FullName))
            {
                Directory.CreateDirectory(outFileInfo.Directory.FullName);
            }

            // Compress
            using (FileStream fsOut = File.Create(outputPath))
            {
                using (ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipStream = new ICSharpCode.SharpZipLib.Zip.ZipOutputStream(fsOut))
                {
                    zipStream.SetLevel(3);

                    ICSharpCode.SharpZipLib.Zip.ZipEntry newEntry = new ICSharpCode.SharpZipLib.Zip.ZipEntry(inFileInfo.Name);
                    newEntry.DateTime = DateTime.UtcNow;
                    zipStream.PutNextEntry(newEntry);

                    byte[] buffer = new byte[4096];
                    using (FileStream streamReader = File.OpenRead(inputPath))
                    {
                        ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(streamReader, zipStream, buffer);
                    }

                    zipStream.CloseEntry();
                    zipStream.IsStreamOwner = true;
                    zipStream.Close();
                }
            }
        }

        private static void CompressFileWithPassword(string inputPath, string outputPath, string Password = null)
        {
            FileInfo outFileInfo = new FileInfo(outputPath);
            FileInfo inFileInfo = new FileInfo(inputPath);

            // Create the output directory if it does not exist
            if (!Directory.Exists(outFileInfo.Directory.FullName))
            {
                Directory.CreateDirectory(outFileInfo.Directory.FullName);
            }

            // Compress
            using (FileStream fsOut = File.Create(outputPath))
            {
                using (ICSharpCode.SharpZipLib.Zip.ZipOutputStream zipStream = new ICSharpCode.SharpZipLib.Zip.ZipOutputStream(fsOut))
                {
                    zipStream.SetLevel(3);
                    zipStream.Password = Password;

                    ICSharpCode.SharpZipLib.Zip.ZipEntry newEntry = new ICSharpCode.SharpZipLib.Zip.ZipEntry(inFileInfo.Name);
                    newEntry.DateTime = DateTime.UtcNow;
                    zipStream.PutNextEntry(newEntry);

                    byte[] buffer = new byte[4096];
                    using (FileStream streamReader = File.OpenRead(inputPath))
                    {
                        ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(streamReader, zipStream, buffer);
                    }

                    zipStream.CloseEntry();
                    zipStream.IsStreamOwner = true;
                    zipStream.Close();
                }
            }
        }

        private void CompressDirectoryWithPassword(string DirectoryPath, string OutputFilePath, string Password = null, int CompressionLevel = 9)
        {
            try
            {
                string[] filenames = Directory.GetFiles(DirectoryPath);
                using (ZipOutputStream OutputStream = new ZipOutputStream(File.Create(OutputFilePath)))
                {
                    OutputStream.Password = Password;
                    OutputStream.SetLevel(CompressionLevel);

                    byte[] buffer = new byte[4096];

                    foreach (string file in filenames)
                    {
                        ZipEntry entry = new ZipEntry(Path.GetFileName(file));
                        entry.DateTime = DateTime.Now;
                        OutputStream.PutNextEntry(entry);

                        using (FileStream fs = File.OpenRead(file))
                        {
                            int sourceBytes;
                            do
                            {
                                sourceBytes = fs.Read(buffer, 0, buffer.Length);
                                OutputStream.Write(buffer, 0, sourceBytes);
                            } while (sourceBytes > 0);
                        }
                    }

                    OutputStream.Finish();
                    OutputStream.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception during processing {0}", ex);
            }
        }

        public void ExtractZipContent(string FileZipPath, string password, string OutputFolder)
        {
            ZipFile file = null;
            try
            {
                FileStream fs = File.OpenRead(FileZipPath);
                file = new ZipFile(fs);

                if (!String.IsNullOrEmpty(password))
                {
                    file.Password = password;
                }

                foreach (ZipEntry zipEntry in file)
                {
                    if (!zipEntry.IsFile)
                    {
                        continue;
                    }

                    String entryFileName = zipEntry.Name;
                    byte[] buffer = new byte[4096];
                    Stream zipStream = file.GetInputStream(zipEntry);
                    String fullZipToPath = Path.Combine(OutputFolder, entryFileName);
                    string directoryName = Path.GetDirectoryName(fullZipToPath);

                    if (directoryName.Length > 0)
                    {
                        Directory.CreateDirectory(directoryName);
                    }

                    using (FileStream streamWriter = File.Create(fullZipToPath))
                    {
                        StreamUtils.Copy(zipStream, streamWriter, buffer);
                    }
                }
            }
            finally
            {
                if (file != null)
                {
                    file.IsStreamOwner = true;
                    file.Close();
                }
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            saveFileDialog1.Filter = "Zip file (.zip)|*.zip";
            if (result == DialogResult.OK)
            {
                if (isFolder)
                {
                    if (chkPass.Checked)
                        if(txtPassword.Text == txtPassword2.Text)
                        {
                            CompressDirectoryWithPassword(txtCompress.Text, saveFileDialog1.FileName, txtPassword.Text, 9);
                            MessageBox.Show("Đã nén thành công!");
                        }
                        else
                            MessageBox.Show("Hai lần nhập mật khẩu không trùng nhau");
                    else
                    {
                        CompressDirectory(txtCompress.Text, saveFileDialog1.FileName, 9);
                        MessageBox.Show("Đã nén thành công!");
                    }

                }
                else
                {
                    if (chkPass.Checked)
                        if (txtPassword.Text == txtPassword2.Text)
                        {
                            CompressFileWithPassword(txtCompress.Text, saveFileDialog1.FileName, txtPassword.Text);
                            MessageBox.Show("Đã nén thành công!");
                        }
                        else
                            MessageBox.Show("Hai lần nhập mật khẩu không trùng nhau");
                    else
                    {
                        CompressFile(txtCompress.Text, saveFileDialog1.FileName);
                        MessageBox.Show("Đã nén thành công!");
                    }
                }
                
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] files = openFileDialog1.FileNames;
                txtCompress.Text = string.Join(",", files);
                isFolder = false;
            }
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtCompress.Text = folderBrowserDialog1.SelectedPath;
                isFolder = true;
            }
        }

        private void btnUnCompress_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Zip file (.zip)|*.zip";
            if (result == DialogResult.OK)
            {
                txtUnCompress.Text = openFileDialog1.FileName;
                DialogResult result2 = folderBrowserDialog1.ShowDialog();
                if (result2 == DialogResult.OK)
                {
                    if (txtPassword.Text == txtPassword2.Text)
                    {
                        ExtractZipContent(openFileDialog1.FileName, "", folderBrowserDialog1.SelectedPath);
                        MessageBox.Show("Đã giải nén thành công!");
                    }
                    else
                        MessageBox.Show("Hai lần nhập mật khẩu không trùng nhau");
                }
            }
            
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPass.Checked)
            {
                txtPassword.ReadOnly = false;
                txtPassword2.ReadOnly = false;
            }

            else
            {
                txtPassword.ReadOnly = true;
                txtPassword2.ReadOnly = true;
            }    
        }

    }
}