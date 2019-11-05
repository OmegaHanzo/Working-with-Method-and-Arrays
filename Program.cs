using System;

namespace Working_with_Methods
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[50];//arr = array
            int i, num, evennum, oddnum;

            //Reads size and elements in array
            Console.WriteLine("Enter size of the array");
            num = Convert.ToInt32(Console.ReadLine());//converts the value of the 
            Console.WriteLine("Enter " + num + " elements in the array: ");

            for (i=0; i<num; i++)
            {
                
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            evennum = 0; 
            oddnum = 0; 

            for (i =0; i <num; i++)
            {

                if (arr [i] % 2 == 0)
                {
                    evennum++;
                }
                else
                {
                    oddnum++; //increments odd number
                }
            }

            Console.WriteLine("Total even numbers: " + evennum);
            Console.WriteLine("Total Odd numbers: " + oddnum);

            Console.ReadLine();
        }
    }
}
