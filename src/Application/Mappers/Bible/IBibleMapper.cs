﻿using Domain.Base.Interfaces.Mappers;
using Domain.Entities.Bible;

using FindABibleYouLove.Contracts.Bible;

namespace Application.Mappers.Bible;

public interface IBibleMapper : IStringBaseMapper<BibleEntity, BibleContract> { }
