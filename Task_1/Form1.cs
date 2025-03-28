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

namespace Task_1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void read_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            {
                ofd.Title = "Select text file:";
                ofd.Filter = "Text files|*.txt";
                ofd.Multiselect = false;
                ofd.FilterIndex = 1;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path = ofd.FileName;

                    using (StreamReader sr = new StreamReader(path))
                    {
                        string content = sr.ReadToEnd();
                        richTextBox1.Text = content;
                    }

                }
            }
        }

        private void write_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            {
                sfd.Title = "Save text file:";
                sfd.Filter = "Text files|*.txt";
                sfd.FilterIndex = 1;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;

                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.Write(richTextBox1.Text);
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
        }
    }
}
