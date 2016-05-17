using System;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using System.IO;

namespace ListFiles
{
    public partial class Form1 : Form
    {
        private Timer updateTimer;

        public Form1()
        {
            InitializeComponent();

            updateTimer = new Timer();
            updateTimer.AutoReset = false;
            updateTimer.Interval = 200;
            updateTimer.SynchronizingObject = this;
            updateTimer.Elapsed += new ElapsedEventHandler(updateTimer_Elapsed);
        }

        private string SearchPattern
        {
            get { return string.IsNullOrEmpty(searchPatternBox.Text) ? "*" :  searchPatternBox.Text; }
        }

        private void updateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            UpdateList();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                directoryBox.Text = dlg.SelectedPath;
            }
        }

        private void directoryBox_TextChanged(object sender, EventArgs e)
        {
            updateTimer.Stop();
            updateTimer.Start();
        }

        private void UpdateList()
        {
            filesBox.Clear();

            var dir = directoryBox.Text;

            if (!Directory.Exists(dir))
                return;
            Directory.GetFi
            var files = Directory.GetFiles(dir, SearchPattern);
            var showExt = showFileExtensionsBox.Checked;
            var showPath = showFullPathsBox.Checked;

            foreach (var file in files)
            {
                var ext = Path.GetExtension(file);
                var name = Path.GetFileNameWithoutExtension(file);

                var path = showPath ? Path.Combine(dir, name) : name;

                if (showExt)
                    path += ext;

                filesBox.AppendText(path + Environment.NewLine);
            }
        }

        private void showFullPathsBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void showFileExtensionsBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void searchPatternBox_TextChanged(object sender, EventArgs e)
        {
            updateTimer.Stop();
            updateTimer.Start();
        }
    }
}
