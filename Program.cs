// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double firstNum = double.Parse(Console.ReadLine());
char operand = char.Parse(Console.ReadLine());
double secondNum = double.Parse(Console.ReadLine());
double result;

switch (operand)
{
	case '+':  
		result = firstNum + secondNum;
		Console.WriteLine("Result is: {0}", result);
		break;
	case '-': 
		result = firstNum - secondNum;
        Console.WriteLine("Result is: {0}", result); 
		break;
	case '*': 
		result = firstNum * secondNum; 
		Console.WriteLine("Result is: {0}", result);
        break;
	case '/': 
		result = firstNum / secondNum; 
		Console.WriteLine("Result is: {0}", result);
        break;
	default:
		Console.WriteLine("Invalid operand");
		break;
}
