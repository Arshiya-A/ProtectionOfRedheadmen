using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DonorController : ControllerBase
    {
        private readonly Context _db;
        public DonorController(Context context)
        {
            _db = context;
        }

        [HttpGet("GetAllDonors")]
        public IActionResult GetAllDonors()
        {
            try
            {
                var donors = _db.Donors.ToArray();
                return Ok(donors);
            }
            catch
            {
                return NotFound();
            }
        }




        [HttpPost("AddDonor")]
        public IActionResult AddDonor(Donor donor)
        {
            try
            {
                _db.Donors.Add(donor);
                _db.SaveChanges();
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}