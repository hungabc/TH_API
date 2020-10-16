using BLL.Interfaces;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
   public partial class NhanVienBll:INhanVienBll
    {

        private NhanVienDal _res;
        public NhanVienBll(NhanVienDal ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(NhanVienModel model)
        {
            return _res.Create(model);
        }
        public bool Edit(NhanVienModel model)
        {
            return _res.Edit(model);
        }
        public bool delete(string maNV)
        {
            return _res.delete(maNV);
        }
        public NhanVienModel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<NhanVienModel> GetDataAll()
        {
            return _res.GetDataAll();
        }
    }
}
