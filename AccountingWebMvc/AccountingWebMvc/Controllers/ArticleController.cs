using AccountingWebMvc.Bll.Dto;
using AccountingWebMvc.Bll.Interfaces;
using AccountingWebMvc.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;

namespace AccountingWebMvc.Controllers
{
    public class ArticleController : Controller
    {
        IAccountService service;

        public ArticleController(IAccountService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            IMapper mapper = Mapper.Instance;
            IEnumerable<ArticleDto> articlesDto = service.GetArticles();
            return View(mapper.Map<IEnumerable<ArticleDto>, List<ArticleViewModel>>(articlesDto));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ArticleCreateViewModel article)
        {
            if (ModelState.IsValid)
            {
                IMapper mapper = Mapper.Instance;
                ArticleDto articleDto = mapper.Map<ArticleCreateViewModel, ArticleDto>(article);
                service.CreateArticle(articleDto);
                return RedirectToAction("Index");
            }
            return View(article);
        }

        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ArticleDto articleDto = service.GetArticle(id.Value);
            if (articleDto == null)
            {
                return HttpNotFound();
            }

            IMapper mapper = Mapper.Instance;
            ArticleViewModel article = mapper.Map<ArticleDto, ArticleViewModel>(articleDto);

            return View(article);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ArticleViewModel article)
        {
            if (ModelState.IsValid)
            {
                IMapper mapper = Mapper.Instance;
                ArticleDto articleDto = mapper.Map<ArticleViewModel, ArticleDto>(article);

                service.EditArticle(articleDto);

                return RedirectToAction("Index");
            }

            return View(article);
        }

        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ArticleDto articleDto = service.GetArticle(id.Value);
            if (articleDto == null)
            {
                return HttpNotFound();
            }

            IMapper mapper = Mapper.Instance;
            ArticleViewModel article = mapper.Map<ArticleDto, ArticleViewModel>(articleDto);

            return View(article);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            service.DeleteArticle(id.Value);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Освобождение управляемых ресурсов.
            }
            base.Dispose(disposing);
        }
    }
}
