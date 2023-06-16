using Levva.Newbies.Coins.Logic.Dtos;
using Levva.Newbies.Coins.Logic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Levva.Newbies.Coins.Controllers
{
    [Route("api/transaction")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _service;
        private readonly ICategoryService _categoryService;
        public TransactionController(ITransactionService service, ICategoryService categoryService)
        {
            _service = service;
            _categoryService = categoryService;
        }

        [HttpPost]
        public ActionResult<TransactionDto> Create(CreateTransactionDto transaction)
        {
            var userId = User.Identity.Name;
            var category = _categoryService.Get(transaction.CategoryId);
            var transactionCreated = _service.Create(Convert.ToInt32(userId),transaction);
            transactionCreated.Category = category;
            return Created("", transactionCreated);
        }

        [HttpGet("{id}")]
        public ActionResult<TransactionDto> Get(int id)
        {
            return _service.Get(id);
        }

        [HttpGet]
        public ActionResult<List<TransactionDto>> GetAll()
        {
            return _service.GetAll();
        }

        [HttpPut]
        public IActionResult Update(TransactionDto transaction)
        {
            _service.Update(transaction);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Ok();
        }
    }
}
