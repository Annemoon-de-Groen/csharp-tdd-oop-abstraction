using exercise.main;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;

namespace exercise.tests;

[TestFixture]
public class CoreTests
{
    
    [Test]
    public void Test()
    {
        TodoItem todoItem = new TodoItem("Title", "Detail");
        todoItem.Status = Status.Done;
        Assert.That(todoItem.Status, Is.EqualTo(Status.Done));
    }
}