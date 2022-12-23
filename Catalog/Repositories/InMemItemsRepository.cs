using System.Collections.Generic;
using Catalog.Entities;
using System;
using System.Linq;

namespace Catalog.Repositories
{
    public class InMemItemsRepository : IItemsRepository
    {
        private readonly List<Item> items = new()
         {
            new Item {Id= Guid.NewGuid(), Name="Potion", Price = 9, createdDate = DateTimeOffset.UtcNow },
            new Item {Id= Guid.NewGuid(), Name="Iron Sword", Price = 20, createdDate = DateTimeOffset.UtcNow },
            new Item {Id= Guid.NewGuid(), Name="Bronze Shield", Price = 18, createdDate = DateTimeOffset.UtcNow }
         };

   
        public IEnumerable<Item> GetItemsAsync()
        {
            return items;
        }

        public Item GetItemAsync(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }

        public void CreateItemAsync(Item item)
        {
            items.Add(item);
        }

        public void UpdateItemAsync(Item item)
        {
            var index = items.FindIndex(existingItem => existingItem.Id == item.Id );
            items[index] = item;
        }

        public void DeleteItemAsync(Guid id)
        {
         var index = items.FindIndex(existingItem => existingItem.Id == id );
         items.RemoveAt(index);
        }
    }


}