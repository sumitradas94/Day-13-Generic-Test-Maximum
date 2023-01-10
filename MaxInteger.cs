using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class MaxInteger<T> where T : IComparable
    {
        public static T MaxIntNumber(T X, T Y, T Z)
        {
            if (X.CompareTo(Y) > 0 && X.CompareTo(Z) > 0 ||
                X.CompareTo(Y) >= 0 && X.CompareTo(Z) > 0 ||
                X.CompareTo(Y) > 0 && X.CompareTo(Z) >= 0)

            {
                return X;
            }

            if (Y.CompareTo(X) > 0 && Y.CompareTo(Z) > 0 ||
                Y.CompareTo(X) >= 0 && Y.CompareTo(Z) > 0 ||
                Y.CompareTo(X) > 0 && Y.CompareTo(Z) >= 0)

            {
                return Y;
            }

            if (Z.CompareTo(X) > 0 && Z.CompareTo(Y) > 0 ||
                Z.CompareTo(X) >= 0 && Z.CompareTo(Y) > 0 ||
                Z.CompareTo(X) > 0 && Z.CompareTo(Y) >= 0)

            {
                return Z;
            }
            return X;
        }
    }
}
