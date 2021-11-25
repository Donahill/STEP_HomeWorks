using System;

namespace DemoDictionary_10112021
{
    public class MyMultyMap<TKey, TVal> : BaseDictionary<TKey, TVal> where TKey : IComparable<TKey>
    {
        public MyMultyMap() : base(false)
        {
        }
    }

}
