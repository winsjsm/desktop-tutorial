using System;
public class Program{
	public static void Main(){
		int ran_value;
		ran_value=Int32.Parse(Console.ReadLine());
		Console.WriteLine(fact(ran_value));
	}
	
	static int fact(int n){
		int factorial=1;
		for (int i = 1; i <= n; i++) {
    		 factorial  =factorial*i;
		}	
		return  factorial;
	}
	
}