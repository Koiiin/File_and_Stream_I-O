using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Task_4
{
    public partial class Excel : Form
    {
        private string excelPath = "data.xlsx"; 

        public Excel()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            list.View = View.Details;
            list.FullRowSelect = true;
            list.GridLines = true;

            list.Columns.Add("MSSV", 100);
            list.Columns.Add("Họ tên", 100);
            list.Columns.Add("Số điện thoại", 100);
            list.Columns.Add("Điểm toán", 100);
            list.Columns.Add("Điểm văn", 100);
            list.Columns.Add("DTB", 100);
        }

        private void input_btn_Click(object sender, EventArgs e)
        {
            using (Info infoForm = new Info())
            {
                if (infoForm.ShowDialog() == DialogResult.OK) 
                {
                    MessageBox.Show("Dữ liệu đã được nhập và lưu vào file input.txt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void show_btn_Click(object sender, EventArgs e)
        {
            list.Items.Clear(); 

            string txtPath = "input.txt";
            if (!File.Exists(txtPath))
            {
                MessageBox.Show("Không tìm thấy file dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(txtPath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length < 5) continue;

                ListViewItem item = new ListViewItem(parts[0]); // MSSV
                item.SubItems.Add(parts[1]); // Họ tên
                item.SubItems.Add(parts[2]); // Số điện thoại
                item.SubItems.Add(parts[3]); // Điểm toán
                item.SubItems.Add(parts[4]); // Điểm văn

                if (double.TryParse(parts[3], out double toan) && double.TryParse(parts[4], out double van))
                {
                    double dtb = (toan + van) / 2;
                    item.SubItems.Add(dtb.ToString("0.00")); // DTB
                }
                else
                {
                    item.SubItems.Add("Lỗi dữ liệu");
                }

                list.Items.Add(item);
            }
        }


        private void save_btn_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(excelPath);
            using (ExcelPackage excel = file.Exists ? new ExcelPackage(file) : new ExcelPackage())
            {
                ExcelWorksheet sheet = file.Exists ? excel.Workbook.Worksheets[0] : excel.Workbook.Worksheets.Add("SinhVien");

                if (!file.Exists)
                {
                    sheet.Cells[1, 1].Value = "MSSV";
                    sheet.Cells[1, 2].Value = "Họ Tên";
                    sheet.Cells[1, 3].Value = "SDT";
                    sheet.Cells[1, 4].Value = "Điểm Toán";
                    sheet.Cells[1, 5].Value = "Điểm Văn";
                    sheet.Cells[1, 6].Value = "DTB";
                }

                int row = 2; 
                foreach (ListViewItem item in list.Items)
                {
                    sheet.Cells[row, 1].Value = item.SubItems[0].Text;
                    sheet.Cells[row, 2].Value = item.SubItems[1].Text;
                    sheet.Cells[row, 3].Value = item.SubItems[2].Text;
                    sheet.Cells[row, 4].Value = item.SubItems[3].Text;
                    sheet.Cells[row, 5].Value = item.SubItems[4].Text;
                    sheet.Cells[row, 6].Value = item.SubItems[5].Text;
                    row++;
                }

                excel.SaveAs(file);
                MessageBox.Show("Dữ liệu đã được lưu vào Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
