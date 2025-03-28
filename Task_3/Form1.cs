using System;
using System.IO;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void read_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select File";
            ofd.Filter = "Text Files|*.txt";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                string[] lines = File.ReadAllLines(path);
                richTextBox1.Clear();

                foreach (string line in lines)
                {
                    richTextBox1.AppendText(line + "\n");
                }
            }
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox1.Text.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < lines.Length; i++)
            {
                double result = CalculateExpression(lines[i]);
                richTextBox2.AppendText(lines[i] + " = " + result + "\n");
            }
        }

        private void write_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save File";
            sfd.Filter = "Text Files|*.txt";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, richTextBox2.Text);
            }
        }

        private double CalculateExpression(string expression)
        {
            string[] parts = expression.Split(' ');
            if (parts.Length != 3) return double.NaN;

            if (!double.TryParse(parts[0], out double num1) || !double.TryParse(parts[2], out double num2))
                return double.NaN;

            switch (parts[1])
            {
                case "+": return num1 + num2;
                case "-": return num1 - num2;
                case "*": return num1 * num2;
                case "/": return num2 != 0 ? num1 / num2 : double.NaN;
                default: return double.NaN;
            }
        }
    }
}
