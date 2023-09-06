using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using resfull_api_demo.Model;

namespace resfull_api_demo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductRepo repo;

		public ProductController(IProductRepo repo)
		{
			this.repo = repo;
		}

		[HttpGet("GetAll")]
		public async Task<IActionResult> GetAll()
		{
			var _list = await this.repo.GetAll();

			if(_list != null)
			{
				return Ok(_list);
			}
			else
			{
				return NotFound();
			}
		}

        //[HttpGet("GetbyCode/{code}")]
        //public async Task<IActionResult> GetbyCode(int code)
        //{
        //    var _list = await this.repo.Getbycode(code);

        //    if (_list != null)
        //    {
        //        return Ok(_list);
        //    }
        //    else
        //    {
        //        return NotFound();
        //    }
        //}


   //     [HttpPost("Create")]
   //     public async Task<IActionResult> Create([FromBody] Product employee)
   //     {
   //         var _result = await this.repo.Create(employee);

			//return Ok(_result);
   //     }

        //[HttpPut("Update")]
        //public async Task<IActionResult> Update([FromBody] Product employee, int code)
        //{
        //    var _result = await this.repo.Update(employee, code);

        //    return Ok(_result);
        //}


        //[HttpDelete("Delete")]
        //public async Task<IActionResult> Delete(int code)
        //{
        //    var _result = await this.repo.Delete(code);

        //    return Ok(_result);
        //}
    }
}

