using System;
using System.Collections.Generic;
					
public class AllUniqueChars
{
	public static void Main()
	{
		var input = "abcde";
		var input2 = "Aa";
		var input3 = "abcdee";
		var input4 = "";
		
		Console.WriteLine(HasUniqueChars(input));
		Console.WriteLine(HasUniqueChars(input2));
		Console.WriteLine(HasUniqueChars(input3));
		Console.WriteLine(HasUniqueChars(input4));
	}
	
	public static bool HasUniqueChars(string input)
	{
		 var list = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
		
		foreach(var item in input.ToCharArray())
		{
			if(list.Contains(item.ToString()))
				return false;
			
			list.Add(item.ToString());
		}
		
		return true;
	}
}
