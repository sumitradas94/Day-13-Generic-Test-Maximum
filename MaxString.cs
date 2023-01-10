using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class MaxString<T> where T : IComparable
    {
        public static T MaxStringNum(T P, T Q, T R)
        {
            if (P.CompareTo(Q) > 0 && P.CompareTo(R) > 0 ||
                P.CompareTo(Q) >= 0 && P.CompareTo(R) > 0 ||
                P.CompareTo(Q) > 0 && P.CompareTo(R) >= 0)

            {
                return P;
            }

            if (Q.CompareTo(P) > 0 && Q.CompareTo(R) > 0 ||
                Q.CompareTo(P) >= 0 && Q.CompareTo(R) > 0 ||
                Q.CompareTo(P) > 0 && Q.CompareTo(R) >= 0)

            {
                return Q;
            }

            if (R.CompareTo(P) > 0 && R.CompareTo(Q) > 0 ||
                R.CompareTo(P) >= 0 && R.CompareTo(Q) > 0 ||
                R.CompareTo(P) > 0 && R.CompareTo(Q) >= 0)

            {
                return R;
            }
            return P;
        }
    }
}
