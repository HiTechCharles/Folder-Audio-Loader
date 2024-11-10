using System;
using System.IO;
using System.Windows.Forms;

namespace Workout_Videos_for_Tiffany
{
    public partial class TWV : Form
    {
        public TWV()
        {
            InitializeComponent();
        }

        private void TWV_Load(object sender, EventArgs e)
        {
            String BaseName;  //holds file name without extension
            string rootdir = @"M:\music\Playlists\Tiffany";  //directory containing files to look for
            //get string array of files in RootDir *.m3u files only
            string[] FileList = Directory.GetFileSystemEntries(rootdir, "*.m3u", SearchOption.TopDirectoryOnly);

            //for each file name in FileList,
            for (int i = 0; i < FileList.Length; i++)
            {
                string FilePath = FileList[i];  //store path
                //chop off file extension for list
                BaseName = Path.GetFileNameWithoutExtension(FilePath);
                //Add BaseName to Listbox
                FileListLB.Items.Add(BaseName);
            }
        }

        private void OKBTN_Click(object sender, EventArgs e)
        {
            //where to look for files
            string rootdir = @"M:\music\Playlists\Tiffany";
            //string array of files in RootDir, .m3u only
            string[] FileList = Directory.GetFileSystemEntries(rootdir, "*.m3u", SearchOption.TopDirectoryOnly);
            //get path for listbox selected index
            String AudioPath = FileList[FileListLB.SelectedIndex];

            //start VLC video player full screen
            //MUST put quotes around file name in arguments

            using (System.Diagnostics.Process pProcess = new System.Diagnostics.Process())
            {
                pProcess.StartInfo.FileName = @"C:\Program Files\VideoLAN\VLC\vlc.exe";  //filename
                pProcess.StartInfo.Arguments = "--random \"" + AudioPath + "\""; //argument
                pProcess.StartInfo.UseShellExecute = false;
                pProcess.StartInfo.RedirectStandardOutput = true;
                pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized;
                pProcess.StartInfo.CreateNoWindow = true; //not display a window
                this.Hide();
                pProcess.Start();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void RandomBTN_Click(object sender, EventArgs e)
        {
            //pick random number between 0 and Listbox items
            Random rnd = new Random();
            FileListLB.SelectedIndex = rnd.Next(0, FileListLB.Items.Count);
        }

        private void FileListLB_DoubleClick(object sender, EventArgs e)
        {
            OKBTN_Click(null, null);    
        }
    }
}