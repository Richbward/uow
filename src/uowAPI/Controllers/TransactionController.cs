using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using uow.Models;
using uowAPI.Services;

namespace uow.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionsRepository _transactionsRepository;
        private readonly IMapper _mapper;

        public TransactionController(ITransactionsRepository transactionsRepository,
            IMapper mapper)
        {
            _transactionsRepository = transactionsRepository
                ?? throw new ArgumentNullException(nameof(transactionsRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public async Task<ActionResult> GetTransactions()
        {
            var transactions = await _transactionsRepository.GetTransactionsAsync();
            return Ok(transactions);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutTransactionItem(Guid id, [FromBody] TransactionModel transaction)
        {
            if (id != transaction.Id)
            {
                return BadRequest();
            }

            var transactionEntity = _mapper.Map<Entities.Transaction>(transaction);

            var returnValue = await _transactionsRepository.PutTransactionItemAsync(transactionEntity);

            return NoContent();
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<TransactionModel>> GetTransactionById(Guid Id)
        {
            var transaction = await _transactionsRepository.GetTransactionByIdAsync(Id);

            if (transaction == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(transaction);
            }
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult> PartialTransactionUpdate(Guid id, [FromBody] JsonPatchDocument<TransactionModel> patchDoc)
        {
            var transaction = await _transactionsRepository.GetTransactionByIdAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            var transactionToPatch = _mapper.Map<TransactionModel>(transaction);
            patchDoc.ApplyTo(transactionToPatch, ModelState);

            if (!TryValidateModel(transactionToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(transactionToPatch, transaction);

            _transactionsRepository.UpdateTransactionAsync(transaction);
            var result = await _transactionsRepository.SaveChangesAsync();

            //return NoContent();
            return Ok(transaction);
        }

        //[HttpGet("{plateNumber}")]
        //public ActionResult<TransactionModel> GetTransactionsByPlateNumber(string plateNumber)
        //{
        //    var vehicle = _context.Vehicles.Where(v => v.PlateNumber == plateNumber).FirstOrDefault();

        //    var transaction = _context.Transactions.Where(t => t.VehicleId == vehicle.Id
        //    && t.Exited == null).FirstOrDefault();

        //    if (transaction == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return transaction;
        //    }
        //}
    }
}