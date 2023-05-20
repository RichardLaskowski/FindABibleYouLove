using API.Endpoints.Bible;
using API.Unit.Tests.Fakes;
using FindABibleYouLove.Contracts.Bible;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.Unit.Tests.BibleCategory;

public class CreateBibleCategoryTests
{
    [Fact]
    public async Task CreateBibleCategory_ReturnsCreated_WhenCreated()
    {
        // Arrange
        BibleCategoryEndpoint sut = new();
        BibleCategoryServiceFake bibleCategoryServiceFake = new(new List<BibleCategoryContract>());
        BibleCategoryContract bibleCategoryContract = new(Guid.NewGuid().ToString(), "Category", "Description");

        // Act
        IResult result = await sut.CreateBibleCategoryAsync(bibleCategoryContract, bibleCategoryServiceFake);

        // Assert
        Assert.IsType<Created<BibleCategoryContract>>(result);
    }
}
