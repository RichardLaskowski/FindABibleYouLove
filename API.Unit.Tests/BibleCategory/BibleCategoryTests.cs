using API.Endpoints.Bible;
using API.Unit.Tests.BibleCategory.Fakes;

using FindABibleYouLove.Contracts.Bible;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.Unit.Tests.BibleCategory;

public class BibleCategoryTests 
{
    [Fact]
    public async Task GetAllBibleCategories_ReturnsNotFound_WhenNoCategoriesExists()
    {
        // Arrange
        BibleCategoryEndpoint sut = new();
        BibleCategoryServiceFake bibleCategoryServiceFake = new BibleCategoryServiceFake(new List<BibleCategoryContract>());

        // Act

        IResult result = await sut.GetAllBibleCategoriesAsync(bibleCategoryServiceFake);

        // Assert
        Assert.IsType<NotFound>(result);
    }

    [Fact]
    public async Task GetAllBibleCategories_ReturnsOk_WhenCategoriesExists()
    {
        // Arrange
        BibleCategoryEndpoint sut = new();
        BibleCategoryServiceFake bibleCategoryServiceFake = new(new List<BibleCategoryContract>()
        {
            new BibleCategoryContract(Guid.NewGuid().ToString(), "Category", "Description"),
        });

        // Act

        IResult result = await sut.GetAllBibleCategoriesAsync(bibleCategoryServiceFake);

        // Assert
        Assert.IsType<Ok<IEnumerable<BibleCategoryContract>>>(result);
    }
}
