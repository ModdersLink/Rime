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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(24), ContainerStruct]
	public class WeaponLagEffectSpringVector : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public WeaponLagEffectSpringData SpringX { get; set; } = new WeaponLagEffectSpringData(); // 0x0 (0)
		
		[ContainerField(8), MemberInfoFlag(41)]
		public WeaponLagEffectSpringData SpringY { get; set; } = new WeaponLagEffectSpringData(); // 0x8 (8)
		
		[ContainerField(16), MemberInfoFlag(41)]
		public WeaponLagEffectSpringData SpringZ { get; set; } = new WeaponLagEffectSpringData(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2346095756:
					SpringX = (WeaponLagEffectSpringData) p_Value;
					break;

				case 2346095757:
					SpringY = (WeaponLagEffectSpringData) p_Value;
					break;

				case 2346095758:
					SpringZ = (WeaponLagEffectSpringData) p_Value;
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
				case 2346095756:
					return SpringX;

				case 2346095757:
					return SpringY;

				case 2346095758:
					return SpringZ;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2346095756:
					return typeof(WeaponLagEffectSpringVector).GetProperty(nameof(SpringX));

				case 2346095757:
					return typeof(WeaponLagEffectSpringVector).GetProperty(nameof(SpringY));

				case 2346095758:
					return typeof(WeaponLagEffectSpringVector).GetProperty(nameof(SpringZ));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
