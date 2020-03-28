using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Talabat.Blog.Models;

namespace Talabat.Blog.Pages.Articles
{
    public class indexModel : PageModel
    {
        private  ApplicationDbContext Db { get; set; }

        public IEnumerable<Article> Articles { get; set; }
        public indexModel(ApplicationDbContext db)
        {
            Db = db;
        }
        public async Task OnGet()
        {
            Articles = await Db.Article.ToListAsync();
        }
    }
}