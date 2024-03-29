﻿using StockData.Infrastructure.Repositories;

namespace StockData.Infrastructure.UnitOfWorks
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        ICompanyRepository Companies { get; set; }
        IStockPriceRepository StockPrices { get; set; }
    }
}