using System;
using System.Collections.Generic;

namespace Bamboo
{
    public static class ExntesionMethods
    {
        public static T PopLast<T>(this List<T> list)
        {
            int len = list.Count;

            if (len <= 0)
            {
                throw new ArgumentException();
            }

            int index = len - 1;

            T value = list[index];
            list.RemoveAt(index);

            return value;
        }
    }
}
