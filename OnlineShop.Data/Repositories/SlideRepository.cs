﻿using OnlineShop.Data.Infrastructure;
using OnlineShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repositories
{

    public interface ISlideRepository
    {

    }
    public class SlideRepository : RepositoryBase<Product>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
