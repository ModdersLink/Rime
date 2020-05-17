using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Text;

namespace RimeLib.Frostbite.Core
{
    public class LinearTransform
    {
        public Vec3 Right { get; set; }

        public Vec3 Up { get; set; }

        public Vec3 Forward { get; set; }

        public Vec3 Trans { get; set; }

        public LinearTransform()
        {
            Right = new Vec3();
            Up = new Vec3();
            Forward = new Vec3();
            Trans = new Vec3();
        }

        public LinearTransform(Vec3 p_Right, Vec3 p_Up, Vec3 p_Forward, Vec3 p_Trans)
        {
            Right = p_Right;
            Up = p_Up;
            Forward = p_Forward;
            Trans = p_Trans;
        }

        public LinearTransform(RimeReader p_Reader)
        {
            Right = new Vec3(p_Reader);
            Up = new Vec3(p_Reader);
            Forward = new Vec3(p_Reader);
            Trans = new Vec3(p_Reader);
        }

        public static LinearTransform operator +(LinearTransform p_First, LinearTransform p_Second)
        {
            return new LinearTransform(p_First.Right + p_Second.Right,
                p_First.Up + p_Second.Up,
                p_First.Forward + p_Second.Forward,
                p_First.Trans + p_Second.Trans);
        }

        public static LinearTransform operator -(LinearTransform p_First, LinearTransform p_Second)
        {
            return new LinearTransform(p_First.Right - p_Second.Right,
                p_First.Up - p_Second.Up,
                p_First.Forward - p_Second.Forward,
                p_First.Trans - p_Second.Trans);
        }

        public static LinearTransform operator *(LinearTransform p_First, LinearTransform p_Second)
        {
            return new LinearTransform(p_First.Right * p_Second.Right,
                p_First.Up * p_Second.Up,
                p_First.Forward * p_Second.Forward,
                p_First.Trans * p_Second.Trans);
        }

    }
}
