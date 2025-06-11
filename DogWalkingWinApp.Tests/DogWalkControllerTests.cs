using DogWalkingWinApp.Models;
using DogWalkingWinApp.Repositories;
using DogWalkingWinApp.ViewModel;
using Moq;

namespace DogWalkingWinApp.Tests
{
    public class DogWalkControllerTests
    {
        [Fact]
        public void Search_CallsRepositoryAndUpdatesListView()
        {
            // Arrange
            var mockView = new Mock<IDogWalkView>();
            var mockListView = new Mock<IDogWalkListView>();
            var mockRepo = new Mock<IDogWalkRepository>();

            var criteria = new SearchCriteria("B", null);
            var expectedWalks = new List<DogWalk> { new DogWalk { ClientName = "Bob", DogName = "Rex" } };

            mockRepo.Setup(r => r.Search(criteria)).Returns(expectedWalks);

            var controller = new DogWalkController(mockView.Object, mockListView.Object, mockRepo.Object);

            // Act
            controller.Search(criteria);

            // Assert
            mockRepo.Verify(r => r.Search(criteria), Times.Once);
            mockListView.Verify(v => v.Show(expectedWalks), Times.Once);
        }

        [Fact]
        public void Delete_CallsDogWalkViewDelete()
        {
            // Arrange
            var mockView = new Mock<IDogWalkView>();
            var mockListView = new Mock<IDogWalkListView>();
            var mockRepo = new Mock<IDogWalkRepository>();

            var controller = new DogWalkController(mockView.Object, mockListView.Object, mockRepo.Object);

            // Act
            controller.Delete();

            // Assert
            mockView.Verify(v => v.Delete(), Times.Once);
        }

        [Fact]
        public void New_CallsDogWalkViewNew()
        {
            // Arrange
            var mockView = new Mock<IDogWalkView>();
            var mockListView = new Mock<IDogWalkListView>();
            var mockRepo = new Mock<IDogWalkRepository>();

            var controller = new DogWalkController(mockView.Object, mockListView.Object, mockRepo.Object);

            // Act
            controller.New();

            // Assert
            mockView.Verify(v => v.New(), Times.Once);
        }

        [Fact]
        public void Save_CallsDogWalkViewSave()
        {
            // Arrange
            var mockView = new Mock<IDogWalkView>();
            var mockListView = new Mock<IDogWalkListView>();
            var mockRepo = new Mock<IDogWalkRepository>();

            var controller = new DogWalkController(mockView.Object, mockListView.Object, mockRepo.Object);

            // Act
            controller.Save();

            // Assert
            mockView.Verify(v => v.Save(), Times.Once);
        }

        [Fact]
        public void Show_CallsRepositoryAndUpdatesListView()
        {
            // Arrange
            var mockView = new Mock<IDogWalkView>();
            var mockListView = new Mock<IDogWalkListView>();
            var mockRepo = new Mock<IDogWalkRepository>();

            var expectedWalks = new List<DogWalk> { new DogWalk { ClientName = "Bob", DogName = "Rex" } };

            mockRepo.Setup(r => r.GetAll()).Returns(expectedWalks);

            var controller = new DogWalkController(mockView.Object, mockListView.Object, mockRepo.Object);

            // Act
            controller.Show();

            // Assert
            mockRepo.Verify(r => r.GetAll(), Times.Once);
            mockListView.Verify(v => v.Show(expectedWalks), Times.Once);
        }
    }
}