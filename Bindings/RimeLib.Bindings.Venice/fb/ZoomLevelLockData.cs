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
	[ContainerType(4)]
	public class ZoomLevelLockData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float OutlineTaggedDistance { get; set; } // 0x0 (0)
		
		[ContainerField(4)]
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
