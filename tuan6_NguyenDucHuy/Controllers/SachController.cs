using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tuan6_NguyenDucHuy.Models;

namespace tuan6_NguyenDucHuy.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach{Id = 1, Author = "JK.Rowling", Content ="Harry Potter va lu ban", Title = "Harry Potter and Deadly Hollow", Price = 2 },
            new Sach{Id = 2, Author = "Khong biet", Content ="witcher va lu ban", Title = "The Witcher", Price = 2 },
            new Sach{Id = 3, Author = "Fujio.F.Fujiko", Content ="Doraemon va lu ban", Title = "Doraemon", Price = 2 },

        };
        public IEnumerable<Sach> GetAll()
        {
            return sachs;
        }

        public IHttpActionResult getSach(int Id)
        {
            var sach = sachs.FirstOrDefault(p => p.Id == Id);
            if (sach == null)
            {
                return NotFound();
            }
            return Ok(sach);
        }
    }
}
