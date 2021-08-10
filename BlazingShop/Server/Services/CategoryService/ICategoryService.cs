﻿using BlazingShop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task <List<Category>> GetCategory();
        Task<Category> GetCategoryByUri(string CategoryUri);
    }
}
