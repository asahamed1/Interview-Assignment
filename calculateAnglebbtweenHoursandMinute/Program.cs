using System;

namespace calculateAnglebbtweenHoursandMinute
{
    class Program
    {
        private static readonly int completeAngle;
        private static readonly int oneHourAngel;
        private static readonly int oneMintueAngel;
        static Program()
        {

            completeAngle = 360;
            // angle for only one hour
            oneHourAngel = completeAngle / 12;
            // angle for only one mintue
            oneMintueAngel = completeAngle / 60;
        }
        public static int getAngleBetweenHoursAMinuts(int hours, int minutes)
        {
            var watchHourAngle = hours * oneHourAngel;
            var watchMintueAngle = minutes * oneMintueAngel;
            var angle = watchHourAngle - watchMintueAngle;
            if (angle == completeAngle)
            {
                angle = 0;
            }
            if (angle < 0)
            {
                return angle * -1;
            }
            return angle;

        }
        static void Main(string[] args)
        {


            int angle = getAngleBetweenHoursAMinuts(1, 0);

            Console.WriteLine(angle);

        }

    }
}
