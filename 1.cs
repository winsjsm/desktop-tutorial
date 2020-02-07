using System;
public class Program{
	public static void Main(){
		
		int [] new_array = new int[10];
		int [] array = new int[] {10,12,253,555,33,11};
	
		new_array=Sort_array(array);
		Array.ForEach(new_array, Console.WriteLine);
	}
	static int[] Sort_array(int[] arr){
   		for (int i = 0; i < arr.Length; i++){
			for (int j = 0; j < arr.Length - 1; j++){
                    if (arr[j] > arr[j + 1]){
                        int z = arr[j];
                        arr[j]=arr[j+1];
                        arr[j + 1] = z;
                    }
             }
         }
		return arr;
	}
}