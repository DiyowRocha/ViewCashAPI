using Microsoft.AspNetCore.Mvc;
using ViewCashAPI.DTOs;
using ViewCashAPI.Interfaces;
using ViewCashAPI.ViewModels.Category;

namespace ViewCashAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpPost]
    public async Task<ActionResult> CreateCategoryAsync([FromBody] CreateCategoryDTO createCategoryDto)
    {
        if (!ModelState.IsValid) return BadRequest();
        
        var newCategory = await _categoryService.CreateCategoryAsync(createCategoryDto);
        return Ok(newCategory);
    }
}