using System;
using System.Collections.Generic;					

public class Program{
    public static void Main(string[] args){
      
	  Console.Write("Введите текст: ");
      string [] sentence = Console.ReadLine().Split(' ', '.', ',', '?', '!', ':', ';' );
      List<string> strList = new List<string>();
      for (int i = 0; i < sentence.Length; i++){
        int includes = 0;
        strList.Add(sentence[i]);
          for (int j = 0; j < sentence.Length; j++)
            if (sentence[i] == sentence[j])
              includes++;
        if (includes==1)
          Console.Write(sentence[i]+" ");
      	 	}
	}
}