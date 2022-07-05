namespace LabLogic_CodingTest
{
    internal class RootFolder : Folder
    {
        public RootFolder(string name) : base(name)
        {
            Console.WriteLine("Root folder {0} created.", name);
        }
    }
}
