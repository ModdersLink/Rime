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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(8), ContainerStruct]
	public class WeaponLagEffectSpringData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Constant { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Damping { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 340870363:
					Constant = (float) p_Value;
					break;

				case 3862601053:
					Damping = (float) p_Value;
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
				case 340870363:
					return Constant;

				case 3862601053:
					return Damping;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 340870363:
					return typeof(WeaponLagEffectSpringData).GetProperty(nameof(Constant));

				case 3862601053:
					return typeof(WeaponLagEffectSpringData).GetProperty(nameof(Damping));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
