using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Cover;

public record CoverDesignContract<TType>(
    TType CoverDesignID,
    string DesignName)
    : BaseContract<TType>(CoverDesignID) where TType : class;
