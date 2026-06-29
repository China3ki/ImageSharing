using ImageSharing.Shared.Interfaces;
using ImageSharing.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageSharing.Tests
{
    public class TestCategoriesService : ICategoriesService
    {
        private readonly CategoryModel[] _categories = [];
        public TestCategoriesService()
        {
            _categories = [
                new CategoryModel { Id = 1, Name = "Nature"},
                new CategoryModel { Id = 2, Name = "Architecture"},
                new CategoryModel { Id = 3, Name = "Portraits"},
                new CategoryModel { Id = 4, Name = "Animals"},
                new CategoryModel { Id = 5, Name = "Travel"},
                new CategoryModel { Id = 6, Name = "Food"},
                new CategoryModel { Id = 7, Name = "Black & White"},
                new CategoryModel { Id = 8, Name = "Sports"},
                new CategoryModel { Id = 9, Name = "Evenets"}
                ];
        }
        public CategoryModel[] GetCategories() => _categories;
    }
}
