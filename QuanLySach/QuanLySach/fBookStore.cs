using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach
{
    public partial class fBookStore : Form
    {
        int dem = 0;
        public fBookStore()
        {
            InitializeComponent();
            
           //txtSearch.Text = listView1.Items[0].Text;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void fBookStore_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn đăng xuất khỏi tài khoản này?",
     "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes) this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dem == 0)
            {
                TabPage tabnew = new TabPage();
                tabnew.Text = "Chi tiết";
                tabControl1.TabPages.Add(tabnew);
                tabControl1.SelectedIndex = 2;
            }
            dem = 1;
        }




    }
}
