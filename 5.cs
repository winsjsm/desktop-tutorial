using System;
using System.Collections.Generic;					

public class Program{
		public static void Main(string[] args){

            String str = Console.ReadLine();
             Console.WriteLine((BracketCheck(str))?"ПСП !":"Не ПСП !"); //вызов статического метода
            Console.ReadLine();

        }

        static bool BracketCheck(string checkStr){
            var bracketStack = new Stack<char>(); //в этой задаче удобно использовать структуру стека, чтобы "запоминать" последовательность вызова скобок
			foreach (var char1 in checkStr){

                if (char1 == '(' || char1 == '{' || char1 == '['){
                    bracketStack.Push(char1); //добавляем открывающие скобки в стек
					continue;
                }

                if (char1 != ')' && char1 != '}' && char1 != ']') continue;
				char currentChar;
					if (bracketStack.Count > 0) currentChar = bracketStack.Pop();  //если стек не пуст, возвращаем и удаляем его последний элемент
				else
					return false; //в противном случае нарушен баланс скобок

                switch (currentChar)//проверка, соответствует ли текущая закрывающая скобка последней в очереди открывающей скобке
				{case '(':
					if (char1 == ')') continue;
					
				 	else return false;

                case '{':
					if (char1 == '}') continue;
					else return false;
				 case '[':
					if (char1 == ']') continue;
					else return false;
                }
            }
            return bracketStack.Count == 0; //если стек в итоге опустел, то скобок попарное количество
        }
    }



