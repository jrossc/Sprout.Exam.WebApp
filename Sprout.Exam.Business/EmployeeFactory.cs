        using System;
using System.Collections.Generic;
using System.Text;

namespace Sprout.Exam.Business
{
 public   abstract class Employe
    {
        public abstract Decimal NetIncome { get; set; }
        public abstract Decimal numberOfAbsences { get; set; }
        public abstract Decimal numberOfWorkedDays { get; set; }
    }        
    
   public  class RegularEmployee: Employe
    {
        private Decimal _NetIncome { get; set; }
        private Decimal _numberOfAbsences { get; set; }
        private Decimal _numberOfWorkedDays { get; set; }

        public RegularEmployee(Decimal numberOfAbsences)
        { 
            _numberOfAbsences = numberOfAbsences;
            double totaldays = 23 - Convert.ToDouble(_numberOfAbsences);
            double dayRate = 20000 / totaldays;
            double taxedAmount = 20000 * 0.12;

            _NetIncome = Convert.ToDecimal(20000 - dayRate - taxedAmount);
            _NetIncome = Math.Round(_NetIncome, 2);
        }
        public override Decimal NetIncome
        {
            get { return _NetIncome; }
            set { _NetIncome = value; }
        }

        public override Decimal numberOfAbsences
        {
            get { return _numberOfAbsences; }
            set { _numberOfAbsences = value; }
        }

        public override Decimal numberOfWorkedDays
        {
            get { return _numberOfWorkedDays; }
            set { _numberOfWorkedDays = value; }
        }

    }

   public class ContractualEmployee : Employe
    {
        private Decimal _NetIncome { get; set; }
        private Decimal _numberOfAbsences { get; set; }
        private Decimal _numberOfWorkedDays { get; set; }

        public ContractualEmployee(Decimal numberOfWorkedDays)
        {
            _numberOfWorkedDays = numberOfWorkedDays;

            _NetIncome = 500 * numberOfWorkedDays;
            _NetIncome = Math.Round(_NetIncome, 2);
        }
        public override Decimal NetIncome
        {
            get { return _NetIncome; }
            set { _NetIncome = value; }
        }

        public override Decimal numberOfAbsences
        {
            get { return _numberOfAbsences; }
            set { _numberOfAbsences = value; }
        }

        public override Decimal numberOfWorkedDays
        {
            get { return _numberOfWorkedDays; }
            set { _numberOfWorkedDays = value; }
        }
    }

   public abstract class EmployeeFactory
    {
        public abstract Employe GetNetIncome();
    }

   public class RegularEmployeeFactory : EmployeeFactory
    {
        private Decimal _numberOfAbsences;
        public RegularEmployeeFactory(Decimal numberOfAbsences)
        {
            _numberOfAbsences = numberOfAbsences;
        }
        public override Employe GetNetIncome()
        {
            return new RegularEmployee(_numberOfAbsences);
        }

    }

 public   class ContractualEmployeeFactory : EmployeeFactory
    {
        private Decimal _numberOfWorkedDays;
        public ContractualEmployeeFactory(Decimal numberOfWorkedDays)
        {
            _numberOfWorkedDays = numberOfWorkedDays;
        }
        public override Employe GetNetIncome()
        {
            return new ContractualEmployee(_numberOfWorkedDays);
        }

    }

}
