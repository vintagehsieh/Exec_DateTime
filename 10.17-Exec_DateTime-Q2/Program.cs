using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._17_Exec_DateTime_Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Exec_DateTime
			//Q2: 計算圖書下個月歸還時間?

			//A2: 以當天日期計算下個月歸還時間
			DateTime today = DateTime.Now;
			DateTime returnTime = today.AddMonths(1);
			Console.WriteLine(returnTime);
		}
	}
}
