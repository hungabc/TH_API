using DAL.Helper;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public partial class NhanVienDal:INhanVienDal
    {
        private IDatabaseHelper _dbHelper;
        public NhanVienDal(IDatabaseHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public NhanVienModel GetDatabyID(string id)
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "getbyid",
                     "@id", id);
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<NhanVienModel>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<NhanVienModel> GetDataAll()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "getallnv");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<NhanVienModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Create(NhanVienModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "createnv", 
                "@maNV", model.maNV,
                "@TenNV", model.TenNV,
                "@GioiTinh", model.GioiTinh,
                "@NgaySinh", model.NgaySinh,
                "@email", model.email,
                "@SDT", model.SDT);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Edit(NhanVienModel model)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "editnhanvien",
                "@maNV", model.maNV,
                "@TenNV", model.TenNV,
                "@GioiTinh", model.GioiTinh,
                "@NgaySinh", model.NgaySinh,
                "@email", model.email,
                "@SDT", model.SDT);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool delete(string maNV)
        {
            string msgError = "";
            try
            {
                var result = _dbHelper.ExecuteScalarSProcedureWithTransaction(out msgError, "deletenv",
                "@maNV", maNV);
                if ((result != null && !string.IsNullOrEmpty(result.ToString())) || !string.IsNullOrEmpty(msgError))
                {
                    throw new Exception(Convert.ToString(result) + msgError);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
