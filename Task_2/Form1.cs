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

namespace Task_2
{
    public partial class Form2: Form
    {
        public Form2()
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
                    string name = ofd.SafeFileName;
                    string path = ofd.FileName;
                    string text = File.ReadAllText(path);
                    int character = text.Length;
                    char[] separators = new char[] { ' ', '\n', ':' };
                    string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    int num_word = words.Length;

                    int line = 0;
                    using (StreamReader sr = new StreamReader(path))
                    {
                        while (sr.ReadLine() != null)
                        {
                            line++;
                        }
                    }

                    richTextBox1.Text = text;
                    fileName_box.Text = name;
                    url_box.Text = path;
                    char_box.Text = character.ToString();
                    word_box.Text = num_word.ToString();
                    line_box.Text = line.ToString();
                }

            }
        }
    }
}
