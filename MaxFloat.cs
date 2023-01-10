using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class MaxFloat<T> where T : IComparable
    {
        public static T MaxFloatNum(T A, T B, T C)
        {
            if (A.CompareTo(B) > 0 && A.CompareTo(C) > 0 ||
                A.CompareTo(B) >= 0 && A.CompareTo(C) > 0 ||
                A.CompareTo(B) > 0 && A.CompareTo(C) >= 0)

            {
                return A;
            }

            if (B.CompareTo(A) > 0 && B.CompareTo(C) > 0 ||
                B.CompareTo(A) >= 0 && B.CompareTo(C) > 0 ||
                B.CompareTo(A) > 0 && B.CompareTo(C) >= 0)

            {
                return B;
            }

            if (C.CompareTo(A) > 0 && C.CompareTo(B) > 0 ||
                C.CompareTo(A) >= 0 && C.CompareTo(B) > 0 ||
                C.CompareTo(A) > 0 && C.CompareTo(B) >= 0)

            {
                return C;
            }
            return A;
        }
    }
}
