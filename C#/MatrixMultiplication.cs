

namespace DofE
{
    class MatrixMultiplication
    {
        public static void Run()
        {
            Console.WriteLine("What is the width of the first matrix");
            int width1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the first matrix");
            int height1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the width of the second matrix");
            int width2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of the second matrix");
            int height2 = Convert.ToInt32(Console.ReadLine());

            int size1 = height1 * width1;
            int size2 = height2 * width2;
            int resultantsize = height1 * width2;

            if (width1 == height2)
            {
                List<int> Matrix1 = new List<int>();
                List<int> Matrix2 = new List<int>();
                List<int> ProdArray = new List<int>();
                for (int i = 0; i < size1; i++)
                {
                    Console.WriteLine($"Enter item {i + 1} of the first array");
                    Matrix1.Add(Convert.ToInt32(Console.ReadLine()));
                }
                for (int i = 0; i < size2; i++)
                {
                    Console.WriteLine($"Enter item {i + 1} of the second array");
                    Matrix2.Add(Convert.ToInt32(Console.ReadLine()));
                }
                for (int i = 0; i < resultantsize; i++)
                {
                    int Column = i % width1;
                    if (Column == 0)
                    {
                        Column = width1;
                    }

                    int Row = Convert.ToInt32(Math.Floor(Convert.ToDouble((i - 1) / width1)));

                    int NewItem = 0;
                    for (int j = 0; j < width1; j++)
                    {
                        NewItem = NewItem + (Matrix1[Row + j] * Matrix2[Column + j]);
                    }
                    ProdArray.Add(NewItem);
                }
                Console.WriteLine(ProdArray);
            }
            else
            {
                Console.WriteLine("They arent multiplictibly comfortable");
            }
        }

    }
}