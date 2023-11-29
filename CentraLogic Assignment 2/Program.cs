internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Dear, User welcome to our Task List Application!");
        Console.WriteLine("Please Select Below option for performing specific operation according to your choice \n");

        List<string> tasks = new List<string>();

        while (true)
        {
            try
            {
                Console.WriteLine("Task Operations: Menu");
                Console.WriteLine("Select: 1. For Create / Add Task operation");
                Console.WriteLine("Select: 2. For Read   / View Task operation");
                Console.WriteLine("Select: 3. For Update / Change Task operation");
                Console.WriteLine("Select: 4. For Delete / Remove Task operation");
                Console.WriteLine("Select: 5. For Exit");
                Console.WriteLine("Note: One Task At a Time \n");
                Console.Write("Enter Number specified to following Task Operation: ");

                int taskNo = int.Parse(Console.ReadLine());

                switch (taskNo)
                {
                    case 1:
                        Console.Write("Create / Add the Task you wanted to stored: ");
                        string addTask = Console.ReadLine();
                        tasks.Add(addTask);
                        Console.WriteLine("Your Task is Added Successfully :) ");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Reading / Viewing Stored Tasks of My Dear User ;) \n");
                        for (int i = 1; i <= tasks.Count; i++)
                        {
                            Console.WriteLine($"{i}: {tasks[i - 1]}");
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Write("Enter the index of Task which you wanted to change / Update:-) : ");
                        int indexNo = int.Parse(Console.ReadLine());

                        if (indexNo >= 1 && indexNo <= tasks.Count)
                        {
                            Console.Write("Updating / Changing  the Task you wanted to change ;-) : ");
                            string newTask = Console.ReadLine();
                            tasks[indexNo - 1] = newTask;
                            Console.WriteLine("Updating of Task is Successfully Done ('') ");
                        }
                        else
                        {
                            Console.WriteLine("Dear, User please enter Valid Index No. Again for operation :( ");
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Write("enter the index of Task which you wanted to Delete / Remove: ");
                        int deleteIndexNo = int.Parse(Console.ReadLine());
                        if (deleteIndexNo >= 0 && deleteIndexNo <= tasks.Count)
                        {
                            tasks.RemoveAt(deleteIndexNo - 1);
                            Console.WriteLine("Deletion / Removal of Task is successfully Done.");
                        }
                        else
                        {
                            Console.WriteLine("Dear, User please Enter Valid Index / No task is Available for deletion");
                        }
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("Dear, User you're Exiting from Task List App :_( , Have a Nice Day ");
                        return;
                        Console.WriteLine();

                    default:
                        Console.WriteLine("Invalid Choice");
                        Console.WriteLine("Dear, User Please Enter Valid Index Choice for better performance");
                        Console.WriteLine();
                        break;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Invalid option you have choose / Invalid Action performed, please enter valid option");
            }
        }
    }
}
