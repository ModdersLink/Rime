using fb;
using RimeLib.IO;

namespace RimeLib.Serialization.Frostbite2_0.Extensions;

public static class Vec2Extension
{
	public static System.Numerics.Vector2 ToVec(this Vec2 p_Vec) => new System.Numerics.Vector2(p_Vec.x, p_Vec.y);


	public static void Set(this Vec2 p_Vec, System.Numerics.Vector4 p_Val)
	{
		p_Vec.x = p_Val.X;
		p_Vec.y = p_Val.Y;
	}
	public static void Set(this Vec2 p_Vec, System.Numerics.Vector3 p_Val)
	{
		p_Vec.x = p_Val.X;
		p_Vec.y = p_Val.Y;
	}
	public static void Set(this Vec2 p_Vec, System.Numerics.Vector2 p_Val)
	{
		p_Vec.x = p_Val.X;
		p_Vec.y = p_Val.Y;
	}

	public static void Set(this Vec2 p_Vec, Vec4 p_Val)
	{
		p_Vec.x = p_Val.x;
		p_Vec.y = p_Val.y;
	}
	public static void Set(this Vec2 p_Vec, Vec3 p_Val)
	{
		p_Vec.x = p_Val.x;
		p_Vec.y = p_Val.y;
	}



	public static void Deserialize(this Vec2 p_Value, RimeReader p_Reader)
	{
		p_Value.x = p_Reader.ReadSingle();
		p_Value.y = p_Reader.ReadSingle();
	}

	public static void Serialize(this Vec2 p_Value, RimeWriter p_Writer)
	{
		p_Writer.Write(p_Value.x);
		p_Writer.Write(p_Value.y);
	}
}