///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class WeaponFiringEffectsModifier : 
		WeaponModifierBase
	{
		protected List<FireEffectData> m_FireEffects1p = new List<FireEffectData>();
		[ContainerField(8), MemberInfoFlag(65), ContainerFieldNameHash(3749424600), ContainerArray]
		public List<FireEffectData> FireEffects1p { get { return m_FireEffects1p; } set { if (OnPropertyChanging("WeaponFiringEffectsModifier." + nameof(FireEffects1p), this, m_FireEffects1p, value)) m_FireEffects1p = value; } } // 0x8 (8)
		
		protected List<FireEffectData> m_FireEffects3p = new List<FireEffectData>();
		[ContainerField(12), MemberInfoFlag(65), ContainerFieldNameHash(3749424538), ContainerArray]
		public List<FireEffectData> FireEffects3p { get { return m_FireEffects3p; } set { if (OnPropertyChanging("WeaponFiringEffectsModifier." + nameof(FireEffects3p), this, m_FireEffects3p, value)) m_FireEffects3p = value; } } // 0xC (12)
		
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
