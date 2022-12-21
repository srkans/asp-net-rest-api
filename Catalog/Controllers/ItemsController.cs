using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using System.Collections.Generic;
using Catalog.Entities;
using System;

namespace Catalog.Controllers
{
    
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository;

        public ItemsController(IItemsRepository repository) 
        {
            this.repository = repository;
        }
        // GET /items
        [HttpGet]
        public IEnumerable<Item> GetItems() 
        {
            var items = repository.GetItems();
            return items;
        }

        //GET /items/{id}
        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if(item == null) 
            {
                return NotFound();
            }

            return item;
        }

    }
    
}