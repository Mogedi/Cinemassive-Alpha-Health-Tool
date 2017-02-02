using CineNet.Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alpha_Health.Model
{
    class TestingLoggerClass
    {
        public static void testLogger()
        {
            List<Exception> listOfExceptions = getExceptionTypes();

            var logger = new Logger();

            foreach (Exception item in listOfExceptions)
            {
                logger.WriteMessage(LogLevel.Exceptions, "This is a first message");
                logger.WriteMessage(LogLevel.Exceptions, "This is a second message");
                logger.LogException(item);
                logger.WriteMessage(LogLevel.Exceptions, "This is a first message");
                logger.WriteMessage(LogLevel.Exceptions, "This is a second message");
                logger.LogException(item);
                logger.WriteMessage(LogLevel.Exceptions, "This is a first message");
                logger.WriteMessage(LogLevel.Exceptions, "This is a second message");
                logger.LogException(item);
            }
        }



        private static void TestMethod()
        {
            throw new NotImplementedException();
        }

        private static List<Exception> getExceptionTypes()
        {
            List<Exception> exceptions = new List<Exception>();

            var sysEX = new SystemException();
            var argEX = new ArgumentException();
            var argNullEX = new ArgumentNullException();
            var argOutofRangeEX = new ArgumentOutOfRangeException();
            var arthEX = new ArithmeticException();
            var arrTypeMismathEX = new ArrayTypeMismatchException();
            var badimageFormatEX = new BadImageFormatException();
            var formathEX = new FormatException();
            var invCastEX = new InvalidCastException();
            var notSuptEX = new NotSupportedException();
            var nullRefEX = new NullReferenceException();

            exceptions.Add(sysEX);
            exceptions.Add(argEX);
            exceptions.Add(argNullEX);
            exceptions.Add(argOutofRangeEX);
            exceptions.Add(arthEX);
            exceptions.Add(arrTypeMismathEX);
            exceptions.Add(badimageFormatEX);
            exceptions.Add(formathEX);
            exceptions.Add(invCastEX);
            exceptions.Add(notSuptEX);
            exceptions.Add(nullRefEX);

            return exceptions;
        }
    }
}
