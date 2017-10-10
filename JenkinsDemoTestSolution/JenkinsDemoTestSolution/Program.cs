/*
 * Created by SharpDevelop.
 * User: nhans
 * Date: 09-10-2017
 * Time: 11:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace JenkinsDemoTestSolution
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			addTwoInteger();
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void addTwoInteger()
		{
		
			int a =10;
			int b = 5;
			int c;
			c = a+b;
			
			
			
			
			System.Console.WriteLine(c);
		}
	}
}