//using Masters2.Models;

//namespace Masters2.Bl
//{
//    public class ClsCategories
//    {
//        public List<Category> GetAll()
//        {
//            try
//            {
//                FormManagementContext context = new FormManagementContext();
//                var lstCategory = context.Categories.ToList();
//                return lstCategory;

//            }
//            catch
//            {
//                return new List<Category>();
//            }
//        }

//        public Category GetById(int id)
//        {
//            try
//            {
//                FormManagementContext context = new FormManagementContext();
//                var category = context.Categories.FirstOrDefault(a => a.CategoryId == id);
//                return category;
//            }
//            catch
//            {
//                return new Category();
//            }
//        }

//        public bool Save(Category category)
//        {
//            try
//            {
//                FormManagementContext context = new FormManagementContext();

//                if (category.CategoryId == 0)
//                {
//                    context.Categories.Add(category);
//                }
//                else
//                {
//                    context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
//                    context.Categories.Update(category);
//                }
//                context.SaveChanges();
//                return true;
//            }
//            catch
//            {
//                return false;
//            }
//        }

//        public bool Dekete(int id)
//        {
//            try
//            {
//                FormManagementContext context = new FormManagementContext();
//                var category = GetById(id);
//                context.Categories.Remove(category);
//                context.SaveChanges();
//                return true;
//            }
//            catch
//            {
//                return false;
//            }
//        }
//    }
//}
