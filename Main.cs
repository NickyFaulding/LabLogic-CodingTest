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

            RootFolder root = folderService.CreateRoot("DATA");

            Folder itemsFolder = new Folder("Items");
            Item item = new Item("item.txt");

            folderService.AddNodeToFolder(itemsFolder, root);
            folderService.AddNodeToFolder(item, root);

            folderService.MoveNodeToFolder(item, root, itemsFolder);

            folderService.DeleteNodeFromFolder("item.txt", itemsFolder);
        }
    }
}