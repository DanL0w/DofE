


namespace DofE
{
    public class TenUniqueDigits
    {
        public static void Run()
        {
            double a = 0;
            List<double> Answers = new List<double>();
            for (Int64 i = 0; i < 10000000000; i++)
            {
                if (a % 10 == 0 && Math.Floor(a / 10) % 9 == 0 && Math.Floor(a / 100) % 8 == 0 && Math.Floor(a / 1000) % 7 == 0 && Math.Floor(a / 10000) % 6 == 0 && Math.Floor(a / 100000) % 5 == 0 && Math.Floor(a / 1000000) % 4 == 0 && Math.Floor(a / 10000000) % 3 == 0 && Math.Floor(a / 100000000) % 2 == 0)
                {
                    Answers.Add(a);
                    a++;
                }
                else
                {
                    a++;
                }
            }
            foreach (var answer in Answers)
            {
                double prodDigits = 1;
                double addDigits = 0;
                List<double> digits = new List<double>();
                for (int i = 0; i < 10; i++)
                {
                    if (((Math.Floor(answer / Math.Pow(10, i))) % 10) == 0)
                    {
                        digits.Add(1);
                    }
                    else
                    {
                        digits.Add((Math.Floor(answer / Math.Pow(10, i))) % 10);
                    }
                    addDigits = addDigits + digits[i];
                    prodDigits = prodDigits * digits[i];
                }
                if (prodDigits == 362880 && addDigits == 46)
                {
                    Console.WriteLine(answer);
                }
            };
        }
    }
}