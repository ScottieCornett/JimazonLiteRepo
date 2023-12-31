﻿using JimazonLite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JimazonLite.Data.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task Update(Category category);
    }
}
