using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wheels.Models;
using Wheels.Persistence;

namespace Wheels.Controllers
{
    public class MakesController : Controller
    {
		private readonly WheelsDBContext context;

		public MakesController(WheelsDBContext context)
		{
			this.context = context;
		}

		[HttpGet("/api/makes")]
		public async Task<IEnumerable<Make>> GetMakes()
		{
			return await context.Makes.Include(m => m.Models).ToListAsync();
		}
    }
}
