using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQD11
{
    static class Pagination
    {
        public static IEnumerable<T> paginate<T>( this IEnumerable<T> source , int page = 1 , int size = 10) 
        {
            if(page <= 0)
            {
                page = 1 ;
            }

            if(size <= 0)
            {
                size = 10 ;
            }

            var total = source.Count();
            var pages = (int)Math.Ceiling((decimal)total / size);
            var res = source.Skip((page - 1) * size).Take(size).ToList();
            return res;
        }
    }
}
