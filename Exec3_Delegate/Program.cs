using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> test = new List<int> { 11, 25, 36, 99, 88, 46, 25, 42 };
			Func<int, bool> isEven = (int n) => n % 2 == 0;
			List<int> result = GetEvenItems(test, isEven);

			foreach(var x in result)
			{
				Console.WriteLine(x);
			}

			Console.ReadLine();
		}
		static List<int> GetEvenItems(List<int> list, Func<int, bool> func) 
		{
			List<int> result = new List<int>();
			foreach (var x in list)
			{
				if (func(x) == true) result.Add(x);
			}
			return result;
		}
	}
}
