using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreToDo.Models;
using AspNetCoreToDo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreToDo.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IToDoItemService _toDoItemService;

        public ToDoController(IToDoItemService toDoItemService)
        {
            _toDoItemService = toDoItemService;
        }

        public async Task<IActionResult> Index()
        {
            var toDoItems = await _toDoItemService.GetIncompleteItemsAsync();

            var model = new ToDoViewModel()
            {
                Items = toDoItems
            };
            
            return View(model);
        }
    }
}