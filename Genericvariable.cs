using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class Genericvariable<T> where T : IComparable
    {
        public T A, B, C;
        public Genericvariable(T A, T B, T C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public static T MaxNumber(T A, T B, T C)
        {
            if (A.CompareTo(B) > 0 && A.CompareTo(C) > 0 ||
                    A.CompareTo(B) >= 0 && A.CompareTo(C) > 0 ||
                    A.CompareTo(B) > 0 && A.CompareTo(C) >= 0)
            {
                return A;
            }

            if (B.CompareTo(A) > 0 && B.CompareTo(C) > 0 ||
                    B.CompareTo(A) >= 0 && B.CompareTo(C) > 0 ||
                    B.CompareTo(B) > 0 && B.CompareTo(C) >= 0)
            {
                return B;
            }

            if (C.CompareTo(B) > 0 && C.CompareTo(A) > 0 ||
                    C.CompareTo(B) >= 0 && C.CompareTo(A) > 0 ||
                    C.CompareTo(B) > 0 && C.CompareTo(A) >= 0)
            {
                return C;
            }
            return default;




        }
        public T MaxMethod()
        {
            T Max = Genericvariable<T>.MaxNumber(this.A, this.B, this.C);
            return Max;
        }
    }
}
