﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Sandbox.Shared;

namespace Sandbox.Facts
{
    public sealed class BusTable : ValueObject
    {
        //--------------------------------------------------
        public BusTable([NotNull] SeatParty seatParty)
        {
            this.SeatParty = seatParty ?? throw new ArgumentNullException(nameof(seatParty));
        }

        [NotNull] public SeatParty SeatParty { get; }

        //--------------------------------------------------
        protected override IEnumerable<object> GetEqualityComponents()
        {
            return new object[] {this.SeatParty};
        }
    }
}