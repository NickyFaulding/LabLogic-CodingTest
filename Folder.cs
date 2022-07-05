namespace LabLogic_CodingTest
{
    internal class Folder : Item
    {
        public Folder(string name) : base(name)
        {
            items = new List<Item>();
        }

        public void AddItem(string name)
        {
            items.Add(new Item(name));
            Console.WriteLine("item {0} added to {1}", name, Name);
        }

        public void AddFolder(string name)
        {
            items.Add(new Folder(name));
            Console.WriteLine("folder {0} added to {1}", name, Name);
        }

        public void DeleteItem(string itemName)
        {
            Item item = GetItemByName(itemName);

            if (item == null)
            {
                Console.WriteLine("{0} does not exist", itemName);
                return;
            }

            if ((item.GetType() != typeof(RootFolder)))//should not be possible but I wanted to make clear it can't happen.
            {
                items.Remove(item);
                Console.WriteLine("{0} deleted from {1}", itemName, Name);
            }
        }

        public void MoveItem(string itemName, string destinationName)
        {
            Item itemToBeMoved = GetItemByName(itemName);
            Folder destination = (Folder)GetItemByName(destinationName);

            if (itemToBeMoved == null)
            {
                Console.WriteLine("{0} does not exist", itemName);
                return;
            }

            if ((itemToBeMoved.GetType() != typeof(RootFolder)))//moving root should not be possible but I wanted to make clear it can't happen.
            {
                destination.items.Add(itemToBeMoved);
                items.Remove(itemToBeMoved);
                Console.WriteLine("{0} moved to {1}", itemName, destinationName);
            }
        }

        public Item GetItemByName(string name)
        {
            foreach (Item item in items)
            {
                if (item.Name == name)
                { return item; }
            }
            return null;
        }


        public List<Item> items { get; set; }
    }

}
