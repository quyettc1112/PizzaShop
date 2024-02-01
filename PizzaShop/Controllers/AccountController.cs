using Microsoft.AspNetCore.Mvc;
using PZS.Service.DTO;
using PZS.Service.Service;

namespace PizzaShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly AccountService _service;

        public AccountController(AccountService service)
        {
            _service = service;
        }
    
       

        public async Task<ActionResult> Index()
        {
            var account = await _service.GetAccountAsync();
            return View(account);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(AccountDTO accountDto)
        {
            try
            {
                await _service.InsertAsync(accountDto);
                await _service.CompletedAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
