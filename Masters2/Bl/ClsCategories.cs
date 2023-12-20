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

        public bool Save(TbCategory TbCategory)
        {
            try
            {
                Masters2Context context = new Masters2Context();

                if (TbCategory.CategoryId == 0)
                {
                    context.TbCategories.Add(TbCategory);
                }
                else
                {
                    context.Entry(TbCategory).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.TbCategories.Update(TbCategory);
                }
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
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
