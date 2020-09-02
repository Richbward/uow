using AutoMapper;
using System;
using Xunit;
using uow.Models;
using uow.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using uowAPI.Services;
using uow.Entities;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace uow.Tests
{
    public class TransactionTests : IDisposable
    {
        DbContextOptionsBuilder<Entities.uowContext> optionsBuilder;
        Entities.uowContext dbContext;
        TransactionsRepository repository;

        private readonly ITransactionsRepository _transactionsRepository;

        public TransactionTests()
        {
            optionsBuilder = new DbContextOptionsBuilder<Entities.uowContext>();
            optionsBuilder.UseInMemoryDatabase("UnitTestInMemBD");
            dbContext = new Entities.uowContext(optionsBuilder.Options);
            repository = new TransactionsRepository(dbContext);
        }

        [Fact]
        public void CanUpdateTransaction()
        {
            // Arrange
            var discount = 0.15M;
            //var testTransaction = _context.Transactions.Where(t => t.VehicleId == vehicleID).FirstOrDefault();

            var testTransaction = new Transaction
            {
                Id = new Guid("03AA95C3-A431-49BE-8699-28FA46CD4614"),
                GarageId = new Guid("0010525B-C826-4E51-A6F0-373B44A1C0AF"),
                VehicleId = new Guid("1098EE4B-C642-40FF-AF27-991F171AB755"),
                Entered = new DateTime(2020, 8, 24),
                Discount = discount
            };

            // Act
            testTransaction.Discount = discount;

            // Assert
            Assert.Equal(discount, testTransaction.Discount);
        }

        [Fact(Skip = "Skip for now")]
        public async Task GetTransactionItemsAsync()
        {
            // Arrange

            // Act
            var result = await repository.GetTransactionsAsync() as ObjectResult;
            var actualResult = result.Value;

            // Assert
            Assert.Empty((System.Collections.IEnumerable)actualResult);
        }

        [Fact]
        public async Task GetTransactionItemReturnsTheCorrectResouce()
        { //Arrange
            var transaction = new Entities.Transaction
            {
                Id = new Guid("DCF08158-F984-47E9-B082-13578527E25C"),
                GarageId = new Guid("70519DC7-F383-45F8-BEBB-37A7D41830DA"),
                VehicleId = new Guid("FAEC24B9-7CBD-4069-AD6B-497734DD5BD4"),
                Entered = new DateTime(2020, 8, 24, 8, 30, 00)
            };
            
            dbContext.Transactions.Add(transaction); 
            dbContext.SaveChanges(); 
            var transactionId = transaction.Id; 
            
            //Act 
            var result = await repository.GetTransactionByIdAsync(transactionId);
            var actualResult = result;
            
            //Assert
            Assert.Equal(transactionId, actualResult.Id); 
        }

        [Fact(Skip ="Change to call the controller - or change Assert")]
        public void PutTransactionItem_Returns204_WhenValidObject()
        {
            //Arrange 
            var transaction = new Entities.Transaction
            {
                Id = new Guid("94714114-D60F-43E2-AA16-6B8755E1EFA5"),
                GarageId = new Guid("F98FAC6E-5CBF-42BE-8CFB-1A22CCD224D1"),
                VehicleId = new Guid("ACB2D7FE-CDF2-4A7F-89E7-71F3B2D97352"),
                Entered = new DateTime(2020, 8, 24, 8, 30, 00)
            };

            dbContext.Transactions.Add(transaction);
            dbContext.SaveChanges();

            var transactionId = transaction.Id;
            transaction.Exited = new DateTime(2020, 8, 24, 11, 30, 00);
            transaction.Charge = 18.50M;

            //Act 
            var result = repository.PutTransactionItemAsync(transaction);

            //Assert 
            Assert.IsType<NoContentResult>(result);
        }

        public void Dispose()
        {
            optionsBuilder = null;
            foreach (var cmd in dbContext.Transactions)
            { 
                dbContext.Transactions.Remove(cmd); 
            }
            dbContext.SaveChanges();
            dbContext.Dispose(); 
            repository = null;
        }
    }
}
