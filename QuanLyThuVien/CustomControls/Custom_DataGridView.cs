using System.Drawing;
using System.Windows.Forms;

namespace QuanlyThuVien.CustomControls
{
    public class Custom_DataGridView : DataGridView
    {
        public Custom_DataGridView()
        {
            this.BackgroundColor = Color.White;
            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridColor = Color.FromArgb(230, 230, 230);

            this.EnableHeadersVisualStyles = false;
            this.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(243, 244, 246);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(51, 51, 51);
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            this.ColumnHeadersHeight = 45;
            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            this.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            this.DefaultCellStyle.ForeColor = Color.FromArgb(51, 51, 51);
            this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(232, 245, 253);
            this.DefaultCellStyle.SelectionForeColor = Color.FromArgb(51, 51, 51);
            this.RowTemplate.Height = 40;

            this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);

            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.MultiSelect = false;
            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
        }
    }
}