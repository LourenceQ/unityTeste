﻿using Microsoft.AspNetCore.Mvc;

namespace EcommerceBlazorWebApi.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : Controller
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<IReadOnlyList<Category>>>> GetCategories()
    {
        var result = await _categoryService.GetCategories();

        return Ok(result);   
    }
}
