///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class WeaponFiringEffectsModifier : 
		WeaponModifierBase
	{
		[ContainerField(8)]
		public List<FireEffectData> FireEffects1p { get; set; } = new List<FireEffectData>(); // 0x8 (8)
		
		[ContainerField(12)]
		public List<FireEffectData> FireEffects3p { get; set; } = new List<FireEffectData>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3749424600:
					FireEffects1p = (List<FireEffectData>) p_Value;
					break;

				case 3749424538:
					FireEffects3p = (List<FireEffectData>) p_Value;
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
				case 3749424600:
					return FireEffects1p;

				case 3749424538:
					return FireEffects3p;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3749424600:
					return typeof(WeaponFiringEffectsModifier).GetProperty(nameof(FireEffects1p));

				case 3749424538:
					return typeof(WeaponFiringEffectsModifier).GetProperty(nameof(FireEffects3p));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
