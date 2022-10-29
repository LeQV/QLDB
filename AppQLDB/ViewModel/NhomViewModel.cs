using AppQLDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQLDB.ViewModel
{
    public enum KetQuaNhom
    {
        ThatBai = 0,
        ThanhCong = 1
    }
    public class NhomViewModel
    {
        public int IdNhom { get; set; }
        public String TenNhom { get; set; }

        public static List<NhomViewModel> GetList()
        {
            var db = new AppDBContact();
            var rs = db.Nhom.Select(e => new NhomViewModel { IdNhom = e.IdNhom, TenNhom = e.TenNhom }).ToList();
            return rs;
        }
        public static KetQuaNhom AddNhom(Nhom n)
        {
            var db = new AppDBContact();
            db.Nhom.Add(n);
            db.SaveChanges();
            return KetQuaNhom.ThanhCong;
        }
        public static KetQuaNhom RemoveNhom(NhomViewModel n)
        {
            var db = new AppDBContact();
            var nhom = db.Nhom.Where(e => e.IdNhom == n.IdNhom).FirstOrDefault();
            db.Nhom.Remove(nhom);
            db.SaveChanges();
            return KetQuaNhom.ThanhCong;
        }
    }
}
