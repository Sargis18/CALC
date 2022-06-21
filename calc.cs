using System;

public class Program
        {
public static void Main()
                {
Console.WriteLine("Enter number1:");
float n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter action:");
string act = Console.ReadLine();
Console.WriteLine("Enter number2:");
float n2 = Convert.ToInt32(Console.ReadLine());
	
	if(act != "+" && act != "-" && act != "*" && act != "/")
        Console.Write("ERROR" + "\n" +"Your enter invalid action" + "\n");

        if (act == "+")
        Console.Write("Answer" + "\n" + (n1 + n2) + "\n");

        if (act == "*")
        Console.Write("Answer" + "\n" + (n1 * n2) + "\n");

        if (act == "-")
        Console.Write("Answer" + "\n" + (n1 - n2) + "\n");

        if (act == "/")
        Console.Write("Answer" + "\n" + (n1 / n2) + "\n");
                }
        }