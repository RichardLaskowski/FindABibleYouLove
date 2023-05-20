using Application.Mappers.Bible;
using Application.Repositories.Bible;
using Application.Services.Bible;
using FindABibleYouLove.Contracts.Bible;
using Infrastructure.Mappers.Bible;
using Infrastructure.Repositories.Bible;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace API.Endpoints.Bible;

public class BibleFeatureEndpoint : IEndpoint
{
    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet(pattern: "bibles/features", handler: GetAllBibleFeaturesAsync)
            .WithName("GetAllBibleFeatures");

        app.MapPost(pattern: "bibles/features", handler: CreateBibleFeatureAsync)
            .WithName("CreateBibleFeature");
    }

    #region Handlers

    internal async Task<IResult> GetAllBibleFeaturesAsync(IBibleFeatureService bibleFeatureService)
    {
        try
        {
            IEnumerable<BibleFeatureContract> bibleFeatures = await bibleFeatureService.GetAllAsync();

            return bibleFeatures.Any()
                ? TypedResults.Ok<IEnumerable<BibleFeatureContract>>(bibleFeatures)
                : TypedResults.NotFound();
        }
        catch (Exception e)
        {
            return TypedResults.Problem(e.ToString());
        }
    }

    internal async Task<IResult> CreateBibleFeatureAsync(
        [FromBody] BibleFeatureContract bibleFeatureContract,
        IBibleFeatureService bibleFeatureService)
    {
        try
        {
            string bibleFeatureId = await bibleFeatureService.CreateAsync(bibleFeatureContract);

            return TypedResults.Created($"bibles/features/{bibleFeatureId})", bibleFeatureContract);
        }
        catch (Exception e)
        {
            return TypedResults.Problem(e.ToString());
        }
    }

    #endregion Handlers

    public void DefineServices(IServiceCollection services)
    {
        services.AddSingleton<IBibleFeatureService, BibleFeatureService>();
        services.AddSingleton<IBibleFeatureRepository, BibleFeatureFileRepository>();
        services.AddSingleton<IBibleFeatureMapper, BibleFeatureMapper>();
    }
}