using DotNetWithPostreSql.Data;
using DotNetWithPostreSql.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWithPostreSql.Controllers
{
    public class ItemController
    {

        private readonly AppDbContext _context;

        public ItemController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<Item> PostItem(Item item)
        {
            _context.Items.Add(item);
            await _context.SaveChangesAsync();

            return item;
        }
    }
}
