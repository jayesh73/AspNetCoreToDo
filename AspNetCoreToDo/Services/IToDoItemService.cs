using AspNetCoreToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreToDo.Services
{
    public interface IToDoItemService
    {
        Task<IEnumerable<ToDoItem>> GetIncompleteItemsAsync();
    }
}
