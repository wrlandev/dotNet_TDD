using Domain.Entities;

namespace TodoSystem.Tests
{
    public class Tasks
    {
        [Fact]
        public void CreateTaskSuccessfully()
        {
            //Arrange
            var title = "task";
            var description = "description";
            var expirationDate = DateTime.Now;
            var priority = 1;
            var tags = new List<string> { "Teste1", "Teste2" };

            //Act
            var task = new TaskEntity(title, description, priority, tags, expirationDate);

            //Assert
            Assert.Equal(task.Title, title);
            Assert.Equal(task.Description, description);
            Assert.Equal(task.ExpirationDate, expirationDate);
        }
    }
}