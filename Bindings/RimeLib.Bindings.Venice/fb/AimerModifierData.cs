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
	public class AimerModifierData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float LookSpeedMultiplier { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool OnlyInSupportedShooting { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1418472942:
					LookSpeedMultiplier = (float) p_Value;
					break;

				case 809776183:
					OnlyInSupportedShooting = (bool) p_Value;
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
				case 1418472942:
					return LookSpeedMultiplier;

				case 809776183:
					return OnlyInSupportedShooting;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1418472942:
					return typeof(AimerModifierData).GetProperty(nameof(LookSpeedMultiplier));

				case 809776183:
					return typeof(AimerModifierData).GetProperty(nameof(OnlyInSupportedShooting));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
