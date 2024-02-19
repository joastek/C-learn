
var todos = new List<string>();

bool shallExit = false;
while (!shallExit)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");


    var userChoice = Console.ReadLine();
    switch (userChoice)
    {
        case "E":
        case "e":
            shallExit = true;
            break;
        case "S":
        case "s":
            SeeAllTodos();
            break;
        case "A":
        case "a":
            AddTodo();
            break;
        case "R":
        case "r":
            RemoveTodo();
            break;

        default:
            Console.WriteLine("Invalid choice");
            break;

    }
}
Console.ReadKey();

void AddTodo()
{
    bool isValidDescrpiton = false;
    while (!isValidDescrpiton)
    {
        Console.WriteLine("enter the TODO description:");
        var descrpiton = Console.ReadLine();
        if (descrpiton == "")
        { Console.WriteLine("The description cannot be empty"); }
        else if (todos.Contains(descrpiton)) { Console.WriteLine("The description must be uniqe"); }
        else
        {
            isValidDescrpiton = true;
            todos.Add(descrpiton);
        }
    }
}


void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("No Todos have been added yet.");
    }
    else
    {
        for (int i = 0; i < todos.Count; i++)
        { Console.WriteLine($"{i + 1}.{todos[i]}"); }
    }
}


void RemoveTodo()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("No TODOs have benn added");
        return;
    }


    bool isIndexVaild = false;
    while (!isIndexVaild)
    {
        Console.WriteLine("Select the index of to do you want to remove");
        SeeAllTodos();
        var userInput = Console.ReadLine();
        if (userInput == "") { Console.WriteLine("Selected index cannot be empty"); continue; }
        if (int.TryParse(userInput, out int index) && index >= 1 && index <= todos.Count)
        { var todoToBeRemoved = todos[index - 1];
            var indexOfTodo = index - 1;
            var todoTobeRemoved = todos[indexOfTodo];
            todos.RemoveAt(index - 1);
            isIndexVaild = true;
            Console.WriteLine("TODO removed" + todoToBeRemoved);
        }
        else { Console.WriteLine("The given index is not valid"); }
    }
}