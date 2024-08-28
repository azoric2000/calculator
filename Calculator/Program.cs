using System;


class calculator {
     static void Main(){ 
       DisplayOptions();
    }

    static void DisplayOptions(){
        Console.WriteLine("Would you like to: ");
        Console.WriteLine("Add");
        Console.WriteLine("Subtract");
        Console.WriteLine("Multiply");
        Console.WriteLine("Divide");
        Console.WriteLine("Exit");
        string operation = Console.ReadLine();

        operation = operation.ToUpper();

        switch(operation) {
            case "ADD":
                doAdd();
                break;
            case "SUBTRACT":
                doSubtract();
                break;
            case "MULTIPLY":
                doMultiply();
                break;
            case "DIVIDE":
                doDivide();
                break;
            case "EXIT":
                doExit();
                break;
            default: 
                Console.WriteLine();
                Console.WriteLine("I did not understand that.");
                Console.WriteLine();
                DisplayOptions();
                break;
        }

    }

    static void doAdd(){
        Console.WriteLine();
        Console.WriteLine("Add");
        Console.WriteLine("Enter the first number ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number ");
        int  y = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"The Result is: {x + y}");
        Console.WriteLine();
        DisplayOptions();
    } 

    static void doSubtract(){
        Console.WriteLine();
        Console.WriteLine("Subtract");
        Console.WriteLine("Enter the first number ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number ");
        int  y = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"The Result is: {x - y}");
        Console.WriteLine();
        DisplayOptions();
    }

    static void doMultiply(){
        Console.WriteLine();
        Console.WriteLine("Multiply");
        Console.WriteLine("Enter the first number ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number ");
        int  y = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"The Result is: {x * y}");
        Console.WriteLine();
        DisplayOptions();
    }

    static void doDivide(){
        Console.WriteLine();
        Console.WriteLine("Add");
        Console.WriteLine("Enter the first number ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second number ");
        double  y = Convert.ToDouble(Console.ReadLine());

        if (y == 0 ){
            Console.WriteLine(" Only Chuck Norris can divide by zero!");
        }

        // try {
        //     double result = x / y;
        //     Console.WriteLine($"The Result is: {result}");
        // }   
        // catch(DivideByZeroException ex){
        //     Console.WriteLine(ex.Message);
        //     Console.WriteLine("Only Chuck Norris can divide by zero!");
        // }

        

        Console.WriteLine();
        DisplayOptions();
    }

    static void doExit(){
        Console.WriteLine();
        Console.WriteLine("Goodbye!");
    }
}