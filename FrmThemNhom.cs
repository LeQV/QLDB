using AppQLDB.Model;
using AppQLDB.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQLDB
{
    public partial class FrmThemNhom : Form
    {
        public FrmThemNhom()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var n = new Nhom
            {
                TenNhom = txtTenNhom.Text
            };
            NhomViewModel.AddNhom(n);
            
            DialogResult = DialogResult.OK;
        }

        private void FrmThemNhom_Load(object sender, EventArgs e)
        {
        
        }
    }
}
