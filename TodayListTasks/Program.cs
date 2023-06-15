// See https://aka.ms/new-console-template for more information


//_________________________________________________________________________________________________________________________________________________________


List<string> list = new List<string>();
string Chooose;
string add;
do
{
    Console.WriteLine("1) To add a task to list : ");
    Console.WriteLine("2) To display a task to list : ");
    Console.WriteLine("3) To remove  a task to list : ");
    Console.WriteLine("enter number of task....");
    Chooose = Console.ReadLine();
    switch (Chooose)
    {
        case "1":
            Console.WriteLine("enter the name of task ");
            add = Console.ReadLine();
            list.Add(add);
            break;
        case "2":
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i} ) {list[i]}");
            }
            break;
        case "3":
            Console.WriteLine("enter number of task to remove ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (list.Count == 0)
                Console.WriteLine("empty list ");
            else
                list.Remove(list[num]);
            break;
        default:
            Console.WriteLine("wrong choosing<<<<try again>>>");
            break;
    }
} while (Chooose != "4");
Console.ReadKey();
