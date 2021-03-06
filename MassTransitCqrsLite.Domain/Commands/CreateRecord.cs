﻿using MassTransit;
using System;

namespace MassTransitCqrsLite.Domain.Commands
{
    public interface CreateRecord : CorrelatedBy<Guid>
    {
        Guid Id { get; }
        int Index { get; }
    }
}
