namespace LabLogic_CodingTest
{
    class LabLogic_CodingTest
    {
        static void Main()
        {
            Menu menu = new Menu();

            menu.GetRootFolder().AddItem(new Item("item one"));
            menu.GetRootFolder().AddItem(new Item("item two"));
            menu.GetRootFolder().AddItem(new Item("item three"));
            menu.GetRootFolder().AddItem(new Item("item four"));

            string option = "";
            while (option != "quit")
            {
                menu.DisplayOptions();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        menu.AddFolder();
                        break;

                    case "2":
                        menu.AddItem();
                        break;

                    case "3":
                        menu.DeleteFolder();
                        break;

                    case "4":
                        menu.DeleteItem();
                        break;

                    case "5":
                        menu.MoveFolder();
                        break;

                    case "6":
                        menu.MoveItem();
                        break;

                    case "7":
                        menu.ChangeSelectedFolder();
                        break;

                    case "8":
                        menu.DisplayContents();
                        break;

                    case "s":
                        menu.Search();
                        break;

                    case "9":
                        menu.ReturnToRoot();
                        break;
                }

                Console.WriteLine("\npress enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}