﻿using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repositories
{

    public interface IProductTagRepository
    {

    }
    public class ProductTagRepository : RepositoryBase<Product>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
