using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Task
{
	public class Student
	{
		public string Name;
		public string SurName;
		public string Group;
		public decimal Point;
		public bool IsGraduate = true;

		public void Task(string name, string surnama, string group, decimal point)
		{
			Name= name;
			SurName= surnama;
			Group= group;
			Point= point;
			
		}
		public void GetInfo() 
		{
			Console.WriteLine($"{ Name}");
			Console.WriteLine($"{ SurName }");
			Console.WriteLine($"{ Group}");
			Console.WriteLine($"{ Point}");
			Console.WriteLine($"{IsGraduate = Point >= 65}");
			
		}
		public void CheckGraduation(string graduation)
		{
			if (IsGraduate)
			{
				Console.WriteLine("kecib");
			}
			else 
			{
				Console.WriteLine("kesilib");
			}

		}
		public void GetDiplomDegree(string degree)
		{
			if(Point>=65 && Point < 80)
			{
				Console.WriteLine("adi");
			}
			else if( Point>=80 && Point<90) 
			{
				Console.WriteLine("sheref");
			}
			else
			{
				Console.WriteLine("yuksek sheref");
			}
		}


	}
}
