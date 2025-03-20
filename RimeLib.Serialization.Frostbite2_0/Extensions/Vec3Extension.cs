using fb;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Serialization.Frostbite2_0.Extensions
{
	public static class Vec3Extension
	{
		public static System.Numerics.Vector3 ToVec(this Vec3 p_Vec) => new System.Numerics.Vector3(p_Vec.x, p_Vec.y, p_Vec.z);
        
        
		public static void Set(this Vec3 p_Vec, System.Numerics.Vector4 p_Val)
		{
			p_Vec.x = p_Val.X;
			p_Vec.y = p_Val.Y;
			p_Vec.z = p_Val.Z;
		}
		public static void Set(this Vec3 p_Vec, System.Numerics.Vector3 p_Val)
		{
			p_Vec.x = p_Val.X;
			p_Vec.y = p_Val.Y;
			p_Vec.z = p_Val.Z;
		}
		public static void Set(this Vec3 p_Vec, System.Numerics.Vector2 p_Val)
		{
			p_Vec.x = p_Val.X;
			p_Vec.y = p_Val.Y;
			p_Vec.z = 0.0f;
		}
        
		public static void Set(this Vec3 p_Vec, Vec4 p_Val)
		{
			p_Vec.x = p_Val.x;
			p_Vec.y = p_Val.y;
			p_Vec.z = p_Val.z;
		}
		public static void Set(this Vec3 p_Vec, Vec2 p_Val)
		{
			p_Vec.x = p_Val.x;
			p_Vec.y = p_Val.y;
			p_Vec.z = 0.0f;
		}


        
		public static void Deserialize(this Vec3 p_Value, RimeReader p_Reader)
		{
			p_Value.x = p_Reader.ReadSingle();
			p_Value.y = p_Reader.ReadSingle();
			p_Value.z = p_Reader.ReadSingle();
			p_Reader.ReadBytes(4); // padding
		}

		public static void Serialize(this Vec3 p_Value, RimeWriter p_Writer)
		{
			p_Writer.Write(p_Value.x);
			p_Writer.Write(p_Value.y);
			p_Writer.Write(p_Value.z);
			p_Writer.WriteNullBytes(4);
		}
	}
}