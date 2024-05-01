﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Matricos
{
    public class Calculations
    {
        private int[,] _MatrixA;
        private int[,] _MatrixB;
        private int _size;

        public Calculations(int[,] MatrixA, int[,] MatrixB, int size)
        {
            _MatrixA = MatrixA;
            _MatrixB = MatrixB;
            _size = size;
        }

        public int[,] Multi()
        {
            int[,] result = new int[_size, _size];
            Thread[] threads = new Thread[_size];
            for (int i = 0; i < _size; i++)
            {
                int rows = i;
                threads[i] = new Thread(() => MultiplyRow(rows, result));
                threads[i].Start();
            }
            for (int i = 0; i < _size; i++)
            {
                threads[i].Join();
            }
            return result;
        }

        private void MultiplyRow(int row, int[,] result)
        {
            for (int j = 0; j < _size; j++)
            {
                int sum = 0;
                for (int k = 0; k < _size; k++)
                {
                    sum += _MatrixA[row, k] * _MatrixB[k, j];
                }
                result[row, j] = sum;
            }
        }
    }
}
