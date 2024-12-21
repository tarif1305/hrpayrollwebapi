using hrpayrollwebapi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hrpayrollwebapi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PayrollStatsController : ControllerBase
	{
		private readonly ApplicationDbContext db;

		public PayrollStatsController(ApplicationDbContext context)
		{
			db = context;
		}

		[HttpGet("/sum")]
		public IActionResult GetGroupedTotalGrossSalary()
		{
			var totalGrossSalary = db.PayrollDetails
				.GroupBy(p => p.PayMonth)
				.Select(g => new
				{
					PayMonth = g.Key,
					TotalGrossSalary = g.Sum(p => p.GrossSalary)
				})
				.ToList();

			return Ok(totalGrossSalary);
		}

		
		[HttpGet("/max")]
		public IActionResult GetGroupedMaxGrossSalary()
		{

			var maxGrossSalary = db.PayrollDetails
				.GroupBy(p => p.PayMonth)
				.Select(g => new
				{
					PayMonth = g.Key,
					MaxGrossSalary = g.Max(p => p.GrossSalary)
				})
				.ToList();

			return Ok(maxGrossSalary);
		}

		[HttpGet("/min")]
		public IActionResult GetGroupedMinGrossSalary()
		{

			var minGrossSalary = db.PayrollDetails
				.GroupBy(p => p.PayMonth)
				.Select(g => new
				{
					PayMonth = g.Key,
					MinGrossSalary = g.Min(p => p.GrossSalary)
				})
				.ToList();

			return Ok(minGrossSalary);
		}

		[HttpGet("/average")]
		public IActionResult GetGroupedAverageGrossSalary()
		{
			if (!db.PayrollDetails.Any())
				return NotFound("No payroll data available.");

			var averageGrossSalary = db.PayrollDetails
				.GroupBy(p => p.PayMonth)
				.Select(g => new
				{
					PayMonth = g.Key,
					AverageGrossSalary = g.Average(p => p.GrossSalary)
				})
				.ToList();

			return Ok(averageGrossSalary);
		}

		[HttpGet("/count")]
		public IActionResult GetGroupedPayrollCount()
		{
			if (!db.PayrollDetails.Any())
				return NotFound("No payroll data available.");

			var count = db.PayrollDetails
				.GroupBy(p => p.PayMonth)
				.Select(g => new
				{
					PayMonth = g.Key,
					Count = g.Count()
				})
				.ToList();

			return Ok(count);
		}
	}
}
