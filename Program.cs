using System;

namespace ConsoleApp19
{
	class Program
	{
		static void Main(string[] args)
		{
			MyList<string> list = new MyList<string>();
			list.Add("Безумие это точное повторение одного и того же действия раз за разом,");
			list.Add("В надежде на изменнение это и безумие ");
			list.Add("Когда впервые я это услышал, не помню кто сказал эту хрень я БУМ, убил его");
			list.Add("Смысл в том хахаха Окей? Он был прав.");
			list.AddFront("Я уже говорил что такое безумиею А?");
			list.Print();



		}
	}
}
