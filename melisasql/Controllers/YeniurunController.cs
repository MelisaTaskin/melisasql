using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace melisasql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YeniurunController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add(Yeniurun yeniurun)
        {
            MyDbContext myDbContext = new MyDbContext();
            var urunler = myDbContext.Yeniurun.Where(x => x.CompanyType == "migros");
            myDbContext.Yeniurun.Add(yeniurun);
            myDbContext.SaveChanges();
            return Ok(urunler);

        }

    }
}
