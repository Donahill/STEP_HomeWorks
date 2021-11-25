using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDictionary_10112021
{
    public class MyMap<TKey, TVal> : BaseDictionary<TKey, TVal> where TKey : IComparable<TKey>
    {
        public MyMap() : base(true)
        {
        }
    }

}
