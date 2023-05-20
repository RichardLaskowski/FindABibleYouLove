using API.Endpoints.Bible;
using API.Unit.Tests.Fakes;

using FindABibleYouLove.Contracts.Bible;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.Unit.Tests.BibleFeature;

public class GetAllBibleFeaturesTests
{
    [Fact]
    public async Task GetAllBibleFeatures_ReturnsNotFound_WhenNoFeaturesExists()
    {
        // Arrange
        BibleFeatureEndpoint sut = new();
        BibleFeatureServiceFake bibleFeatureServiceFake = new BibleFeatureServiceFake(new List<BibleFeatureContract>());

        // Act

        IResult result = await sut.GetAllBibleFeaturesAsync(bibleFeatureServiceFake);

        // Assert
        Assert.IsType<NotFound>(result);
    }

    [Fact]
    public async Task GetAllBibleFeatures_ReturnsOk_WhenFeaturesExists()
    {
        // Arrange
        BibleFeatureEndpoint sut = new();
        BibleFeatureServiceFake bibleFeatureServiceFake = new(new List<BibleFeatureContract>()
        {
            new BibleFeatureContract(Guid.NewGuid().ToString(), "Feature"),
        });

        // Act

        IResult result = await sut.GetAllBibleFeaturesAsync(bibleFeatureServiceFake);

        // Assert
        Assert.IsType<Ok<IEnumerable<BibleFeatureContract>>>(result);
    }
}
