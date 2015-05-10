using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace FsMock
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNewMock_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select folder to mock";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    using (var ofd = new OpenFileDialog())
                    {
                        ofd.CheckFileExists = false;
                        ofd.DefaultExt = ".zip";
                        ofd.ShowReadOnly = false;
                        ofd.Title = "Save mock of the directory as";
                        if (ofd.ShowDialog() == DialogResult.OK)
                        {
                            Mock(fbd.SelectedPath, ofd.FileName);
                        }
                    }
                }
            }
        }

        private void Mock(string directoryToMock, string mockFile)
        {
            using (var memoryStream = new MemoryStream())
            {
                var fileSystemEntries = Directory.GetFileSystemEntries(directoryToMock, "*.*", SearchOption.AllDirectories);
                using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, leaveOpen: true))
                {
                    //first, create a root folder
                    var rootDirectoryName = Path.GetFileName(directoryToMock);
                    archive.CreateEntry(rootDirectoryName + "/");
                    var charsToChopOff = directoryToMock.Length - rootDirectoryName.Length;
                    foreach (var fsEntry in fileSystemEntries)
                    {
                        var isDirectory = Directory.Exists(fsEntry);
                        var relativeName = fsEntry.Substring(charsToChopOff).Replace(Path.DirectorySeparatorChar, '/');
                        var entryName = isDirectory ? relativeName + "/" : relativeName;
                        archive.CreateEntry(entryName); 
                    }
                }
                File.WriteAllBytes(mockFile, memoryStream.ToArray());
            }
            MessageBox.Show("Done");
        }
    }
}
