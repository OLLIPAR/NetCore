using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AddDbContent addDbContent;
        public CategoryRepository(AddDbContent addDbContent) { this.addDbContent = addDbContent; }
        public IEnumerable<Category> AllCategories => addDbContent.Category;
    }
}
