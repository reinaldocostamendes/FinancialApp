﻿using CashBook_Application.Service.Interface;
using CashBookData.Repository.Interface;
using CashBookDomain.Entity;
using CashBookDomain.ViewModels;
using Infrastructure.Entity;
using Infrastructure.Service;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CashBook_Application.Service
{
    public class CashBookService : ICashBookService
    {
        private readonly ICashBookRepository _cashBookRepository;

        public CashBookService(ICashBookRepository cashBookRepository)
        {
            _cashBookRepository = cashBookRepository;
        }

        public async Task<CashBook> AddCashBook(CashBook cashbook)
        {
            await _cashBookRepository.AddCashBook(cashbook);
            return cashbook;
        }

        public async Task<CashBookModel> GetAllCashBook(PageParameters pageParameters)
        {
            var cashbooks = await _cashBookRepository.GetAllCashBook(pageParameters);

            CashBookModel cbvm = new CashBookModel();

            var amount = cashbooks.Sum(p => p.Value);
            cbvm.Models = cashbooks;
            cbvm.Total = (decimal)amount;
            return cbvm;
        }

        public async Task<CashBook> GetCashBookByOriginId(Guid id)
        {
            return await _cashBookRepository.GetCashBookByOriginId(id);
        }

        public async Task<CashBook> GetCashBookById(Guid id)
        {
            return await _cashBookRepository.GetCashBookById(id);
        }

        public async Task<CashBook> PutCashBook(CashBook cashbook)
        {
            await _cashBookRepository.PutCashBook(cashbook);
            return cashbook;
        }
    }
}