using System.Data;

namespace FactoryHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];

            FirstStep firstStep = new FirstStep(mat);
            SecondStep secondStep = new SecondStep(mat);
            ThirdStep thirdStep = new ThirdStep(mat);
            FourthStep fourthStep = new FourthStep(mat);

            firstStep.Next = secondStep;
            secondStep.Next = thirdStep;
            thirdStep.Next = fourthStep;

            firstStep.Handle();

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < mat.GetLength(1); j++)
                    Console.Write(mat[i, j] + ",");
            }
        }
        

        
        
    }
}
