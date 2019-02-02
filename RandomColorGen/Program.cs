using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomColorGen
{
	class Program
	{
		static void Main(string[] args)
		{

			ColourGen cGen = new ColourGen();
			Console.WriteLine(cGen.Generate());
			Console.ReadLine();
             
		}
	}

	public class ColourGen
	{
		public string Generate()
		{
			return "Red";
		}
	}
}
