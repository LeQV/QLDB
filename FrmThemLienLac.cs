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
    public partial class FrmThemLienLac : Form
    {
        public FrmThemLienLac()
        {
            InitializeComponent();
            NapDsNhom();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            var ll = new LienLac
            {
                IdLienLac = Int32.Parse(txtIdLienLac.Text),
                TenGoi = txtTenGoi.Text,
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text,
                SDT = txtSdt.Text,
                IdNhom = selectedNhom.IdNhom,
            };
            LienLacViewModel.AddLienLac(ll);
            if(LienLacViewModel.AddLienLac(ll) == KetQuaLienLac.ThanhCong)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("SDT hoac Id bi trung");
                txtSdt.Focus();
            }
        }

        void NapDsNhom()
        {
            var ls = NhomViewModel.GetList();
            cbbNhom.DataSource = ls;
            cbbNhom.ValueMember = "IdNhom";
            cbbNhom.DisplayMember = "TenNhom";
        }
        public NhomViewModel selectedNhom
        {
            get
            {
                return cbbNhom.SelectedItem as NhomViewModel;
            }
        }
    }
}
