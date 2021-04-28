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

namespace CatalogFiles
{
	public partial class Form1 : Form
	{
		private void OnChanged(object source, FileSystemEventArgs e)
		{
			
			RevisionHistory.Invoke((MethodInvoker)delegate
			{
				RevisionHistory.AppendText("File: " + e.Name + " " + e.ChangeType + "\r\n");
			});
		}

		private void OnRenamed(object source, RenamedEventArgs e)
		{
			RevisionHistory.Invoke((MethodInvoker)delegate
			{
				RevisionHistory.AppendText("File: " + e.Name + " renamed to " + e.Name + "\r\n");
			});

		}

		public Form1()
		{
			InitializeComponent();
		}

		private void SelectCatalogButton_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog openFolderDialog1 = new FolderBrowserDialog();
			if (openFolderDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Location.Text = openFolderDialog1.SelectedPath;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
		}

		private void MonitoringModButton_Click(object sender, EventArgs e)
		{
			
			if (Location.Text != "")
			{
				FileSystemWatcher watcher = new FileSystemWatcher();
				watcher.Path = Location.Text;
				watcher.IncludeSubdirectories = true;


				watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
				   | NotifyFilters.FileName | NotifyFilters.DirectoryName;

				watcher.Changed += new FileSystemEventHandler(OnChanged);
				watcher.Created += new FileSystemEventHandler(OnChanged);
				watcher.Deleted += new FileSystemEventHandler(OnChanged);
				watcher.Renamed += new RenamedEventHandler(OnRenamed);
				watcher.EnableRaisingEvents = true;
			}
			



		}

		private void ClearRevisionHistoryButton_Click(object sender, EventArgs e)
		{
			RevisionHistory.Text = "";
		}
	}
}
