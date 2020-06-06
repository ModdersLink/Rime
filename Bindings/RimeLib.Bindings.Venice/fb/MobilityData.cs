///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MobilityData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MaxSpeed { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool Use3DWaypoints { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 396228950:
					MaxSpeed = (float) p_Value;
					break;

				case 184580769:
					Use3DWaypoints = (bool) p_Value;
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
				case 396228950:
					return MaxSpeed;

				case 184580769:
					return Use3DWaypoints;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 396228950:
					return typeof(MobilityData).GetProperty(nameof(MaxSpeed));

				case 184580769:
					return typeof(MobilityData).GetProperty(nameof(Use3DWaypoints));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
