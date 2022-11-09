using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int> { 1,34,44,56,66,79 };
			Func<int ,bool> isEven=n=>n%2==0;
			List<int> evenItems=GetEvenItems(list, isEven);
		    foreach(int answer in evenItems)
			{
				Console.WriteLine(answer);
			}
		}
		 static List<int> GetEvenItems(List<int> source,Func<int,bool>funv)
		{
			var result=new List<int>();
			foreach(int item in source)
			{
				if(funv(item)==true)
				{
					result.Add(item);
				}
			}
			return result;
		}
	}
}
