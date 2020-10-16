using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        private INhanVienBll a;
        public NhanVienController(INhanVienBll itemBusiness)
        {
            a = itemBusiness;
        }

        // GET: api/<NhanVienController>
        [HttpGet]
        public IEnumerable<NhanVienModel> Get()
        {
            return a.GetDataAll();
        }

        // GET api/<NhanVienController>/5
        [HttpGet("{id}")]
        public NhanVienModel Get(string id)
        {
            return a.GetDatabyID(id);
        }

        // POST api/<NhanVienController>
        [HttpPost]
        public bool Post([FromBody] NhanVienModel value)
        {
            return a.Create(value);
        }

        // PUT api/<NhanVienController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] NhanVienModel value)
        {
            return a.Edit(value);
        }

        // DELETE api/<NhanVienController>/5
        [HttpDelete("{id}")]
        public bool Delete(string id)
        {
            return a.delete(id);
        }
    }
}
