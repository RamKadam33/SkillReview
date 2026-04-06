using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice
{
public interface IRepository<T>
    {
        void Add(T item);
        IEnumerable<T> GetAll();
    }
    
        

    public class Repository<T> : IRepository<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }
    }

    class Program
    {
        [Test]
        public void main()
        {
          IRepository<string> stringrepo = new Repository<string>();
            stringrepo.Add("item 1");
            stringrepo.Add("item 2");

            foreach (var item in stringrepo.GetAll())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

}
