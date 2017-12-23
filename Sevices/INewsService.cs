using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Models;
using Microsoft.AspNetCore.Mvc;

namespace Services
{
    public interface INewsService
    {
        Task<List<News>> Get();
        Task<List<News>> GetBySource(string source);
    }
}