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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(20), ContainerStruct]
	public class GunSwayStanceTransition : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public GunSwayDispersionData MaxPenaltyValue { get; set; } = new GunSwayDispersionData(); // 0x0 (0)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float CoolDown { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4051813153:
					MaxPenaltyValue = (GunSwayDispersionData) p_Value;
					break;

				case 362058232:
					CoolDown = (float) p_Value;
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
				case 4051813153:
					return MaxPenaltyValue;

				case 362058232:
					return CoolDown;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4051813153:
					return typeof(GunSwayStanceTransition).GetProperty(nameof(MaxPenaltyValue));

				case 362058232:
					return typeof(GunSwayStanceTransition).GetProperty(nameof(CoolDown));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
