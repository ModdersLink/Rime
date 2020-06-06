///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class LinearMovingBodyData : 
		MovingBodyData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Axis { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32)]
		public EndPointData Start { get; set; } = new EndPointData(); // 0x20 (32)
		
		[ContainerField(52)]
		public EndPointData End { get; set; } = new EndPointData(); // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088662246:
					Axis = (Vec3) p_Value;
					break;

				case 230748069:
					Start = (EndPointData) p_Value;
					break;

				case 193438506:
					End = (EndPointData) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088662246:
					return Axis;

				case 230748069:
					return Start;

				case 193438506:
					return End;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088662246:
					return typeof(LinearMovingBodyData).GetProperty(nameof(Axis));

				case 230748069:
					return typeof(LinearMovingBodyData).GetProperty(nameof(Start));

				case 193438506:
					return typeof(LinearMovingBodyData).GetProperty(nameof(End));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
