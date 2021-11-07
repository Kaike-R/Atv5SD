using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TokenApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace TokenApi.Repositories
{
    public class CustomerDemografics
    {
        List<CustomerDemo> user = new List<CustomerDemo>(){
            new CustomerDemo {Id = "1", Nome = "fulano", Endereco = "bairo do limoeiro"},
            new CustomerDemo {Id = "2", Nome = "ciclano", Endereco = "rua de baixo"}
        };

        
        public CustomerDemo Get(string Username)
        {
            return user.Where(usuario => 
                usuario.Nome.ToLower() == Username.ToLower())
                .FirstOrDefault(); 
        }

        public List<CustomerDemo> GetAll(){
            return user;
        }
    }
}