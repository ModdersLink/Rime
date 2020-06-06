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
	public class MissileLockableInfoData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float HeatSignature { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float RadarSignature { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2221510681:
					HeatSignature = (float) p_Value;
					break;

				case 1808737829:
					RadarSignature = (float) p_Value;
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
				case 2221510681:
					return HeatSignature;

				case 1808737829:
					return RadarSignature;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2221510681:
					return typeof(MissileLockableInfoData).GetProperty(nameof(HeatSignature));

				case 1808737829:
					return typeof(MissileLockableInfoData).GetProperty(nameof(RadarSignature));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
