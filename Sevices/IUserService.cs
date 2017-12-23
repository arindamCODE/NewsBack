using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Models;
using Microsoft.AspNetCore.Mvc;

namespace Services
{
    public interface IUserService
    {
        Task<List<Users>> Get();
        Task<List<Users>> GetByEmailID(string email);
        Task Post(Users item);
    }
}