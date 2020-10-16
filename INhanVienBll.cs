using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
   public partial interface INhanVienBll
    {
        List<NhanVienModel> GetDataAll();
            NhanVienModel GetDatabyID(string id);
            bool delete(string maNV);
          bool  Edit(NhanVienModel model);
            bool Create(NhanVienModel model);
    }
}
