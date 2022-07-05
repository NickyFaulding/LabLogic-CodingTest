using LabLogic_CodingTest.Objects;

namespace LabLogic_CodingTest.Services
{
    public interface INodeService
    {
        public RootFolder CreateRoot(string name);
        public void AddNodeToFolder(Node node, Folder folder);
        public void DeleteNodeFromFolder(string nodeName, Folder folder);
        public void MoveNodeToFolder(Node node, Folder sourceFolder, Folder destinationFolder);
        public List<Node> Search(Folder folder, string query);
    }

    public class NodeService : INodeService
    {
        public RootFolder CreateRoot(string name)
        {
            RootFolder root = new RootFolder(name);

            return root;
        }

        public void AddNodeToFolder(Node node, Folder folder)
        {
            folder.folderContents.Add(node);
        }

        public void DeleteNodeFromFolder(string nodeName, Folder folder)
        {
            folder.folderContents.RemoveAll(node => node.Name == nodeName);
        }

        public void MoveNodeToFolder(Node node, Folder sourceFolder, Folder destinationFolder)
        {
            AddNodeToFolder(node, destinationFolder);
            DeleteNodeFromFolder(node.Name, sourceFolder);
        }

        public List<Node> Search(Folder folder, string query)
        {
            List<Node> result = new List<Node>();

            result = folder.folderContents.Where(node => node.Name.Contains(query)).ToList();
            return result;
        }
    }
}