namespace LabLogic_CodingTest.Objects
{
    public abstract class Node
    {
        public string Name { get; set; }

        public Node(string name)
        {
            Name = name;
        }
    }
}