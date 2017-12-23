using System;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class UserService: IUserService
    {
        private NewsContext _context;

        public UserService(NewsContext context)
        {
            _context = context;
        }

        public async Task<List<Users>> Get()
        {
            return await _context.Users.ToListAsync();
        }


        public async Task<List<Users>> GetByEmailID(string email)
        {
            Users objectUsers = await _context.Users.FirstOrDefaultAsync(userEmail => userEmail.Email == email);
            List<Users> product = new List<Users>();
            try
            {
                product.Add(objectUsers);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public async Task Post(Users item)
        {
            try
            {
                 _context.Users.Add(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}