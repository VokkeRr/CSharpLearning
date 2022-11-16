using System;

namespace Project{

    class Program{

        static void Main() {
            const float PI = 3.14159265f; // Константа, неизменяеммое значение.
            int num_1,box=3;
            
            box -= 2; // оператор присваивания box = box - 2 (3-2=1)

            num_1 = Convert.ToInt32(Console.ReadLine());
            num_1 *= 5; // оператор присваивания num_1= num_1 * 5

            int a = 45;
            double b = 34.56;

            a=(int)b;  // происходит потеря дробной части; 
            a=(int)Math.Round(b); // МЕТОД Round класса Math округлаят число 3.5=4 3.3=3


            double de = 12.23; // по умолчанию все числа с плавающей точкой, типа double;
            float df = 12.24f; // f служит подтверждение на перевод в тип float // float df=(float)12.24 


            Console.WriteLine("Answer " + num_1);
        }
    }
}