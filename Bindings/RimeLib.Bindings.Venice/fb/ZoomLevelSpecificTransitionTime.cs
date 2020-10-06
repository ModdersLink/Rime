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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(16), ContainerStruct]
	public class ZoomLevelSpecificTransitionTime : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int FromZoomLevel { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49405)]
		public int ToZoomLevel { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float ZoomTransitionTime { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float FovTransitionTime { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3920419474:
					FromZoomLevel = (int) p_Value;
					break;

				case 1509429727:
					ToZoomLevel = (int) p_Value;
					break;

				case 1414605576:
					ZoomTransitionTime = (float) p_Value;
					break;

				case 1751899392:
					FovTransitionTime = (float) p_Value;
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
				case 3920419474:
					return FromZoomLevel;

				case 1509429727:
					return ToZoomLevel;

				case 1414605576:
					return ZoomTransitionTime;

				case 1751899392:
					return FovTransitionTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3920419474:
					return typeof(ZoomLevelSpecificTransitionTime).GetProperty(nameof(FromZoomLevel));

				case 1509429727:
					return typeof(ZoomLevelSpecificTransitionTime).GetProperty(nameof(ToZoomLevel));

				case 1414605576:
					return typeof(ZoomLevelSpecificTransitionTime).GetProperty(nameof(ZoomTransitionTime));

				case 1751899392:
					return typeof(ZoomLevelSpecificTransitionTime).GetProperty(nameof(FovTransitionTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
