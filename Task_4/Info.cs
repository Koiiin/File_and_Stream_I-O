using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Info : Form
    {
        public List<string> StudentList { get; private set; } = new List<string>();

        public Info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            string mssv = mssv_box.Text.Trim();
            string hoTen = name_box.Text.Trim();
            string sdt = phone_box.Text.Trim();
            string diemToanStr = math_box.Text.Trim();
            string diemVanStr = van_box.Text.Trim();

            if (string.IsNullOrWhiteSpace(mssv) || string.IsNullOrWhiteSpace(hoTen) ||
                string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(diemToanStr) ||
                string.IsNullOrWhiteSpace(diemVanStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(diemToanStr, out double diemToan) || !double.TryParse(diemVanStr, out double diemVan))
            {
                MessageBox.Show("Điểm phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (diemToan < 0 || diemToan > 10 || diemVan < 0 || diemVan > 10)
            {
                MessageBox.Show("Điểm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string data = $"{mssv};{hoTen};{sdt};{diemToan};{diemVan}";
            StudentList.Add(data); 

            string txtPath = "input.txt";
            File.AppendAllText(txtPath, data + Environment.NewLine);

            MessageBox.Show("Dữ liệu đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            mssv_box.Clear();
            name_box.Clear();
            phone_box.Clear();
            math_box.Clear();
            van_box.Clear();
        }
    }
}
