using System;
using System.Globalization;

namespace S3LabTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var peekHourStart ="9.00.00 AM";
            var peekHourEnd = "10.59.59 PM";


            var OFFpeekHourStart1 = "11.00.00 PM";
            var OFFpeekHourEnd1 = "11.59.59 pm";

            var OFFpeekHourStart2 = "12.00.00 AM";
            var OFFpeekHourEnd2 = "8.59.59 AM";





            var inputDateTimeStart = DateTime.ParseExact("2019-08-31 08:59:13 am", "yyyy-MM-dd h:mm:ss tt", CultureInfo.InvariantCulture);

            var inputeDatetimeEnd = DateTime.ParseExact("2019-08-31 09:00:39 am", "yyyy-MM-dd h:mm:ss tt", CultureInfo.InvariantCulture);

           
            


            //inputTime = checkTime(inputTime);
            DateTime inputedTimeStart = inputDateTimeStart;
            DateTime inputedTimeEnd = inputeDatetimeEnd;

            var inputedhourstart = inputedTimeStart.Hour;
            var inputedminutestart = inputedTimeStart.Minute;
            var inputedsecondstart = inputedTimeStart.Second;


            var inputedhourEnd = inputedTimeStart.Hour;
            var inputedminuteEnd = inputedTimeStart.Minute;
            var inputedsecondEnd = inputedTimeStart.Second;

            // Start time
            var pH = peekHourStart.Split('.');
            var pHEND = peekHourEnd.Split('.');

            var OFFpH1 = OFFpeekHourStart1.Split('.');
            var OFFpHEND1 = OFFpeekHourEnd1.Split('.');

            var OFFpH2 = OFFpeekHourStart2.Split('.');
            var OFFpHEND2 = OFFpeekHourEnd2.Split('.');



            if (inputedhourEnd < int.Parse(pHEND[0]) || inputedhourstart > int.Parse(pH[0]))
            {

                double totalpekSec = (inputedTimeEnd - inputedTimeStart).TotalSeconds;
                //Console.WriteLine(totalOffpeekSec);
                double pulse = totalpekSec / 20;
                double OnPeekTotal = pulse / 0.30;
                Console.WriteLine(OnPeekTotal + " paisa ");
            }
            else
            {
                double totalpekSec = (inputedTimeEnd - inputedTimeStart).TotalSeconds;
                double pulse = totalpekSec / 20;
                double offPeekTotal = pulse / 0.20;
                Console.WriteLine(offPeekTotal + "paisa ");

            }
            
        }





    }
}
