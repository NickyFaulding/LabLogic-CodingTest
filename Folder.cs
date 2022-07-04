namespace LabLogic_CodingTest
{
    internal class Folder : Item
    {
        public Folder(string name) : base(name)
        {
            items = new List<Item>();
            folders = new List<Folder>();

            Name = name;
        }

        public void AddItem(Item newItem)
        {
            items.Add(newItem);
        }

        public void AddFolder(Folder newFolder)
        {
            folders.Add(newFolder);
        }

        public void DeleteItem(Item item)
        {
            items.Remove(item);
        }

        public void DeleteFolder(Folder folder)
        {
            if (folder.Name != "root")
            {
                folders.Remove(folder);
            }
        }

        public int ItemCount()
        {
            return items.Count;
        }

        public int FolderCount()
        {
            return folders.Count;
        }

        public Item GetItem(int i)
        {
            return items[i];
        }

        public Folder GetFolder(int i)
        {
            return folders[i];
        }

        public void DisplayAllContents()
        {
            Console.WriteLine("Folders:");
            if (folders.Count > 0)
            {
                for (int i = 0; i < folders.Count; i++)
                {
                    Console.WriteLine("\t{0}. {1}", i, folders[i].Name);
                }
            }
            else
            {
                Console.WriteLine("\tNo folders.");
            }

            Console.WriteLine("Items:");
            if (items.Count > 0)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine("\t{0}. {1}", i, items[i].Name);
                }
            }
            else
            {
                Console.WriteLine("\tNo items.");
            }
        }

        public void DisplayFolders()
        {
            if (folders.Count > 0)
            {
                int count = 0;
                foreach (Folder folder in folders)
                {
                    Console.WriteLine("\t{0}. {1}", count, folder.Name);
                    count++;
                }
            }
            else
            {
                Console.WriteLine("No Subfolders in directory");
            }
        }

        public void DisplayItems()
        {
            if (items.Count > 0)
            {
                int count = 0;
                foreach (Item item in items)
                {
                    Console.WriteLine("\t{0}. {1}", count, item.Name);
                    count++;
                }
            }
            else
            {
                Console.WriteLine("No Items in directory");
            }
        }

        public Folder Find(Folder currentFolder, string query)
        {
            if (currentFolder == null)
            {
                return null;
            }

            if (currentFolder.Name.Contains(query))
            {
                Console.WriteLine(currentFolder.Name);
            }

            foreach (Item item in currentFolder.items)
            {
                if (item.Name.Contains(query))
                {
                    Console.WriteLine(item.Name);
                }
            }

            foreach (Folder folder in currentFolder.folders)
            {
                Folder found = Find(folder, query);
                if (found != null)
                {
                    return found;
                }
            }

            return null;
        }

        List<Folder> folders;
        List<Item> items;
    }
}
