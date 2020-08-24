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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class LookConstraintsData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinLookYaw { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxLookYaw { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinLookPitch { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxLookPitch { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1226173479:
					MinLookYaw = (float) p_Value;
					break;

				case 3883372025:
					MaxLookYaw = (float) p_Value;
					break;

				case 3873582030:
					MinLookPitch = (float) p_Value;
					break;

				case 2736166672:
					MaxLookPitch = (float) p_Value;
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
				case 1226173479:
					return MinLookYaw;

				case 3883372025:
					return MaxLookYaw;

				case 3873582030:
					return MinLookPitch;

				case 2736166672:
					return MaxLookPitch;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1226173479:
					return typeof(LookConstraintsData).GetProperty(nameof(MinLookYaw));

				case 3883372025:
					return typeof(LookConstraintsData).GetProperty(nameof(MaxLookYaw));

				case 3873582030:
					return typeof(LookConstraintsData).GetProperty(nameof(MinLookPitch));

				case 2736166672:
					return typeof(LookConstraintsData).GetProperty(nameof(MaxLookPitch));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
