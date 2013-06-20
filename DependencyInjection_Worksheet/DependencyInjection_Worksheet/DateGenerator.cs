using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection_Worksheet
{
    public class DateGenerator : IDateGenerator
    {
        private readonly DateTime _dateToUse;

        public DateGenerator()
        {
            _dateToUse = new DateTime();
            _dateToUse = DateTime.Now.Date;
        }
        public DateTime DateToUse()
        {
            return _dateToUse;
        }
    }
}
