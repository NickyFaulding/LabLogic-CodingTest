namespace LabLogic_CodingTest
{
    internal class Menu
    {
        public Menu()
        {
            rootFolder = new Folder("root");
            currentFolder = rootFolder;
        }

        public Folder GetRootFolder()
        {
            return rootFolder;
        }
        public Folder GetCurrentFolder()
        {
            return currentFolder;
        }
        public void AddFolder()
        {
            Console.Clear();
            Console.WriteLine("CURRENT FOLDER : {0}\n", currentFolder.Name);

            Console.WriteLine("enter name for new folder : ");
            string newFolderName = Console.ReadLine();
            currentFolder.AddFolder(new Folder(newFolderName));
            Console.WriteLine("New folder named {0} was created in {1}", newFolderName, currentFolder.Name);
        }
        public void AddItem()
        {
            Console.Clear();
            Console.WriteLine("CURRENT FOLDER : {0}\n", currentFolder.Name);

            Console.WriteLine("enter name for new item : ");
            string newItemName = Console.ReadLine();
            currentFolder.AddItem(new Folder(newItemName));
            Console.WriteLine("New item named {0} was created in {1}", newItemName, currentFolder.Name);
        }
        public void DeleteFolder()
        {
            Console.Clear();
            Console.WriteLine("CURRENT FOLDER : {0}\n", currentFolder.Name);

            currentFolder.DisplayFolders();
            if (currentFolder.FolderCount() > 0)
            {
                Console.WriteLine("enter number of folder to delete");
                int folderToDelete = Convert.ToInt32(Console.ReadLine());
                currentFolder.DeleteFolder(currentFolder.GetFolder(folderToDelete));
            }
        }
        public void DeleteItem()
        {
            Console.Clear();
            Console.WriteLine("CURRENT FOLDER : {0}\n", currentFolder.Name);

            currentFolder.DisplayItems();
            if (currentFolder.ItemCount() > 0)
            {
                Console.WriteLine("enter number of item to delete");
                int itemToDelete = Convert.ToInt32(Console.ReadLine());
                currentFolder.DeleteItem(currentFolder.GetItem(itemToDelete));
            }
        }
        public void MoveFolder()
        {
            Console.Clear();
            Console.WriteLine("CURRENT FOLDER : {0}\n", currentFolder.Name);

            currentFolder.DisplayFolders();

            if (currentFolder.FolderCount() > 0)
            {
                Console.WriteLine("enter number of folder to be moved : ");
                Folder folderToBeMoved = currentFolder.GetFolder(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("enter number of location to be moved to : ");
                Folder newLocation = currentFolder.GetFolder(Convert.ToInt32(Console.ReadLine()));

                newLocation.AddFolder(folderToBeMoved);
                currentFolder.DeleteFolder(folderToBeMoved);
            }
        }
        public void MoveItem()
        {
            Console.Clear();
            Console.WriteLine("CURRENT FOLDER : {0}\n", currentFolder.Name);

            if (currentFolder.ItemCount() > 0 && currentFolder.FolderCount() > 0)
            {
                currentFolder.DisplayAllContents();
                Console.WriteLine("enter number of item to be moved : ");
                Item itemToBeMoved = currentFolder.GetItem(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("enter number of location to be moved to : ");
                Folder newLocation = currentFolder.GetFolder(Convert.ToInt32(Console.ReadLine()));

                newLocation.AddItem(itemToBeMoved);
                currentFolder.DeleteItem(itemToBeMoved);
            }
            else
            {
                Console.WriteLine("Nowhere to move, add sub folders");
            }
        }
        public void ChangeSelectedFolder()
        {
            Console.Clear();
            Console.WriteLine("CURRENT FOLDER : {0}\n", currentFolder.Name);

            currentFolder.DisplayFolders();
            if (currentFolder.FolderCount() > 0)
            {
                Console.WriteLine("enter number of folder to be selected : ");
                int newSelected = Convert.ToInt32(Console.ReadLine());
                currentFolder = currentFolder.GetFolder(newSelected);
            }
        }
        public void DisplayContents()
        {
            currentFolder.DisplayAllContents();
        }
        public void DisplayOptions()
        {
            Console.WriteLine("CURRENT FOLDER : {0}\n", currentFolder.Name);

            Console.WriteLine("\t1. add folder");
            Console.WriteLine("\t2. add item");
            Console.WriteLine("\t3. delete folder");
            Console.WriteLine("\t4. delete item");
            Console.WriteLine("\t5. move folder");
            Console.WriteLine("\t6. move item");
            Console.WriteLine("\t7. change selected folder");
            Console.WriteLine("\t8. display tree");
            Console.WriteLine("\ts. search current folder");

            if (currentFolder != rootFolder)
            {
                Console.WriteLine("\n\t9. return to root");
            }
        }
        public void Search()
        {
            Console.Clear();
            Console.WriteLine("CURRENT FOLDER : {0}\n", currentFolder.Name);

            Console.WriteLine("enter search query : ");
            string query = Console.ReadLine();

            Console.WriteLine("Search Results for '{0}':\n", query);
            Folder found = rootFolder.Find(currentFolder, query);
        }
        public void ReturnToRoot()
        {
            if (currentFolder != rootFolder)
            {
                currentFolder = rootFolder;
            }
        }

        Folder rootFolder;
        Folder currentFolder;
    }
}
