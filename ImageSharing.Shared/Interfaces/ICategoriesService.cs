using ImageSharing.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ImageSharing.Shared.Interfaces
{
    public interface ICategoriesService
    {
        CategoryModel[] GetCategories();
    }
}
