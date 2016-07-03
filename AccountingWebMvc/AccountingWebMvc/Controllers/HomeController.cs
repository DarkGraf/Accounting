using AccountingWebMvc.Bll.Dto;
using AccountingWebMvc.Bll.Interfaces;
using AccountingWebMvc.Models;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AccountingWebMvc.Controllers
{
    public class HomeController : Controller
    {
        IAccountService service;

        public HomeController(IAccountService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            IMapper mapper = Mapper.Instance;
            IEnumerable<OrderDto> ordersDto = service.GetOrders();
            return View(mapper.Map<IEnumerable<OrderDto>, List<OrderIndexViewModel>>(ordersDto));
        }

        public ActionResult Create()
        {
            OrderCreateViewModel article = new OrderCreateViewModel
            {
                Articles = service.GetArticles().ToDictionary(v => v.Id, v => v.Name)
            };
            return View(article);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderCreateViewModel order)
        {
            if (ModelState.IsValid)
            {
                IMapper mapper = Mapper.Instance;
                OrderDto orderDto = mapper.Map<OrderCreateViewModel, OrderDto>(order);
                service.CreateOrder(orderDto);
                return RedirectToAction("Index");
            }
            return Create();
        }
    }
}