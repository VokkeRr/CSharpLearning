// Таким образом вы подключаете пространство имен System к вашему кодовому файлу 
// (не к всему проекту! Это не Reference!)
using System;

//Таким образом вы определяете свое пространство имен.
namespace Hello_World
{

	// Таким образом определяется класс.
      class Program{
	
		/*
		 * void Main() определяет метод.
		 * Из-за своего названия Main является точкой входа — это метод, 
		 * который будет запущен при выполнении программы.
		 */

			// Этот код выводит на экран строку
			// Console — это класс, так же как Program, но из пространства имен System.
			static void Main() {
            Console.WriteLine("Hello MQ");
            Console.Write("Hello in one line");
            Console.Write("Hello in line");
            Console.Write("Hello in one line \n"); // \n перенос на новую строку
            Console.Write("Hello in line");
            System.Console.Write("Hello in line");
        }
    }
}
            // Обратите внимание, регистр символов имеет значение!
            // Console.writeline("Hello, world"); // это не скомпилируется.
			
			// Как и в любом языке программирования, нужно строго соблюдать синтаксис.
			// Например, каждую инструкцию нужно заканчивать точкой с запятой.
			// Сonsole.WriteLine("Hello, world") // это не скомпилируется.

        // this is coment (on one line(Ctrl+/))
        /*
        This is coment (Until closing)
        */

        