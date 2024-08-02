//namespace HomeWorks4
//{
//    internal class Calculator
//    {
//        public void Calculation(double num1, double num2)
//        {
//            Console.WriteLine("Emeliyyat novunu daxil edin (+, -, *, /): ");
//            char operation = Convert.ToChar(Console.ReadLine());

//            double result;

//            switch (operation)
//            {
//                case '+':
//                    result = num1 + num2;
//                    break;
//                case '-':
//                    result = num1 - num2;
//                    break;
//                case '*':
//                    result = num1 * num2;
//                    break;
//                case '/':
//                    if (num2 != 0)
//                    {
//                        result = num1 / num2;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Sifira bolmek olmaz");
//                        return;
//                    }
//                    break;
//                default:
//                    Console.WriteLine("Duzgun emeliyyat secin (+, -, *, /):");
//                    return;
//            }

//            Console.WriteLine("Netice: " + result);
//        }
//    }
//}