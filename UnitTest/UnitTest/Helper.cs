using System;

namespace UnitTest
{
    public static class Helper
    {
        public static bool VerifyDangerAge(int age)
        {
            if(age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VerifyDangerSick(string name)
        {
            if (name == "Corona")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}