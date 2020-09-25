using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp3 {


    class Vector3D {


        // Values //

        float x, y, z;


        // Constructor //

        public Vector3D() {

        }

        public Vector3D(float _x, float _y, float _z) {

            x = _x;
            y = _y;
            z = _z;
        }


        // Invert //

        public void Invert() {

            x *= -1;
            y *= -1;
            z *= -1;
        }


        // Quality Of Life Extra //

        public static Vector3D zero() {

            return new Vector3D(0, 0, 0);
        }


        public static Vector3D one() {

            return new Vector3D(1, 1, 1);

        }



        // Operator Overwrite //

        public static Vector3D operator +(Vector3D one, Vector3D two) {

            one.x = one.x + two.x;
            one.y = one.y + two.y;
            one.z = one.z + two.z;

            return one;
        }


        public static Vector3D operator -(Vector3D one, Vector3D two) {

            one.x = one.x - two.x;
            one.y = one.y - two.y;
            one.z = one.z - two.z;

            return one;
        }

        public static Vector3D operator -(Vector3D one, float two) {


            one.x = one.x - two;
            one.y = one.y - two;
            one.z = one.z - two;

            return one;
        }


        public static Vector3D operator -(float one, Vector3D two) {


            two.x = one - two.x;
            two.y = one - two.y;
            two.z = one - two.z;

            return two;
        }

        public static Vector3D operator *(Vector3D one, Vector3D two) {


            one.x = one.x * two.x;
            one.y = one.y * two.y;
            one.z = one.z * two.z;

            return one;
        }

        public static Vector3D operator *(Vector3D one, float two) {


            one.x = one.x * two;
            one.y = one.y * two;
            one.z = one.z * two;

            return one;
        }

        public static Vector3D operator *(float one, Vector3D two) {


            two.x = one * two.x;
            two.y = one * two.y;
            two.z = one * two.z;

            return two;
        }

        public static Vector3D operator /(Vector3D one, Vector3D two) {


            one.x = one.x / two.x;
            one.y = one.y / two.y;
            one.z = one.z / two.z;

            return one;
        }

        public static Vector3D operator /(Vector3D one, float two) {



            one.x = one.x / two;
            one.y = one.y / two;
            one.z = one.z / two;

            return one;
        }

        public static Vector3D operator /(float one, Vector3D two) {



            two.x = one / two.x;
            two.y = one / two.y;
            two.z = one / two.z;

            return two;
        }

        public static bool operator ==(Vector3D one, Vector3D two) {



            if ((one.Magnitude() - two.Magnitude()) < 1e-5) {

                return true;
            }

            return false;

        }

        public static bool operator !=(Vector3D one, Vector3D two) {



            if ((one.Magnitude() - two.Magnitude()) < 1e-5) {

                return false;
            }

            return true;
        }



        // Dot Product //

        public float Dot(Vector3D one, Vector3D two) {


            one.Normalize();
            two.Normalize();


            return one.x * two.x + one.y * two.y + one.z * one.z;
        }


        // Normalize //

        public void Normalize() {

            x = x / Magnitude();
            y = y / Magnitude();
            z = z / Magnitude();

        }

        public Vector3D Normalized() {

            Vector3D rslt = new Vector3D();
            rslt.x = x / Magnitude();
            rslt.y = y / Magnitude();
            rslt.z = z / Magnitude();

            return rslt;

        }


        // Magnitude //

        public float Magnitude() {

            return Convert.ToSingle(Math.Sqrt(x * x + y * y + z * z));
        }


        // Lerp //

        public static Vector3D Lerp(Vector3D one, Vector3D two, float t) {


            if (t > 1) { t = 1; }
            if (t < 0) { t = 0; }

            one = one + t * (two - one);

            return one;
        }


        // Distance //

        public static float Distance(Vector3D one, Vector3D two) {


            one = two - one;
            return Math.Abs(one.Magnitude());
        }


        // Maximum and Minimum

        public static Vector3D Max(Vector3D one, Vector3D two) {

            if (one.x > two.x) { two.x = one.x; }
            if (one.y > two.y) { two.y = one.y; }
            if (one.z > two.z) { two.z = one.z; }

            return two;
        }

        public static Vector3D Min(Vector3D one, Vector3D two) {

            if (one.x < two.x) { two.x = one.x; }
            if (one.y < two.y) { two.y = one.y; }
            if (one.z < two.z) { two.z = one.z; }

            return two;
        }
    }
}
