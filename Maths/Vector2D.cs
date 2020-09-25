using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimonLibrary {
    class Vector2D {


        // Values //

        float x, y;


        // Constructor //

        public Vector2D() {

        }

        public Vector2D(float _x, float _y) {

            x = _x;
            y = _y;

        }


        // Invert //

        public void Invert() {

            x *= -1;
            y *= -1;

        }


        // Quality Of Life Extra //

        public static Vector2D zero() {

            return new Vector2D(0, 0);
        }


        public static Vector2D one() {

            return new Vector2D(1, 1);

        }



        // Operator Overwrite //

        public static Vector2D operator +(Vector2D one, Vector2D two) {

            one.x = one.x + two.x;
            one.y = one.y + two.y;

            return one;
        }


        public static Vector2D operator -(Vector2D one, Vector2D two) {

            one.x = one.x - two.x;
            one.y = one.y - two.y;

            return one;
        }

        public static Vector2D operator -(Vector2D one, float two) {


            one.x = one.x - two;
            one.y = one.y - two;

            return one;
        }


        public static Vector2D operator -(float one, Vector2D two) {


            two.x = one - two.x;
            two.y = one - two.y;

            return two;
        }

        public static Vector2D operator *(Vector2D one, Vector2D two) {


            one.x = one.x * two.x;
            one.y = one.y * two.y;

            return one;
        }

        public static Vector2D operator *(Vector2D one, float two) {


            one.x = one.x * two;
            one.y = one.y * two;

            return one;
        }

        public static Vector2D operator *(float one, Vector2D two) {


            two.x = one * two.x;
            two.y = one * two.y;

            return two;
        }

        public static Vector2D operator /(Vector2D one, Vector2D two) {


            one.x = one.x / two.x;
            one.y = one.y / two.y;

            return one;
        }

        public static Vector2D operator /(Vector2D one, float two) {



            one.x = one.x / two;
            one.y = one.y / two;

            return one;
        }

        public static Vector2D operator /(float one, Vector2D two) {



            two.x = one / two.x;
            two.y = one / two.y;

            return two;
        }

        public static bool operator ==(Vector2D one, Vector2D two) {



            if ((one.Magnitude() - two.Magnitude()) < 1e-5) {

                return true;
            }

            return false;

        }

        public static bool operator !=(Vector2D one, Vector2D two) {



            if ((one.Magnitude() - two.Magnitude()) < 1e-5) {

                return false;
            }

            return true;
        }



        // Dot Product //

        public float Dot(Vector2D one, Vector2D two) {


            one.Normalize();
            two.Normalize();


            return one.x * two.x + one.y * two.y;
        }


        // Normalize //

        public void Normalize() {

            x = x / Magnitude();
            y = y / Magnitude();

        }

        public Vector2D Normalized() {

            Vector2D rslt = new Vector2D();
            rslt.x = x / Magnitude();
            rslt.y = y / Magnitude();

            return rslt;

        }


        // Magnitude //

        public float Magnitude() {

            return Convert.ToSingle(Math.Sqrt(x * x + y * y));
        }


        // Lerp //

        public static Vector2D Lerp(Vector2D one, Vector2D two, float t) {


            if (t > 1) { t = 1; }
            if (t < 0) { t = 0; }

            one = one + t * (two - one);

            return one;
        }


        // Distance //

        public static float Distance(Vector2D one, Vector2D two) {


            one = two - one;
            return Math.Abs(one.Magnitude());
        }


        // Maximum and Minimum

        public static Vector2D Max(Vector2D one, Vector2D two) {

            if (one.x > two.x) { two.x = one.x; }
            if (one.y > two.y) { two.y = one.y; }

            return two;
        }

        public static Vector2D Min(Vector2D one, Vector2D two) {

            if (one.x < two.x) { two.x = one.x; }
            if (one.y < two.y) { two.y = one.y; }

            return two;
        }
    }
}