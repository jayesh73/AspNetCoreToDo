using AspNetCoreToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreToDo.Services
{
    public class FakeToDoItemService: IToDoItemService
    {
        public Task<IEnumerable<ToDoItem>> GetIncompleteItemsAsync()
        {
            IEnumerable<ToDoItem> items = new[]
            {
                new ToDoItem
                {
                    Title = "Learn Asp .Net Core",
                    DueAt = DateTimeOffset.Now.AddDays(1)
                },
                new ToDoItem
                {
                    Title= "Build awesome apps",
                    DueAt = DateTimeOffset.Now.AddDays(2)
                }
            };

            return Task.FromResult(items);
            
            // throw new NotImplementedException();
        }
        
    }
}
