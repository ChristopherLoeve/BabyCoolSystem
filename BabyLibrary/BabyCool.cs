using System;

namespace BabyLibrary
{
    public class BabyCool
    {
        public static string AlarmBreath(int breath)
        {
            string msg = "normal";
            if (breath > 18) msg = "kritisk høj";
            if (breath < 12) msg = "kritisk lav";
            return msg;
        }

        public static bool AlarmCry(int cry)
        {
            if (cry == 1) return true;
            return false;
        }
    }
}
