using Domain.Base.Classes.Contracts;

namespace FindABibleYouLove.Contracts.Cover;

public record CoverColorContract(
    string CoverColorId,
    string ColorName)
    : StringBaseContract(CoverColorId);
