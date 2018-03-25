using System;
namespace AsteriskLine {
	class Program {
		static void Main(string[] args) {
			PrintAsterisks(3);
			Console.ReadLine();
		}
        
        static void PrintAsterisks(int stars)
        {
            string ast = "*";
            for (int i = 1; i <= stars - 1; i++)
            {
                ast = ast + "*";
            }
            Console.WriteLine(ast);
        }
	}
}
