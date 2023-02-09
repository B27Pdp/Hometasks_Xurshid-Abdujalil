using System;
using System.Text.RegularExpressions;

namespace Home.Module_3.L1_Regex
{
	public class SeperateNames
	{
		public static void Seperator()
		{
			List<string> Names = new()
			{ "Asror", "Sardor", "Sanjar", "Elyor", "Javoxir", "Soliha", "Muslima", "Asal", "Saodat" };
			List<string> SNames = new();
			foreach (var item in Names)
			{
				if(Regex.IsMatch(item, "^S")) SNames.Add(item);
			}
			
		}
	public SeperateNames()
		{
		}
	}
}

