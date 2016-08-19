using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using GameStore.Domain;
using GameStore.Domain.Concrete;

namespace GameStore.WebUI.Controllers
{
    public class GameController : Controller
    {
        private IGameRepository repository;
        public GameController(IGameRepository repo)
        {
            repository = repo;
        }
        public ViewResult List()
        {
            ///EFDbContext dbContext = new EFDbContext(); //new Model1();

            //Model1 dbContext = new Model1();
            //var query = dbContext.Games;

            //foreach (var game in query)
            //{
            //    Console.WriteLine("Name = {0} , Price = {1}",
            //                      game.Name, game.Price);
            //}

            //IEnumerable<Games> products = query.ToList();

            return View(repository.Games);
        }
    }
}