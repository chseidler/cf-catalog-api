using Moq;

namespace UnitTests.Application.CreateCategory;

public class CreateCategoryTest
{
    [Fact(DisplayName = nameof(CreateCategory))]
    [Trait("Application", "CreateCategory - Use Cases")]
    public void CreateCategory()
    {
        var repositoryMock = new Mock<ICategoryRepository>();
        var unitOfWorkMock = new Mock<IUnitOfWork>();
        var useCase = new CreateCategory(repositoryMock.Object, unitOfWorkMock.Object);
    }
}