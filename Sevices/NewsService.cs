using System;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class NewsService: INewsService
    {
        private NewsContext _context;

        public NewsService(NewsContext context)
        {
            _context = context;
        }

        public async Task<List<News>> Get()
        {
            return await _context.News.ToListAsync();
        }

        public async Task<List<News>> GetBySource(string source)
        {
            //var objectNews =  _context.News.Where(p => p.Source.ToUpper().Contains(source.ToUpper()));
            //News objectNews = _context.News.Where(p => p.Source.ToUpper().Contains(source.ToUpper()));
            News objectNews = await _context.News.FirstOrDefaultAsync(pi => pi.Source  == source);
            List<News> product = new List<News>();
            try
            {
                product.Add(objectNews);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

    }
}