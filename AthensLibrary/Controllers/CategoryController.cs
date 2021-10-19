﻿/*using AthensLibrary.Data.Interface;
using AthensLibrary.Model.DataTransferObjects.CategoryControllerDTO;
using AthensLibrary.Model.Entities;
using AthensLibrary.Service.Interface;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AthensLibrary.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        private readonly IServiceFactory _serviceFactory;

        public CategoryController(IUnitofWork unitofWork, IMapper mapper, IServiceFactory serviceFactory, ICategoryService categoryService)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
            _serviceFactory = serviceFactory;
            _categoryService = categoryService;
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            var categoryEntity = _mapper.Map<Category>(category);
            _categoryService.AddCategory(categoryEntity);
            _unitofWork.SaveChanges();
            return Ok("Category created Successfully");

        }

        [HttpGet("Id/{id}")]
        public IActionResult GetCategoryById(Guid Id)
        {
            var category = _categoryService.GetCategoryById(Id);
            var categoryDto = _mapper.Map<CategoryDto>(category);
            return Ok(categoryDto);
        }

        [HttpGet("categoryname/{name}")]
        public IActionResult GetCategoryByName(string name)
        {
            var category = _categoryService.GetCategoryByName(name);
            var categoryDto = _mapper.Map<CategoryDto>(category);
            return Ok(categoryDto);
        }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var category = _categoryService.GetCategories();
            return Ok(category);
        }
    }
}
*/