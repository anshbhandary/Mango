using Mango.Services.CouponApplication.Data;
using Mango.Services.CouponApplication.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponApiController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CouponApiController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var p = _context.Coupons.ToList();
            return Ok(p);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var p = _context.Coupons.First(x => x.CouponId == id);
            return Ok(p);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CouponDto couponDto)
        {
            //var p = _context.Coupons.Add(couponDto);
            //_context.SaveChanges();
            return Ok();
        }

        





    }
}
