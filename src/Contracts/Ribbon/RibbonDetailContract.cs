using System.Collections.Generic;

using Domain.Common.Classes;

namespace FindABibleYouLove.Contracts.Ribbon;

public record RibbonDetailContract<TType>(
    TType RibbonDetailID,
    IEnumerable<RibbonContract<TType>> Ribbons)
    : BaseContract<TType>(RibbonDetailID) where TType : class;