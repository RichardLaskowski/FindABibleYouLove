using System.Collections.Generic;
using Domain.Base.Classes.Contracts;

namespace FindABibleYouLove.Contracts.Ribbon;

public record RibbonDetailContract(
    string RibbonDetailId,
    IEnumerable<RibbonContract> Ribbons)
    : StringBaseContract(RibbonDetailId);