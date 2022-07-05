namespace LabLogic_CodingTest.Objects
{
    public class Folder : Node
    {
        public Folder(string name) : base(name)
        {
            folderContents = new List<Node>();
        }
        public List<Node> folderContents { get; set; }
    }
}