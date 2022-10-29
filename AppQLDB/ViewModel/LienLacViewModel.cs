using AppQLDB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQLDB.ViewModel
{
    public enum KetQuaLienLac
    {
        ThatBai = 0,
        ThanhCong = 1
    }
    public class LienLacViewModel
    {
        public int IdLienLac { get; set; }
        public string TenGoi { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public int? IdNhom { get; set; }

        public static List<LienLacViewModel> GetList(int IdNhom)
        {
            var db = new AppDBContact();
            var rs = db.LienLac
                .Where(e => e.IdNhom == IdNhom)
                .Select(e => new LienLacViewModel
                {
                    IdLienLac = e.IdLienLac,
                    TenGoi = e.TenGoi,
                    DiaChi = e.DiaChi,
                    Email = e.Email,
                    SDT = e.SDT,
                    IdNhom = e.IdNhom
                }).ToList();
            return rs;
        }
        public static KetQuaLienLac AddLienLac(LienLac ll)
        {
            var db = new AppDBContact();
            int countSDT = db.LienLac.Where(e => e.SDT == ll.SDT).Count();
            int countIdLienLac = db.LienLac.Where(e => e.IdLienLac == ll.IdLienLac).Count();
            if (countSDT > 0)
            {
                return KetQuaLienLac.ThatBai;
            }
            else if (countIdLienLac > 0)
            {
                return KetQuaLienLac.ThatBai;
            }
            else
            {
                db.LienLac.Add(ll);
                db.SaveChanges();
                return KetQuaLienLac.ThanhCong;
            }
        }
        public static KetQuaLienLac RemoveLienLac(LienLacViewModel ll)
        {
            var db = new AppDBContact();
            var lienlac = db.LienLac.Where(e => e.IdLienLac == ll.IdLienLac).FirstOrDefault();
            db.LienLac.Remove(lienlac);
            db.SaveChanges();
            return KetQuaLienLac.ThanhCong;
        }
        public static List<LienLacViewModel> TimKiem(int IdNhom, string key)
        {
            var db = new AppDBContact();
            var rs = db.LienLac.Where(e => e.IdNhom == IdNhom && (e.SDT.Contains(key)
            || e.TenGoi.Contains(key) || e.DiaChi.Contains(key)
            || e.Email.Contains(key)                
            )  ).Select(e => new LienLacViewModel
            {
                IdLienLac = e.IdLienLac,
                TenGoi = e.TenGoi,
                DiaChi = e.DiaChi,
                SDT = e.SDT,
                IdNhom = e.IdNhom,
                Email = e.Email
            }).ToList();
            return rs;
        }
    }
}
