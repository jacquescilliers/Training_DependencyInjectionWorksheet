using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DependencyInjection_Worksheet
{
    [TestFixture]
    public class PublicHolidayNotifierTests
    {
        [Test]
        public void IsYouthDayOnThe17June2013()
        {
            var dateGenerator = new DateGeneratorTest(new DateTime(2013, 6, 17));
            var sut = new PublicHolidayNotifier(dateGenerator);
            Assert.That(sut.GenerateNotification(), Is.EqualTo("Today is Youth Day"));
        }

        [Test]
        public void IsNormalDayOnThe18June2013()
        {
            var dateGenerator = new DateGeneratorTest(new DateTime(2013, 6, 18));
            var sut = new PublicHolidayNotifier(dateGenerator);
            Assert.That(sut.GenerateNotification(), Is.EqualTo("Today is a normal day"));
        }        
    }
    public class DateGeneratorTest : IDateGenerator
    {
        private readonly DateTime _overrideDate;

        public DateGeneratorTest(DateTime overrideDate)
        {
            _overrideDate = overrideDate;
        }

        public DateTime DateToUse()
        {
            return _overrideDate;
        }
    }

}
