using System;

namespace Project{

    class Program{

        static void Main() {
            const float PI = 3.14159265f; // Константа, неизменяеммое значение.
            int num_1,box=3;
            uint posotove = 12; // uint принемает только позитивные числа Unsigned integer

            Console.WriteLine("Переменная равна: " + box); // строка + чило .. Слияние переменных 

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


            		//Строки - это последовательности символов
		            string myString = "Hello, world!";

		            // + — это операция "приписывания" одной строки к другой:
		            string s = "Hello " + "world";;

                    // Можно обращаться к отдельным символам
		            char c = myString[1]; //'e' — нумерация символов с нуля.
		            char myChar = 'e'; // одинарные кавычки используются для символов. Двойные — для строк.
                    // char принемает одно число.
                    //У строк есть собственные методы и переменные (правильно называть это свойствами),
		            //которые позволяют узнать информацию о строке 
		            Console.WriteLine(myString.Length); // свойство Length позволяет узнать длину строки

		            myString = myString.Substring(0, 5); // Substring


                            int number = int.Parse("42"); //Из строки в число
		                    string numString = 42.ToString(); // Из числа в строку
        }
    }
}