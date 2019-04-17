using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repositories
{

    public interface IPageCategoryRepository
    {

    }
    public class PageCategoryRepository : RepositoryBase<Product>, IPageCategoryRepository
    {
        public PageCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
