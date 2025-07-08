using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract class Employee
    {
        protected string EmpName;
        protected int EmpId;
        protected float CurrPay;
        protected int EmpAge;
        protected string EmpSSN;
        protected EmployeePayTypeEnum EmpPayType;
        protected BenefitPackage EmpBenefits = new BenefitPackage();
        public Employee() { }
        public Employee(string name, int age, int id, float pay, string empSsn, EmployeePayTypeEnum payType)
        {
            Name = name;
            Id = id;
            Age = age;
            Pay = pay;
            SocialSecurityNumber = empSsn;
            PayType = payType;
        }
        public virtual void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commission } => Pay += .10F * amount,
                { PayType: EmployeePayTypeEnum.Hourly } => Pay += 40F * amount / 2080F,
                { PayType: EmployeePayTypeEnum.Salaried } => Pay += amount,
                _ => Pay += 0
            };
        }
        public virtual void DisplayStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Pay: {Pay}");
            Console.WriteLine($"SSN: {SocialSecurityNumber}");
        }
        public string Name
        {
            get => EmpName;
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    EmpName = value;
                }
            }
        }
        public int Id
        {
            get => EmpId;
            set => EmpId = value;
        }
        public float Pay
        {
            get => CurrPay;
            set => CurrPay = value;
        }
        public int Age
        {
            get => EmpAge;
            set => EmpAge = value;
        }
        public string SocialSecurityNumber
        {
            get => EmpSSN;
            private set { EmpSSN = value; }
        }
        public EmployeePayTypeEnum PayType
        {
            get => EmpPayType;
            set => EmpPayType = value;
        }
        public double GetBenefitCost() => EmpBenefits.ComputePayDeduction();
        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }

            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
        public BenefitPackage Benefits
        {
            get => EmpBenefits;
            set => EmpBenefits = value;
        }
    }
}
