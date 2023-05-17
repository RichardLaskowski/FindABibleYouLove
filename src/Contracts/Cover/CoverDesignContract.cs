using Domain.Base.Classes.Contracts;

namespace FindABibleYouLove.Contracts.Cover;

public record CoverDesignContract(
    string CoverDesignId,
    string DesignName)
    : StringBaseContract(CoverDesignId);
