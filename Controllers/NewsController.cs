using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services;
using Models;
using Microsoft.EntityFrameworkCore;

namespace NewsBack.Controllers
{
    [Route("api/[controller]")]
    public class NewsController : Controller
    {
        private INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        //[Route("user/all")]
        public Task<List<News>> GetAll()
        {
            return _newsService.Get();
        }

        [HttpGet("{source}")]
        public Task<List<News>> GetSource(string source)
        {
            return _newsService.GetBySource(source);
        }

    }
}