﻿using AthensLibrary.Model.DataTransferObjects.CategoryControllerDTO;
using AthensLibrary.Model.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AthensLibrary.Service.Interface
{
    public interface ICategoryService
    {
        Task<IEnumerable<Book>> GetAllBooksByCategory();
        IEnumerable<CategoryDto> GetCategories();
        Category GetCategoryByName(string name);
        CategoryDto GetCategoryById(Guid id);
        Task<(bool, string)> AddCategory(CategoryCreationDTO category);
        Task<(bool, string)> Delete(Guid id);
    }
}
