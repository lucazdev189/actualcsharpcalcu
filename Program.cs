Console.WriteLine("Enter First Number.");

double myNum1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Second Number. If Sqrt this will be disregarded.");

double myNum2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Operation.");

string? myOperation = Console.ReadLine();

double myAns;

switch (myOperation)
{
    case "+":
    myAns = myNum1+myNum2;
    Console.WriteLine("Its "+myAns);
    break;

    case "-":
    myAns = myNum1-myNum2;
    Console.WriteLine("Its "+myAns);
    break;

    case "*":
    myAns = myNum1*myNum2;
    Console.WriteLine("Its "+myAns);
    break;

    case "/":
    myAns = myNum1/myNum2;
    Console.WriteLine("Its "+myAns);
    break;

    case "sqrt":
    myAns = Math.Sqrt(myNum1);
    Console.WriteLine("Its "+myAns);
    break;

    default:
    Console.WriteLine("Wrong input");
    break;
}