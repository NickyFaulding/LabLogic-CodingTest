namespace LabLogic_CodingTest
{
    internal class Folder : Item
    {
        public Folder(string name) : base(name)
        {
            items = new List<Item>();
        }

        public void AddItem(Item newItem)
        {
            items.Add(newItem);
        }

        public void AddFolder(Folder newFolder)
        {
            items.Add(newFolder);
        }

        public void DeleteItem(Item item)
        {
            if (item.GetType() != typeof(RootItem))
            {
                items.Remove(item);
            }
        }

        public List<Item> Search(string query)
        {
            List<Item> searchResults = new List<Item>();

            foreach (Item item in items)
            {
                if (item.Name.Contains(query))
                {
                    searchResults.Add(item);
                }
            }
            //functionality not doing exactly what is desired... sub folders need to be searched.
            return searchResults;
        }

        List<Item> items;
    }

}
