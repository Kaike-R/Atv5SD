using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TokenApi.Models;

namespace TokenApi.Repositories
{
    public class CustomerWishListRepository
    {
        List<CustomerWishlist> user = new List<CustomerWishlist>(){
            new CustomerWishlist {Id = "1", Nome = "fulano", Produto = "Caderno"},
            new CustomerWishlist {Id = "2", Nome = "ciclano", Produto = "Caneta"}
        };

        
        public CustomerWishlist Get(string Username,string Password)
        {
            return user.Where(usuario => usuario.Nome.ToLower() == Username.ToLower())
                .FirstOrDefault(); 
        }

        public List<CustomerWishlist> GetAll(){
            return user;
        }

    }
}