using System;

namespace HelloWorld {
    class Program {
        static void Main (string[] args) {
            // enter from the keyboard
            Console.Write ("Enter number 1: ");
            string num1 = Console.ReadLine ();
            Console.Write ("Enter number 2: ");
            string num2 = Console.ReadLine ();
            int ss = 0;

            try {
                //if...else
                if (double.Parse (num1) < double.Parse (num2)) {
                    ss = 1;
                } else if (double.Parse (num1) == double.Parse (num2)) {
                    ss = 2;
                } else if (double.Parse (num1) > double.Parse (num2)) {
                    ss = 3;
                } else {
                    ss = 0;
                }
            } catch (System.Exception) {
                //num1 or num 2 error message is not a number
                Console.WriteLine ("Wrong format, number 1 and number 2 must be number!!!");
            }

            //switch...case
            switch (ss) {
                case 1:
                    Console.WriteLine (num1 + " < " + num2);
                    Dayso (double.Parse (num1), double.Parse (num2));
                    break;
                case 2:
                    Console.WriteLine (num1 + " = " + num2);
                    break;
                case 3:
                    Console.WriteLine (num1 + " > " + num2);
                    Dayso (double.Parse (num2), double.Parse (num1));
                    break;
            }
        }
        static void Dayso (double num1, double num2) {
            string ds = "[" + num1 + ", " + num2 + "]: ";

            //for
            for (double i = num1; i <= num2; i++) {
                ds += (i + " ");
            }
            Console.WriteLine (ds);
        }
    }

}