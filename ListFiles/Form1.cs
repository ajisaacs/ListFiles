using System;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;
using System.IO;
using System.Collections.Generic;

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

            var list = new List<string>();

            if (checkBox1.Checked)
                list.AddRange(GetFileList(dir));

            if (checkBox2.Checked)
                list.AddRange(GetDirectoryList(dir));

            list.Sort();

            foreach (var path in list)
                filesBox.AppendText(path + Environment.NewLine);
        }

        private List<string> GetFileList(string searchPath)
        {
            var list = new List<string>();
            var files = Directory.GetFiles(searchPath, SearchPattern);
            var showExt = showFileExtensionsBox.Checked;
            var showPath = showFullPathsBox.Checked;

            foreach (var file in files)
            {
                var ext = Path.GetExtension(file);
                var name = Path.GetFileNameWithoutExtension(file);

                var path = showPath ? Path.Combine(searchPath, name) : name;

                if (showExt)
                    path += ext;

                list.Add(path);
            }

            return list;
        }

        private List<string> GetDirectoryList(string searchPath)
        {
            var list = new List<string>();
            var showPath = showFullPathsBox.Checked;

            if (showPath)
            {
                list.AddRange(Directory.GetDirectories(searchPath));
            }
            else
            {
                foreach (var dir in Directory.GetDirectories(searchPath))
                {
                    var name = Path.GetFileNameWithoutExtension(dir);
                    list.Add(name);
                }
            }

            return list;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UpdateList();
        }
    }
}
