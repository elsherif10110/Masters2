using Masters2.Models;

namespace Masters2.Bl
{
    public class ClsTbCategories
    {
        public List<TbCategory> GetAll()
        {
            try
            {
                Masters2Context context = new Masters2Context();
                var lstTbCategory = context.TbCategories.ToList();
                return lstTbCategory;

            }
            catch
            {
                return new List<TbCategory>();
            }
        }

        public TbCategory GetById(int id)
        {
            try
            {
                Masters2Context context = new Masters2Context();
                var TbCategory = context.TbCategories.FirstOrDefault(a => a.CategoryId == id);
                return TbCategory;
            }
            catch
            {
                return new TbCategory();
            }
        }

        public bool Save(string categoryName)
        {
            try
            {
                Masters2Context context = new Masters2Context();
                TbCategory category = new TbCategory();

                category.CategoryName = categoryName;

                if (category.CategoryId == 0)
                {
                    context.TbCategories.Add(category);
                }
                else
                {
                    context.Entry(category).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.TbCategories.Update(category);
                }
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string GetCategoryFromQustionRecord(string qustionsRecord)
        {
            string category = string.Empty;

            List<string> qustionsList = new List<string>();

            qustionsList = qustionsRecord.Split("/*/").ToList();

            category = qustionsList[0];

            return category;
        }

        public int GetLastId()
        {
            try
            {
                Masters2Context context = new Masters2Context();

                return context.TbCategories.OrderByDescending(a => a.CategoryId).FirstOrDefault().CategoryId;
            }
            catch
            {
                return - 1;
            }
        }

        public bool Dekete(int id)
        {
            try
            {
                Masters2Context context = new Masters2Context();
                var TbCategory = GetById(id);
                context.TbCategories.Remove(TbCategory);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
