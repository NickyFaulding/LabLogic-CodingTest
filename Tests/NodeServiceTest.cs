using LabLogic_CodingTest.Objects;
using LabLogic_CodingTest.Services;
using NUnit.Framework;

namespace LabLogic_CodingTest.Tests
{
    [TestFixture]
    public class NodeServiceTest
    {
        //Attempted to create a unit test structure.

        private NodeService nodeService;

        [SetUp]
        public void SetUp()
        {
            nodeService = new NodeService();
        }

        [Test]
        public void AddNodeToFolder_Should_Add_To_Folder()
        {
            //arrange -set up scenario
            Item nodeToAdd = new Item("item");
            Folder targetFolder = new Folder("ItemFolder");

            //act -do it
            nodeService.AddNodeToFolder(nodeToAdd, targetFolder);

            //assert -check it worked
            Assert.That(targetFolder.folderContents.Contains(nodeToAdd));
        }
    }
}