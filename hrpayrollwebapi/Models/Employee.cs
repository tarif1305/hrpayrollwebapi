﻿using System.ComponentModel.DataAnnotations;

namespace hrpayrollwebapi.Models
{
	public class Employee
	{
		[Key]
		public int EmployeeId { get; set; }

		[Required, MaxLength(100)]
		public string FullName { get; set; }

		[Required, MaxLength(50)]
		public string Position { get; set; }

		[Required]
		public DateTime HireDate { get; set; }

		public decimal BasicSalary { get; set; }

		
		public List<PayrollDetails> PayrollDetails { get; set; }
	}
}
