using System.Diagnostics;

namespace Matricos
{
    public class Calculations
    {
        private int[,] _matrixA;
        private int[,] _matrixB;

        public Calculations(int[,] MatrixA, int[,] MatrixB)
        {
            _matrixA = MatrixA;
            _matrixB = MatrixB;
        }

        public int[,] Multiply()
        {
            int x1 = _matrixA.GetLength(0);
            int y1 = _matrixA.GetLength(1);
            int x2 = _matrixB.GetLength(0);
            int y2 = _matrixB.GetLength(1);

            int[,] result = new int[x1, y2];

            var Stopwatch = new Stopwatch();
            Stopwatch.Start();

            for (int i = 0; i < x1; i++)
            {
                for (int j = 0; j < y2; j++)
                {
                    int sum = 0;
                    Thread[] threads = new Thread[y1];

                    for (int k = 0; k < y1; k++)
                    {
                        int m = k;
                        threads[k] = new Thread(() =>
                        {
                            int partialProduct = _matrixA[i, m] * _matrixB[m, j];
                            lock (result)
                            {
                                sum += partialProduct;
                            }
                        });
                        threads[k].Start();
                    }

                    foreach (var thread in threads)
                    {
                        thread.Join();
                    }
                    result[i, j] = sum;
                }
            }

            Stopwatch.Stop();
            TimeSpan Time = Stopwatch.Elapsed;
            double TimeMs = Time.TotalMilliseconds;
            MessageBox.Show($"Laikas: {TimeMs} ms");
            Stopwatch.Reset();

            return result;
        }
    }
}