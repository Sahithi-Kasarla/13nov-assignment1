using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Manipulating_data_with_jagged_arrays_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int nos, marks;
            Console.WriteLine("enter no.of students");
            nos=int.Parse(Console.ReadLine());
            int[][] students=new int[nos][];
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"enter subjects of students{i + 1}");
                marks = int.Parse(Console.ReadLine());
                students[i] = new int[marks];
                for(int j=0;j <marks; j++)
                {
                    Console.WriteLine($"enter the marks of {j + 1} subject");
                    students[i][j]= int.Parse(Console.ReadLine());
                }*/

            int[][] students = new int[3][];
            {
                students[0] = new int[] { 85, 92, 78 };
                students[1] = new int[] { 90, 87, 93, 89 };
                students[2] = new int[] { 76, 88 };



                //printing the scores
                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine("marks" + (i + 1));

                    for (int j = 0; j < students[i].Length; j++)
                    {
                        Console.WriteLine(students[i][j] + " ");
                    }
                }
                //calculating the avg of individual scores
                for (int i = 0; i < students.Length; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < students[i].Length; j++)
                    {
                        //printing the avg of ech student
                        sum += students[i][j];

                    }
                    double average = sum / students[i].Length;
                    Console.WriteLine($"the average of {i + 1} student is " + average);
                }


                double overallSum = 0;
                int overallCount = 0;

                // Calculate the sum of all scores
                for (int i = 0; i < students.Length; i++)
                {
                    for (int j = 0; j < students[i].Length; j++)
                    {
                        overallSum += students[i][j];
                        overallCount++;
                    }
                }

                // Calculate the overall average score
                double overallAverage = overallSum / overallCount;
                Console.WriteLine("The overall average is" + overallAverage);
                Console.WriteLine("*****************");
                Console.ReadKey();
            }


        }
    }
}
