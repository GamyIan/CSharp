namespace Ian_TYIT
{
    internal class Program
    {
        static int dSum(int[,] mat)
        {
            int sum = 0;
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            if (rows != cols)
            {
                Console.WriteLine("Not a square matrix");
                return 0;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == j || i + j == rows - 1)
                    {
                        sum += mat[i, j];
                    }
                }


            }
            return sum;
        }

        static int bSum(int[,] mat)
        {
            int sum = 0;
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                    {
                        sum += mat[i, j];
                    }
                }
            }

            return sum;
        }

        static int max(int[,] mat)
        {
            int rows = mat.GetLength(0);
            int cols = mat.GetLength(1);

            int max = mat[0, 0];

            for(int i=0; i < rows; i ++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mat[i,j] > max)
                    {
                        max = mat[i, j];
                    }
                }
            }

            return max;
        }

        static void Main()
        {
            int[,] mat = { {3,4,2},
                           { 1,2,1},
                           {3,3,3}
            };

            int answer = dSum(mat);
            Console.WriteLine(answer);

            int answer2 = bSum(mat);
            Console.WriteLine(answer2);

            int answer3 = max(mat);
            Console.WriteLine(answer3);
        }
    }
}
