﻿using System.Collections.Generic;

public static class VatRates
{
    public static readonly Dictionary<VatCategory, decimal> Rates = new Dictionary<VatCategory, decimal>
    {
        { VatCategory.Standard, 0.16m },
        { VatCategory.ZeroRated, 0.00m },
        { VatCategory.Exempt, -1.00m } // -1 to denote no VAT applied for exempt items 
    };
}
