﻿using CashBookDomain.DTO;
using CashBookDomain.Entity;
using CashBookDomain.ViewModels;
using Infrastructure.Entity;
using System;
using System.Threading.Tasks;

namespace CashBook_Application.Application.Interface
{
    public interface ICashBookApplication
    {
        Task<CashBook> AddCashBook(CashBookDTO cashbook);

        Task<CashBookModel> GetAllCashBook(PageParameters pageParameters);

        Task<CashBook> GetCashBookOriginId(Guid Id);

        Task<CashBook> GetCashBookById(Guid id);

        Task<CashBook> PutCashBook(CashBookDTO cashbook);
    }
}