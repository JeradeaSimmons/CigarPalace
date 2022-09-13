using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CigarPalace.Models;
using CigarPalace.Services;
using Microsoft.AspNetCore.Mvc;

namespace CigarPalace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CigarsController : ControllerBase
    {
        private readonly CigarsService _cigarService;
        public CigarsController(CigarsService cigarService)
        {
            _cigarService = cigarService;
        }
        [HttpGet]
        public ActionResult<List<Cigar>> GetCigars()
        {
            try 
            {
              List<Cigar> cigars = _cigarService.GetCigars();
              return Ok(cigars);
            }
            catch (Exception e)
            {
              return BadRequest(e.Message);
            }
        }

         [HttpPost]
    public ActionResult<Cigar> CreateCigar([FromBody] Cigar body)
    {
      try
      {
        Cigar cigar = _cigarService.CreateCigar(body);
        return Ok(cigar);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    }
}