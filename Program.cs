internal class Program
{
    private static void Main(string[] args)
    {
        int Input(string text) 
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }
        void Task25() 
        {
            //Задача 25: Используя определение степени числа, напишите цикл,
            //который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
            //3, 5-> 243(3⁵)
            // 2, 4-> 16
            int number = Input("Задай число= ");
            int pow = Input($"Задай степень, в которую нужно возвести число {number} : ");
            //Console.WriteLine(Math.Pow(number,pow) ); //проверочный
            int result = 1;
            if (pow == 0) result = 1;
            else
                {
                for (int i = 1; i <= pow; i++) 
                {
                    result = result*number;                    
                }
                Console.WriteLine(result);
                }
            
        }
        //Task25();
        void Task27() 
        {
            //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            //452-> 11
            //82-> 10
            //9012-> 12
            int number = Input("Введи число: ");
            int sum = 0;
            while (number %10 > 0) 
            {
                sum=sum+number%10;
                number=number/10;                
            }
            Console.WriteLine(sum); 
        }
        //Task27();
        void Task29() 
        {
            //Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
            //-2, 1, 7, 5, 19-> [1, -2, 5, 7, 19]
            //6, 1, -33-> [1, 6, -33]
            int n = 8;  //  0   1  2  3   4  5  6  7
            //int[] mass = { -3, -5, 4, 8, -7, 6, 2,-1 };
            Random rand=new Random();
            int[] mass = new int[n];
            //вывод заданного массива
            for (int i = 0; i < n; i++)
            {
                mass[i] = rand.Next(-100,101) ;
                Console.Write($" {mass[i]}");
            }
            Console.WriteLine();    //пропуск строки
            int memory =0;
            for (int j=0; j < n; j++)
            { 
                for (int i = 1; i < n; i++) 
                    {
                        if (Math.Abs(mass[i-1]) > Math.Abs(mass[i]))
                        {
                            memory = mass[i-1];
                            mass[i - 1] = mass[i];
                            mass[i] = memory;
                        }
                
                    }
            }
            //вывод результирующего массива
            for (int i = 0; i < n; i++) 
            {
                Console.Write($" { mass[i]}"); 
            } 

        }
        Task29();
    }
}