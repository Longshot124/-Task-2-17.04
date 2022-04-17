using System;

namespace HomeWork_2_17._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eded elave edin");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bolunen ededi daxil edin");
            int dividedNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = firstNumber % dividedNumber;
            int total = 0;
            int thirdNumber = dividedNumber / 2;



            if (secondNumber <= thirdNumber)
            {
                total = firstNumber - secondNumber;
                Console.WriteLine("Verilmis edede yaxin bolunen reqem" +" "+ total);
            }
            else if (secondNumber > thirdNumber)
            {
                total = firstNumber + dividedNumber - secondNumber;
                Console.WriteLine("verilmis edede yaxin boluen reqem" +" "+ total);

            }
            else { Console.WriteLine("Eded bolunur"); }
            
            Console.ReadLine();
            
        }
    }
}
