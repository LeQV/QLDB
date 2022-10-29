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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDsNhom();
            NapDsLienLac();
        }
        public NhomViewModel selectedNhom
        {
            get
            {
                return bindingSource1.Current as NhomViewModel;
            }
        }
        public LienLacViewModel selectedLienLac
        {
            get
            {
                return bindingSource2.Current as LienLacViewModel;
            }
        }  
        public void NapDsNhom()
        {
            var ls = NhomViewModel.GetList();
            bindingSource1.DataSource = ls;
            gridNhom.DataSource = bindingSource1;
        }
        public void NapDsLienLac()
        {
            if (selectedNhom != null)
            {
                var ls = LienLacViewModel.GetList(selectedNhom.IdNhom);
                bindingSource2.DataSource= ls;
                gridLienLac.DataSource = bindingSource2;
            }
        }

        private void gridNhom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapDsLienLac();
        }

        private void gridLienLac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenGoi.Text = selectedLienLac.TenGoi;
            txtDiaChi.Text = selectedLienLac.DiaChi;
            txtEmail.Text = selectedLienLac.Email;
            txtSdt.Text = selectedLienLac.SDT;
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            var fNhom = new FrmThemNhom();
            var rs = fNhom.ShowDialog();
            if(rs == DialogResult.OK)
            {
                NapDsNhom();
                NapDsLienLac();
            }
            
        }

        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            if(selectedNhom != null)
            {
                var rs = MessageBox.Show("Bạn có chắc chắn muốn xóa nhóm này không?",
                "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if( rs == DialogResult.OK)
                {
                    NhomViewModel.RemoveNhom(selectedNhom);
                    NapDsNhom();
                    NapDsLienLac();
                }
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void btnXoaLienLac_Click(object sender, EventArgs e)
        {
            if(selectedLienLac != null)
            {
                var rs = MessageBox.Show("Bạn có muốn xóa liên lạc này không?",
                    "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(rs == DialogResult.OK)
                {
                    LienLacViewModel.RemoveLienLac(selectedLienLac);
                    NapDsLienLac();
                }
            }

        }

        private void btnThemLienLac_Click(object sender, EventArgs e)
        {
            var fLienLac = new FrmThemLienLac();
            var rs = fLienLac.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDsLienLac();
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            var key = txtTimKiem.Text;
            var ls =LienLacViewModel.TimKiem(selectedNhom.IdNhom, key);
            bindingSource2.DataSource = ls;
            gridLienLac.DataSource = bindingSource2;


        }

        private void gridLienLac_SelectionChanged(object sender, EventArgs e)
        {
            if(selectedLienLac != null)
            {
                txtTenGoi.Text = selectedLienLac.TenGoi;
                txtDiaChi.Text = selectedLienLac.DiaChi;
                txtEmail.Text = selectedLienLac.Email;
                txtSdt.Text = selectedLienLac.SDT;
            }
            else
            {
                txtTenGoi.Text = "";
                txtDiaChi.Text = "";
                txtEmail.Text = "";
                txtSdt.Text = "";
            }
        }

        private void gridNhom_SelectionChanged(object sender, EventArgs e)
        {
            NapDsLienLac();
        }
    }
}
