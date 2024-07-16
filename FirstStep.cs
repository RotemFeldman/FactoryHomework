using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryHomework
{
    internal class FirstStep : IHandler
    {
        public IHandler Next { get; set; }
        int[,] matrix;

        public FirstStep(int[,] matrix) 
        {
            this.matrix = matrix;
        }

        public void Handle()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 1;
                }

            Next?.Handle();
        }

        public void SetNext(IHandler handler)
        {
            Next = handler;
        }
    }
}
