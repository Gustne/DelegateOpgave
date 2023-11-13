
using DelegateOpgave;

UiHelper uiHelper = new UiHelper();

RefToPrint print = new RefToPrint(PrintToConsole);

uiHelper.ReturnNumbers(78, print);

//PrintToConsole(test);

void PrintToConsole(List<int> talList)
{
	foreach (int interger in talList)
	{
        Console.WriteLine(interger);
    }
}


public delegate void RefToPrint(List<int> numbers);
