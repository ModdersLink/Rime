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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class ZoomLevelLockData : FrostbiteContainer
	{
		[ContainerField(Name: "OutlineTaggedDistance", Offset: 0, NameHash: 2697603954, Flags: 49469), LayoutImmutable, Blittable]
		public float OutlineTaggedDistance { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "LockType", Offset: 4, NameHash: 1982079030, Flags: 137)]
		public LockType LockType { get; set; } = new LockType(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2697603954:
					OutlineTaggedDistance = (float) p_Value;
					break;

				case 1982079030:
						LockType = (LockType) Enum.ToObject(typeof(LockType), p_Value);
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
				case 2697603954:
					return OutlineTaggedDistance;

				case 1982079030:
					return LockType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2697603954:
					return typeof(ZoomLevelLockData).GetProperty(nameof(OutlineTaggedDistance));

				case 1982079030:
					return typeof(ZoomLevelLockData).GetProperty(nameof(LockType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
