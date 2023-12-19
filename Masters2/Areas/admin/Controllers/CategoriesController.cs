using Microsoft.AspNetCore.Mvc;
using Masters2.Models;
using Microsoft.EntityFrameworkCore;
//using Masters2.Bl;

namespace Masters.Areas.admin.Controllers
{

    [Area("admin")]

    public class CategoriesController : Controller
    {

        public IActionResult List()
        {
            FormManagementContext context = new FormManagementContext();
            var lstCategories = context.Categories.ToList();
            return View(lstCategories);
        }
        public IActionResult Edit(int? Id)
        {
            var category = new Category();
            if (Id != null)
            {
                FormManagementContext context = new FormManagementContext();
                category = context.Categories.FirstOrDefault(a => a.CategoryId == Id);
            }
            
            return View(category);
        }

        [HttpPost]
        public IActionResult Save(Category category)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View("Edit", category);
            //}

            using (FormManagementContext context = new FormManagementContext())
            {
                if (category.CategoryId == 0)
                {
                    context.Categories.Add(category);
                }
                else
                {
                    context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    return View("Edit", category);
                }

                context.SaveChanges();
            }

            return RedirectToAction("List");


        }


    }
}

//[HttpPost]
//[ValidateAntiForgeryToken]
//public IActionResult DeleteConfirmed(int categoryId)
//{
//    using (FormManagementContext context = new FormManagementContext())
//    {
//        var category = context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

//        if (category != null)
//        {
//            context.oClsCategories.Remove(category);
//            context.SaveChanges();
//        }
//    }

//    return RedirectToAction(nameof(List));
//}


//return View("Edit", category);
//FormManagementContext context = new FormManagementContext();

//if (category.CategoryId == 0)
//{
//    context.Categories.Add(category);
//}
//else
//{
//    context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
//}
//context.SaveChanges();

//context.Categories.Add(category);


//var category = new Category();
//if (Id != null)
//{
//    FormManagementContext context = new FormManagementContext();
//    category = context.Categories.FirstOrDefault(a => a.CategoryId == Id);
//}