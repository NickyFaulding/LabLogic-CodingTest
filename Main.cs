using LabLogic_CodingTest.Objects;
using LabLogic_CodingTest.Services;

namespace LabLogic_CodingTest
{
    class Program
    {
        static void Main()
        {
            //instantiate folder service
            NodeService folderService = new NodeService();

            //instantiate the root and all the other nodes that we can use.
            RootFolder root = folderService.CreateRoot("DATA");

            Folder itemsFolder = new Folder("Items");
            Folder itemsSubFolder = new Folder("More Items");

            Item item = new Item("item.txt");
            Item itemTwo = new Item("item2.txt");
            Item itemThree = new Item("item3.txt");
            Item itemRandom = new Item("random.txt");

            //using the folder service to manipulate the nodes we created above
            folderService.AddNodeToFolder(itemsFolder, root);
            folderService.AddNodeToFolder(item, root);

            folderService.AddNodeToFolder(itemsSubFolder, itemsFolder);

            folderService.MoveNodeToFolder(item, root, itemsFolder);

            folderService.DeleteNodeFromFolder("item.txt", itemsFolder);


            folderService.AddNodeToFolder(item, itemsFolder);
            folderService.AddNodeToFolder(itemTwo, itemsFolder);
            folderService.AddNodeToFolder(itemThree, itemsFolder);

            folderService.AddNodeToFolder(itemRandom, itemsFolder);

            folderService.SearchFolder(itemsFolder, "item"); //returns a list of the nodes that have "item" in the name.

        }
    }
}