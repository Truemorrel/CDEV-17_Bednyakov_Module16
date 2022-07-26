using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> FindAll()
        {
            return null;
        }
    }
}
