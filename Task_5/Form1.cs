using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task_5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            ListFile.View = View.Details;
            ListFile.FullRowSelect = true;
            ListFile.GridLines = true;

            ListFile.Columns.Add("Tên file", 250);
            ListFile.Columns.Add("Kích thước", 100);
            ListFile.Columns.Add("Loại", 100);
            ListFile.Columns.Add("Ngày tạo", 150);
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    path_box.Text = fbd.SelectedPath;
                    LoadFilesAndDirectories(fbd.SelectedPath);
                }
            }
        }

        private void LoadFilesAndDirectories(string path)
        {
            ListFile.Items.Clear();
            try
            {
                DirectoryInfo di = new DirectoryInfo(path);

                foreach (var dir in di.GetDirectories())
                {
                    ListViewItem item = new ListViewItem(dir.Name);
                    item.SubItems.Add("");
                    item.SubItems.Add("Thư mục");
                    item.SubItems.Add(dir.CreationTime.ToString());
                    item.Tag = dir.FullName;
                    ListFile.Items.Add(item);
                }

                foreach (var file in di.GetFiles())
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.Length.ToString() + " bytes");
                    item.SubItems.Add(file.Extension);
                    item.SubItems.Add(file.CreationTime.ToString());
                    item.Tag = file.FullName;
                    ListFile.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            string currentPath = path_box.Text;
            DirectoryInfo di = new DirectoryInfo(currentPath);
            if (di.Parent != null)
            {
                path_box.Text = di.Parent.FullName;
                LoadFilesAndDirectories(di.Parent.FullName);
            }
        }
    }
}
