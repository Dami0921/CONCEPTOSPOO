using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONCEPTOSPOO
{
    public class cDate
    {
        //creamos atributos
        private int _year;
        private int _month;
        private int _day;
        //creamos constructor
        public cDate(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = Checkday(year, month, day);
        }
        //metodo para crecar dia y crear excepcion
        private int Checkday(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }
            int[] DayPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day > 1 && day <= DayPerMonth[month])
            {
                return day;
            }

            throw new DayException("invalid day.");
        }
        //metodo checar si un año es bsciesto o no
        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        //metodo paa checar mes y excepcion.
        private int CheckMonth(int month)
        {
            if (month > 1 && month <= 12)
            {
                return month;
            }
            throw new MonthException("invalid month.");
        }
        //sobreescribimos con override. usamos interpolacion de string
        //para retornar valores.
        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}
