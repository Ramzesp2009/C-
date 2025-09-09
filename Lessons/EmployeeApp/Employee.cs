using System;
using System.Collections.Generic;
using EmployeeApp;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commission } => Pay += .10F * amount,
                { PayType: EmployeePayTypeEnum.Hourly } => Pay += 40F * amount / 2080F,
                { PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
                _ => Pay += 0
            };
        }
        public void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Pay: {Pay}");
        }
        public string Name
        {
            get => _empName;
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }
        public int Id
        {
            get => _empId; 
            set => _empId = value;
        }
        public float Pay
        {
            get => _currPay;
            set => _currPay = value;
        }
        public int Age
        {
            get => _empAge;
            set => _empAge = value;
        }
        public string SocialSecurityNumber 
        {
            get => _empSSN;
            private set { _empSSN = value; }
        }
        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }
    }
}
