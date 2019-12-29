/* CODE OF HONOR: I have not discussed the source code in my program with anyone other than my 
 * instructor’s approved human sources. I have not used source code obtained from another student, 
 * or any other unauthorized source, either modified or unmodified. If any source code or documentation 
 * used in my program was obtained from another source, such as a textbook or course notes, that 
 * has been clearly noted with a proper citation in the comments of my program. I have not knowingly 
 * designed this program in such a way as to defeat or interfere with the normal operation of any 
 * machine it is graded on or to produce apparently correct results when in fact it does not. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment_8
{
    class Employee
    {
        public Employee()
        {
        }

        public Employee(String firstname, String lastname, String supervisor)
        {
            FirstName = firstname;
            LastName = lastname;
            Supervisor = supervisor;
        }

        private String _firstName = "";
        public String FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        private String _lastName = "";
        public String LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        private String _supervisor = "";
        public String Supervisor
        {
            get { return this._supervisor; }
            set { this._supervisor = value; }
        }

        private double _totalhoursworked;
        public double TotalHoursWorked
        {
            get { return this._totalhoursworked; }
            set { this._totalhoursworked = value; }
        }

        public double RegHoursWorked
        {
            // Gets the total hours worked if less than 40. Otherwise 40
            get { return (TotalHoursWorked > 40)?  40:TotalHoursWorked; }
        }

        public double OvertimeHoursWorked
        {
            // Gets hours over 40. Otherwise 0
            get { return (TotalHoursWorked > 40) ? TotalHoursWorked-40 : 0; }
        }

        private decimal _reghourlywage;
        public decimal RegHourlyWage
        {
            get { return this._reghourlywage; }
            set { this._reghourlywage = value; }
        }

        private double _overtimerate = 1.5;
        public double OvertimeRate
        {
            get { return this._overtimerate; }
            set { this._overtimerate = value; }
        }

        public decimal OvertimeHourlyWage
        {
            get { return (RegHourlyWage * (Decimal)OvertimeRate); }           
        }

        // Calculates gross pay for employee (no deductions)
        public decimal getGrossPay()
        {
            if (OvertimeHoursWorked > 0) // Overtime workweek
            {
                return (RegularHourlyPay + OvertimeHourlyPay);
            }
            else // Regular workweek
            {
                return RegularHourlyPay;
            }
        }

        public decimal OvertimeHourlyPay
        {
            get { return OvertimeHourlyWage * (decimal)OvertimeHoursWorked; }
        }

        public decimal RegularHourlyPay
        {
            get { return RegHourlyWage * (decimal)RegHoursWorked; }
        }
    }
}
