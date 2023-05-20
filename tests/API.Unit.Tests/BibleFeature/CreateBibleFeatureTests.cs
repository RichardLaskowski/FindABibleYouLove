using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using API.Endpoints.Bible;
using API.Unit.Tests.Fakes;
using FindABibleYouLove.Contracts.Bible;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Http;

namespace API.Unit.Tests.BibleFeature;

public class CreateBibleFeatureTests
{
    [Fact]
    public async Task CreateBibleFeature_ReturnsCreated_WhenCreated()
    {
        // Arrange
        BibleFeatureEndpoint sut = new();
        BibleFeatureServiceFake bibleFeatureServiceFake = new(new List<BibleFeatureContract>());
        BibleFeatureContract bibleFeatureContract = new(Guid.NewGuid().ToString(), "Feature");

        // Act
        IResult result = await sut.CreateBibleFeatureAsync(bibleFeatureContract, bibleFeatureServiceFake);

        // Assert
        Assert.IsType<Created<BibleFeatureContract>>(result);
    }
}
