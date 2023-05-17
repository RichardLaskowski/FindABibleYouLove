using Application.Mappers.Bible;
using Application.Mappers.Cover;
using Application.Mappers.Ribbon;
using Application.Repositories.Bible;
using Application.Repositories.Cover;
using Application.Repositories.Ribbon;
using Application.Services.Bible;
using Application.Services.Cover;
using Application.Services.Ribbon;

using Infrastructure.Mappers.Bible;
using Infrastructure.Mappers.Cover;
using Infrastructure.Mappers.Ribbon;
using Infrastructure.Repositories.Bible;
using Infrastructure.Repositories.Cover;
using Infrastructure.Repositories.Ribbon;


namespace Microsoft.Extensions.DependencyInjection;
public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddRepositories();
        services.AddMappers();
        services.AddServices();

        return services;
    }

    private static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddTransient(typeof(IBibleService),              typeof(BibleService));
        services.AddTransient(typeof(IBibleCategoryService),      typeof(BibleCategoryService));
        services.AddTransient(typeof(IBibleFeatureService),       typeof(BibleFeatureService));
        services.AddTransient(typeof(IBibleFormatService),        typeof(BibleFormatService));
        services.AddTransient(typeof(IBibleTranslationService),   typeof(BibleTranslationService));

        services.AddTransient(typeof(ICoverService<>),              typeof(CoverService<>));
        services.AddTransient(typeof(ICoverColorService<>),         typeof(CoverColorService<>));
        services.AddTransient(typeof(ICoverDesignService<>),        typeof(CoverDesignService<>));
        services.AddTransient(typeof(ICoverMaterialService<>),      typeof(CoverMaterialService<>));

        services.AddTransient(typeof(IRibbonService<>),             typeof(RibbonService<>));
        services.AddTransient(typeof(IRibbonColorService<>),        typeof(RibbonColorService<>));
        services.AddTransient(typeof(IRibbonDetailService<>),       typeof(RibbonDetailService<>));
        services.AddTransient(typeof(IRibbonSizeService<>),         typeof(RibbonSizeService<>));

        return services;
    }

    private static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddTransient(typeof(IBibleRepository<string>),               typeof(BibleDictionaryRepository));
        services.AddTransient(typeof(IBibleCategoryRepository<string>),       typeof(BibleCategoryDictionaryRepository));
        services.AddTransient(typeof(IBibleFeatureRepository<string>),        typeof(BibleFeatureDictionaryRepository));
        services.AddTransient(typeof(IBibleFormatRepository<string>),         typeof(BibleFormatDictionaryRepository));
        services.AddTransient(typeof(IBibleTranslationRepository<string>),    typeof(BibleTranslationDictionaryRepository));

        services.AddTransient(typeof(ICoverRepository<>),               typeof(CoverDictionaryRepository<>));
        services.AddTransient(typeof(ICoverColorRepository<>),          typeof(CoverColorDictionaryRepository<>));
        services.AddTransient(typeof(ICoverDesignRepository<>),         typeof(CoverDesignDictionaryRepository<>));
        services.AddTransient(typeof(ICoverMaterialRepository<>),       typeof(CoverMaterialDictionaryRepository<>));

        services.AddTransient(typeof(IRibbonRepository<>),              typeof(RibbonDictionaryRepository<>));
        services.AddTransient(typeof(IRibbonColorRepository<>),         typeof(RibbonColorDictionaryRepository<>));
        services.AddTransient(typeof(IRibbonDetailRepository<>),        typeof(RibbonDetailDictionaryRepository<>));
        services.AddTransient(typeof(IRibbonSizeRepository<>),          typeof(RibbonSizeDictionaryRepository<>));

        return services;
    }
    private static IServiceCollection AddMappers(this IServiceCollection services)
    {
        services.AddTransient(typeof(IBibleMapper<string>),               typeof(BibleMapper));
        services.AddTransient(typeof(IBibleCategoryMapper<string>),       typeof(BibleCategoryMapper));
        services.AddTransient(typeof(IBibleFeatureMapper<string>),        typeof(BibleFeatureMapper));
        services.AddTransient(typeof(IBibleFormatMapper<string>),         typeof(BibleFormatMapper));
        services.AddTransient(typeof(IBibleTranslationMapper<>),    typeof(BibleTranslationMapper<>));

        services.AddTransient(typeof(ICoverMapper<>),               typeof(CoverMapper<>));
        services.AddTransient(typeof(ICoverColorMapper<>),          typeof(CoverColorMapper<>));
        services.AddTransient(typeof(ICoverDesignMapper<>),         typeof(CoverDesignMapper<>));
        services.AddTransient(typeof(ICoverMaterialMapper<>),       typeof(CoverMaterialMapper<>));

        services.AddTransient(typeof(IRibbonMapper<>),              typeof(RibbonMapper<>));
        services.AddTransient(typeof(IRibbonColorMapper<>),         typeof(RibbonColorMapper<>));
        services.AddTransient(typeof(IRibbonDetailMapper<>),        typeof(RibbonDetailMapper<>));
        services.AddTransient(typeof(IRibbonSizeMapper<>),          typeof(RibbonSizeMapper<>));

        return services;
    }
}
