using System;

namespace DemoDictionary_10112021
{
    public class MySet<TVal> : BaseTree<TVal> where TVal : IComparable<TVal>
    {
        public MySet() : base(true)
        {
        }
    }

}
