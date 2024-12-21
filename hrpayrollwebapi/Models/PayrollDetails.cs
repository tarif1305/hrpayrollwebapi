﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace hrpayrollwebapi.Models
{
	public class PayrollDetails
	{
		[Key]
		public int PayrollId { get; set; }

	
		[Required]
		public string PayMonth { get; set; }  

		[Required]
		public decimal GrossSalary { get; set; }

		public decimal Deductions { get; set; }

		public decimal NetSalary { get; set; }


		[ForeignKey("Employee")]
		public int EmployeeId { get; set; }
		public Employee Employee { get; set; }

	}
}