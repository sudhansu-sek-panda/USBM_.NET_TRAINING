namespace ConsoleApp1
{
    internal class Program: task1
    {
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            task2 obj2 = new task2();
            task3 obj3 = new task3();
            task4 obj4 = new task4();
            task5 obj5 = new task5();
            task6 obj6 = new task6();
            int choice;
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1 - Task (Even, Odd)");
            Console.WriteLine("2 - Task (Square, Cube)");
            Console.WriteLine("3 - Task (Sum of Odd)");
            Console.WriteLine("4 - Task (Compare String)");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice) {
                case 1:
            obj1.EvenOdd();
                    break;
                case 2:
            obj2.SquareQueue();
                    break;
                case 3:
                    obj3.SumOdd();
                    break;
                    case 4:
                        obj4.CompareString();
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    Console.WriteLine("Try again! ");
                    break;
        }



        }
    }
}
