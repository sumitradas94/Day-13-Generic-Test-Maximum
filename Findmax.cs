using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class Findmax<T> where T : IComparable
    {
        public static T MaxOfIntNum(T X, T Y, T Z)
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

        public static T MaxOfFloatNum(T A, T B, T C)
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

