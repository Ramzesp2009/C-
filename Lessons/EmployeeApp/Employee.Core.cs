using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
		private string _empName;
		private int _empId;
		private float _currPay;
		private int _empAge;
		private string _empSSN;
		private EmployeePayTypeEnum _payType;

		public Employee() { }
		public Employee(string name, int id, float pay, string empSsn) : this(name, 0, id, pay, empSsn, EmployeePayTypeEnum.Salaried) { }
		public Employee(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType)
		{
			Name = name;
			Id = id;
			Age = age;
			Pay = pay;
			SocialSecurityNumber = empSsn;
			PayType = payType;
		}
	}
}
