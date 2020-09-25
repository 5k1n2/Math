using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp3 {



    class Matrix3 {

        //matrix var

        float x1;
        float x2;
        float x3;

        float y1;
        float y2;
        float y3;

        float z1;
        float z2;
        float z3;


        public Matrix3() {



        }

        public Matrix3(float _x1, float _x2, float _x3, float _y1, float _y2, float _y3, float _z1, float _z2, float _z3) {

            x1 = _x1;
            x2 = _x2;
            x3 = _x3;

            y1 = _y1;
            y2 = _y2;
            y3 = _y3;

            z1 = _z1;
            z2 = _z2;
            z3 = _z3;

        }




        public static Matrix3 operator +(Matrix3 one, Matrix3 two) {

            Matrix3 rslt = null;

            rslt.x1 = one.x1 + two.x1;
            rslt.x2 = one.x2 + two.x2;
            rslt.x3 = one.x3 + two.x3;

            rslt.y1 = one.y1 + two.y1;
            rslt.y2 = one.y2 + two.y2;
            rslt.y3 = one.y3 + two.y3;

            rslt.z1 = one.z1 + two.z1;
            rslt.z2 = one.z2 + two.z2;
            rslt.z3 = one.z3 + two.z3;


            return rslt;

        }

        public static Matrix3 operator -(Matrix3 one, Matrix3 two) {

            Matrix3 rslt = null;

            rslt.x1 = one.x1 - two.x1;
            rslt.x2 = one.x2 - two.x2;
            rslt.x3 = one.x3 - two.x3;

            rslt.y1 = one.y1 - two.y1;
            rslt.y2 = one.y2 - two.y2;
            rslt.y3 = one.y3 - two.y3;

            rslt.z1 = one.z1 - two.z1;
            rslt.z2 = one.z2 - two.z2;
            rslt.z3 = one.z3 - two.z3;


            return rslt;

        }

        public static Matrix3 operator *(Matrix3 one, Matrix3 two) {

            Matrix3 rslt = null;

            rslt.x1 = one.x1 * two.x1 + one.x2 * two.y1 + one.x3 * two.z1;
            rslt.x2 = one.x1 * two.x2 + one.x2 * two.y2 + one.x3 * two.z2;
            rslt.x3 = one.x1 * two.x3 + one.x2 * two.y3 + one.x3 * two.z3;

            rslt.y1 = one.y1 * two.x1 + one.y2 * two.y1 + one.y3 * two.z1;
            rslt.y2 = one.y1 * two.x2 + one.y2 * two.y2 + one.y3 * two.z2;
            rslt.y3 = one.y1 * two.x3 + one.y2 * two.y3 + one.y3 * two.z3;

            rslt.z1 = one.z1 * two.x1 + one.z2 * two.y1 + one.z3 * two.z1;
            rslt.z2 = one.z1 * two.x2 + one.z2 * two.y2 + one.z3 * two.z2;
            rslt.z3 = one.z1 * two.x3 + one.z2 * two.y3 + one.z3 * two.z3;


            return rslt;

        }

        public static Matrix3 operator *(Matrix3 one, float two) {


            Matrix3 rslt = null;

            rslt.x1 = one.x1 * two;
            rslt.x2 = one.x2 * two;
            rslt.x3 = one.x3 * two;

            rslt.y1 = one.y1 * two;
            rslt.y2 = one.y2 * two;
            rslt.y3 = one.y3 * two;

            rslt.z1 = one.z1 * two;
            rslt.z2 = one.z2 * two;
            rslt.z3 = one.z3 * two;


            return rslt;

        }

        public static Matrix3 operator +(Matrix3 one, float two) {


            Matrix3 rslt = null;

            rslt.x1 = one.x1 + two;
            rslt.x2 = one.x2 + two;
            rslt.x3 = one.x3 + two;

            rslt.y1 = one.y1 + two;
            rslt.y2 = one.y2 + two;
            rslt.y3 = one.y3 + two;

            rslt.z1 = one.z1 + two;
            rslt.z2 = one.z2 + two;
            rslt.z3 = one.z3 + two;


            return rslt;

        }



        public static Matrix3 operator -(Matrix3 one, float two) {


            Matrix3 rslt = null;

            rslt.x1 = one.x1 - two;
            rslt.x2 = one.x2 - two;
            rslt.x3 = one.x3 - two;

            rslt.y1 = one.y1 - two;
            rslt.y2 = one.y2 - two;
            rslt.y3 = one.y3 - two;

            rslt.z1 = one.z1 - two;
            rslt.z2 = one.z2 - two;
            rslt.z3 = one.z3 - two;


            return rslt;

        }

        public static Matrix3 operator -(float one, Matrix3 two) {


            Matrix3 rslt = null;

            rslt.x1 = one - two.x1;
            rslt.x2 = one - two.x2;
            rslt.x3 = one - two.x3;
                               
            rslt.y1 = one - two.y1;
            rslt.y2 = one - two.y2;
            rslt.y3 = one - two.y3;
                               
            rslt.z1 = one - two.z1;
            rslt.z2 = one - two.z2;
            rslt.z3 = one - two.z3;


            return rslt;

        }


        public static float Determinant(float _x1, float _x2, float _y1, float _y2) {

            float rslt;

            rslt = _x1 * _y2 + _x2 * _y1;

            return rslt;
        }

        public float Determinant() {

            float rslt;

            rslt = 
                x1 * y2 * z3 +
                x2 * y3 * z1 +
                x3 * y1 * z2 -
                z1 * y2 * z3 -
                z2 * y3 * x1 -
                z3 * y1 * x2;

            return rslt;

        }


    }
}
