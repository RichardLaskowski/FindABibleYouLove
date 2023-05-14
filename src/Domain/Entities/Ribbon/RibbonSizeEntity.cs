﻿using Domain.Common.Classes;

namespace Domain.Entities.Ribbon;

public class RibbonSizeEntity<TType> : BaseEntity<TType> where TType : class
{
    public TType? RibbonSizeID => Id;
    public decimal RibbonSize { get; set; }
}
