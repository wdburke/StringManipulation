namespace PrimeTest
{
    public class PrimeTesting
    {
        public static void Main()
        {
        }

        public static bool Test(int passedValue)
        {
            if (passedValue>2 && passedValue%2 == 0)
            {
                return false;
            }
            else if (passedValue>3 && passedValue%3==0)
            {
                return false;
            }
            for (var i = 3; (i*i) <= passedValue; i += 2)
            {
                if ((passedValue%i) == 0)
                {
                    return true;
                }
            }
            return true;
        }
    }
}