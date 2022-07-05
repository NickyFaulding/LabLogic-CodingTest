namespace LabLogic_CodingTest
{
    class Program
    {
        static void Main()
        {
            //create root folder
            RootFolder root = new RootFolder("DATA");

            //create some folders
            Folder DBBackups = new Folder("DB Backups");
            Folder Documentation = new Folder("Documentation");
            Folder GIT = new Folder("GIT");

            Folder documentation = new Folder("documentation");

            root.AddItem(DBBackups);
            root.AddItem(Documentation);
            root.AddItem(GIT);

            Documentation.AddItem(documentation);

            GIT.AddItem(".git", true);
            GIT.AddItem(".vs", true);
            GIT.AddItem("trunk", true);

            Documentation.DeleteItem(documentation);

            root.MoveItem(Documentation, DBBackups);
        }

    }
}