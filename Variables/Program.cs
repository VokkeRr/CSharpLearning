using System;

namespace Project{

    class Program{

        static void Main() {
            const float PI = 3.14159265f; // Константа, неизменяеммое значение.
            int num_1,box=3;
            
            box -= 2; // оператор присваивания box = box - 2 (3-2=1)

            num_1 = Convert.ToInt32(Console.ReadLine());
            num_1 *= 5; // оператор присваивания num_1= num_1 * 5


            Console.WriteLine("Answer " + num_1);
        }
    }
}