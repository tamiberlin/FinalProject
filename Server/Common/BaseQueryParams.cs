using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class BaseQueryParams
    {
        const int MAX_PAGE_SIZE = 50;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 15;
        public int PageSize 
        { 
            get { return _pageSize; } 
            set { if(value >0 && value < MAX_PAGE_SIZE) _pageSize = value; }
        }
    }
}
