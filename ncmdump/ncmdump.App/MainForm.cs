using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ncmdump.App {
    public partial class MainForm : Form {

        string mNcmDumpPath = "";
        FileInfo[] ncms = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void selectFolderToolStripMenuItem_Click( Object sender, EventArgs e )
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            if( !string.IsNullOrEmpty( folderBrowserDialog.SelectedPath ) ) {
                RefreshNcms(folderBrowserDialog.SelectedPath);
            }
            
        }

        private void MainForm_Load( Object sender, EventArgs e )
        {
            mNcmDumpPath = Path.Combine( Application.StartupPath, "main.exe" );
            if( !File.Exists( mNcmDumpPath ) ) {
                MessageBox.Show("未找到主程序，请下载并确保主程序在根目录", "Error" );
                System.Diagnostics.Process.Start("https://github.com/MeowPerth/ncmdump");
            }
            tb_path.Text = Environment.GetFolderPath( Environment.SpecialFolder.MyMusic );
            findAllNcmsInFolderRecursion();
        }
        private void RefreshNcms( string path )
        {
            if( !Directory.Exists( path ) ) {
                MessageBox.Show(string.Format("[{0}] 不存在", path),"Error");
                return;
            }
            tb_path.Text = path;
            DirectoryInfo directoryInfo = new DirectoryInfo( path );
            var ncmFiles = directoryInfo.GetFiles("*.ncm");
            if( ncmFiles.Length == 0 ) {
                MessageBox.Show( "当前文件夹下未找到 NCM 文件" );
                return;
            }
            lb_ncms.DataSource = ncmFiles;
            label_text.Text = string.Format( "({0}) 当前地址找到 NCM [{1}]", ncmFiles.Length, path );
        }

        private void ConversionNcms()
        {
            var ncms = lb_ncms.DataSource as FileInfo[];
            if( ncms == null ) {
                MessageBox.Show( string.Format( "不存在 NCM 文件" ), "Error" );
                return;
            }
            if( ncms.Length == 0 ) {
                MessageBox.Show( string.Format("不存在 NCM 文件"), "Error" );
                return;
            }

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Enabled = false;
            int i = 0;
            foreach( var ncm in ncms ) {
                ++i;
                Text = string.Format( "{1}/{2} 处理中 [{0}] ", ncm.Name, i, ncms.Length );
                string cmd = string.Format( "/C {0} \"{1}\"", mNcmDumpPath, ncm.FullName );

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "CMD.exe";
                startInfo.Arguments = cmd;
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                Process process = new Process();
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
                if( cb_ifDoDelete.Checked ) {
                    File.Delete( ncm.FullName );
                }
            }
            this.Enabled = true;
            Text = "结束";
        }

        private void bt_refresh_Click( Object sender, EventArgs e )
        {
            RefreshNcms( tb_path.Text );
        }



        private void bt_conversion_Click_1( Object sender, EventArgs e )
        {
            RefreshNcms( tb_path.Text );
            ConversionNcms();
        }

        private void findAllNcmsInTheChildFoldersToolStripMenuItem_Click( Object sender, EventArgs e )
        {
            findAllNcmsInFolderRecursion();
        }

        private void findAllNcmsInFolderRecursion()
        {
            var files = GetAllNcmFiles( new DirectoryInfo( tb_path.Text ) );
            lb_ncms.DataSource = files;
            label_text.Text = string.Format("({0}) 当前地址找到 NCM [{1}] [包含子文件夹]", files.Length, tb_path.Text );
        }

        public static FileInfo[] GetAllNcmFiles( DirectoryInfo dir )
        {
            List<FileInfo> fileInfos = new List<FileInfo>(dir.GetFiles("*.ncm"));
            DirectoryInfo[] allDir= dir.GetDirectories();
            foreach( DirectoryInfo d in allDir ) {
                fileInfos.AddRange( GetAllNcmFiles( d ) );
            }
            return fileInfos.ToArray();
        }

        private void selectDefaultMusicFolderToolStripMenuItem_Click( Object sender, EventArgs e )
        {
            tb_path.Text = Environment.GetFolderPath( Environment.SpecialFolder.MyMusic );
        }

        private void lb_ncms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
