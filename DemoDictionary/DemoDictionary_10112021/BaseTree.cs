using System;

namespace DemoDictionary_10112021
{
    public class BaseTree<T> : Tree<T, BaseComparer<T>> where T : IComparable<T>
    {
        public BaseTree(bool isUique) : base(isUique)
        {
        }
    }
}
