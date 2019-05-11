using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_Binod_Shrestha
{
    /// <summary>
    /// inherits from its super class Employee.
    /// </summary>
    class Manager : Employee
    {
        // class properties
       private double _earnedIncome;
        private double _grossIncome;
        private double _netEarnings;
        private double _lessFWT;
        
        // default constructor
        public Manager()
        {  }

        /// <summary>
        /// constructor of manager class with parameters.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hourlyWage"></param>
        /// <param name="hoursWorked"></param>
        public Manager(string name, double hourlyWage, double hoursWorked) : base(name, hourlyWage , hoursWorked)
        { }
        
        /// <summary>
        /// calculates the gross income. It returns double value.
        /// </summary>
        /// <returns></returns>
        public override double Earnings()
        {
           
            _earnedIncome = HourlyWage * HoursWorked;
            return _grossIncome = (_earnedIncome + (_earnedIncome * 0.2));
        } // end of Earnings method

        /// <summary>
        /// calculates the net earnings. It returns double value.
        /// </summary>
        /// <returns></returns>
        public override double NetEarning()
        {
            return _netEarnings = _grossIncome - (_grossIncome * 0.15) ;
        } //end of NetEarning method.

        /// <summary>
        /// calculates applied tax amount in the gross income.
        /// </summary>
        /// <returns></returns>
        public override double LessFWT()
        {
            return _lessFWT = _grossIncome - _netEarnings;
        } // end of LessFWT method

       
    }
}
