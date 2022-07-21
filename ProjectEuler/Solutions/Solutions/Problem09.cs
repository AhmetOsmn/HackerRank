namespace Solutions
{
    public class Problem09
    {
        /*
            A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

                            a^2 + b^2 = c^2

            For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
            
            There exists exactly one Pythagorean triplet for which a + b + c = 1000.
            
            Find the product abc.
        */

        public static void Solution()
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = a; b < 1000; b++)
                {
                    double c = Math.Sqrt(Math.Pow(b,2)+Math.Pow(a,2));
                    if(c+b+a == 1000)
                    {
                        Console.WriteLine("a: " + a + " b: " + b + " c: " +c +" axbxc: " + a*b*c);
                        break;
                    }
                }
            }
        }
    }
}
