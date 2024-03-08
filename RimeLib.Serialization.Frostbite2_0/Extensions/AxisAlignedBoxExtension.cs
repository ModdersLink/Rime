using fb;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Serialization.Frostbite2_0.Extensions
{
	public static class AxisAlignedBoxExtension
	{
		public static System.Numerics.Vector3 Min(this AxisAlignedBox p_Value) => p_Value.min.ToVec();
		public static System.Numerics.Vector3 Max(this AxisAlignedBox p_Value) => p_Value.max.ToVec();


		public static void Deserialize(this AxisAlignedBox p_Value, RimeReader p_Reader)
		{
			p_Value.min.Deserialize(p_Reader);
			p_Value.max.Deserialize(p_Reader);
		}

		public static void Serialize(this AxisAlignedBox p_Value, RimeWriter p_Writer)
		{
			p_Value.min.Serialize(p_Writer);
			p_Value.max.Serialize(p_Writer);
		}
        
        
		public static void DeserializeVec2(this AxisAlignedBox p_Value, RimeReader p_Reader)
		{
			var s_Min = new Vec2();
			s_Min.Deserialize(p_Reader);
			p_Value.min.Set(s_Min);
            
            
			var s_Max = new Vec2();
			s_Max.Deserialize(p_Reader);
			p_Value.max.Set(s_Max);
		}

	}
}