using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public partial interface INhanVienDal
    {
        bool delete(string maNV);
        bool Edit(NhanVienModel model);
        bool Create(NhanVienModel model);
        List<NhanVienModel> GetDataAll();
        NhanVienModel GetDatabyID(string id);
    }
}
