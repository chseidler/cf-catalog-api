using DomainEntity = Domain.Entity;

namespace UnitTests.Domain.Entity.Category;

public class CategoryTestFixture
{
    public DomainEntity.Category GetValidCategory()
        => new("Category Name", "Category Description");
}

[CollectionDefinition(nameof(CategoryTestFixture))]
public class CateogryTestFixtureCollection : ICollectionFixture<CategoryTestFixture>
{ }