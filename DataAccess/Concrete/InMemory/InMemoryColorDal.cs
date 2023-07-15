using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal() 
        { 
            _colors = new List<Color>();
            {
                new Color { CategoryId = 1, CategoryName = "İzmir" };
                new Color { CategoryId = 2, CategoryName = "Kuşadası" };
                new Color { CategoryId = 3, CategoryName = "Mersin" };
            };

        }
        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            Color colorToDelete = _colors.SingleOrDefault(p => p.CategoryId == color.CategoryId);
            _colors.Remove(colorToDelete);
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            return _colors;
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetById(int ColorId)
        {
            return _colors.Where(p=> p.CategoryId == ColorId).ToList();
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _colors.SingleOrDefault(p=> p.CategoryId == color.CategoryId);
            colorToUpdate.CategoryName= color.CategoryName;
        }
    }
}
