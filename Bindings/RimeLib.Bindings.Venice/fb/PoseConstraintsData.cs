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
	[ContainerType(Alignment: 1,  Flags: 41, Size: 3)]
	public class PoseConstraintsData : FrostbiteContainer
	{
		[ContainerField(Name: "StandPose", Offset: 0, NameHash: 3580661600, Flags: 49325), LayoutImmutable, Blittable]
		public bool StandPose { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "CrouchPose", Offset: 1, NameHash: 1318089740, Flags: 49325), LayoutImmutable, Blittable]
		public bool CrouchPose { get; set; } // 0x1 (1)
		
		[ContainerField(Name: "PronePose", Offset: 2, NameHash: 3841962, Flags: 49325), LayoutImmutable, Blittable]
		public bool PronePose { get; set; } // 0x2 (2)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3580661600:
					StandPose = (bool) p_Value;
					break;

				case 1318089740:
					CrouchPose = (bool) p_Value;
					break;

				case 3841962:
					PronePose = (bool) p_Value;
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
				case 3580661600:
					return StandPose;

				case 1318089740:
					return CrouchPose;

				case 3841962:
					return PronePose;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3580661600:
					return typeof(PoseConstraintsData).GetProperty(nameof(StandPose));

				case 1318089740:
					return typeof(PoseConstraintsData).GetProperty(nameof(CrouchPose));

				case 3841962:
					return typeof(PoseConstraintsData).GetProperty(nameof(PronePose));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
