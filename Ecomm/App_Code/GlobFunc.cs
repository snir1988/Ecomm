using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecomm
{
	public class GlobFunc
	{
		public static string GetRandStr(int length)
		{
			//פונקציה מקבלת מספר שלם ומחזירה מחרוזת אקראית באורך המספר למשל -3 יחזיר abc
			string st = "abcdefghijklmnopqstuvwxyz0123456789";
			string RetVal = "";
			Random rnd = new Random();
			for (int i = 0; i < length; i++)
			{
				int index = rnd.Next(st.Length);
				RetVal += st[index];
			}
			return RetVal;
		}
	}
}