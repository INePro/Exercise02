namespace ClassLibrary
{
    public class ClassPrimeFactors
    {
        public static string PrimeFactors(int number)
        {
            if(number < 2)
            {
                throw new ArgumentException("Number must be more than 2");
            }
            //Vector<int> vector = new Vector<int>();
            List<int> list = new List<int>();
            int n = 2;
            while (true)
            {
                if (number % n == 0)
                {
                    list.Add(n);

                    number /= n;
                    n = 2;
                }
                else
                {
                    n++;
                }

                if (number == 1)
                {
                    break;
                }

            }
            //list.ToString();

            return String.Join("x", list.ToArray());
        }
    }
}