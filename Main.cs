namespace LabLogic_CodingTest
{
    class Program
    {
        static void Main()
        {
            RootFolder root = new RootFolder("DATA");

            root.AddFolder("DB Backups");
            root.AddFolder("Documentation");
            root.AddFolder("GIT");

            Folder documentation = (Folder)root.GetItemByName("Documentation");
            Folder git = (Folder)root.GetItemByName("GIT");

            documentation.AddFolder("documentation");

            git.AddFolder(".git");
            git.AddFolder(".vs");
            git.AddFolder("trunk");

            documentation.DeleteItem("documentation");

            root.MoveItem("Documentation", "DB Backups");
        }

    }
}