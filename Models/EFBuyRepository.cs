using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class EFBuyRepository : IBuyRepository
    {
        private BookstoreContext context;

        public EFBuyRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Buy> Buy => context.Buy.Include(x => x.Lines);

        public void SaveBuy(Buy buy)
        {
            throw new NotImplementedException();
        }
    }
}
