using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BartendBuddy.Models;

namespace BartendBuddy.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly BartendBuddy.Models.BartendBuddyContext _context;

        public IndexModel(BartendBuddy.Models.BartendBuddyContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Orders.ToListAsync();
        }
    }
}
