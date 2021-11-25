using System;

namespace DemoDictionary_10112021
{
    public class MyMultySet<TVal> : BaseTree<TVal> where TVal : IComparable<TVal>
    {
        public MyMultySet() : base(false)
        {
        }
    }

}
