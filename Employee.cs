using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_Binod_Shrestha
{
    class Employee
    {
        private string _name;
        private double _hourlyWage;
        private double _hoursWorked;
        private double _grossIncome;
        private double _netIncome;

        // default constructor
        public Employee()
        {

        }

        // constructor with parameters
        public Employee(string name, double hourlyWage, double hoursWorked)
        {
            _name = name;
            _hourlyWage = hourlyWage;
            _hourlyWage = HoursWorked;
        }

        /// <summary>
        /// getter and setter for customer name with some input constraints.It returns string value.
        /// </summary>
        public string Name
         {
            get { return _name; }
            set {
                if (string.IsNullOrEmpty(value))
                    throw new ApplicationException("Enter the employee name.");
                
                else
                    _name = value; }
        }

        /// <summary>
        /// getter and setter for hourly wage with some input constraints.It returns double value.
        /// </summary>
        public double HourlyWage
         {
            get { return _hourlyWage; }
            set {
                
               if (value <= 0)
                {

                    throw new ApplicationException("Wage cannot be 0 or negative value");
                }
                else
                {
                    _hourlyWage = value;
                }
                }
        }

        /// <summary>
        /// getter and setter for hours worked with some input constraints. It returns double value.
        /// </summary>
        public double HoursWorked
        {
            get { return _hoursWorked; }
            set {
                
                if (value <= 0)
                    throw new ApplicationException("Hours worked cannot be negative or 0");
                if (value > 80)
                    throw new ApplicationException("Hours worked cannot be more than 80");
                if (string.IsNullOrWhiteSpace(value.ToString()))
                    throw new ApplicationException("Hours worked be left blank");

                else
                _hoursWorked = value; }
        } // end of HoursWorked

                /// <summary>
                /// It calculates the gross income with or without overtime.
                /// </summary>
                /// <returns></returns>
        public virtual double Earnings()
        {
            if (_hoursWorked > 40)

                return _grossIncome = (_hourlyWage * 40) + ((_hoursWorked - 40) * _hourlyWage) * 1.5;
            else

                return _grossIncome = this._hoursWorked * this._hourlyWage;

        } // end of earnings

        /// <summary>
        /// calculates the net earning.
        /// </summary>
        /// <returns></returns>
        public virtual double NetEarning()
        {
            return _netIncome = _grossIncome - _grossIncome * 0.15;
        } // end of NetEarnings


        /// <summary>
        /// calculates the tax amount.
        /// </summary>
        /// <returns></returns>
        public virtual double LessFWT()
        {
            return _grossIncome - _netIncome;
        } // end of LessFWT

      
    }
}
