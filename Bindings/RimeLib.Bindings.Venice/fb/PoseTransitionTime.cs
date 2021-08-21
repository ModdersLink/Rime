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
	public class PoseTransitionTime : FrostbiteContainer
	{
		[ContainerField(Name: "ToPose", Offset: 0, NameHash: 3237354551, Flags: 137)]
		public CharacterPoseType ToPose { get; set; } = new CharacterPoseType(); // 0x0 (0)
		
		[ContainerField(Name: "TransitionTime", Offset: 4, NameHash: 3976931807, Flags: 49469), LayoutImmutable, Blittable]
		public float TransitionTime { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3237354551:
						ToPose = (CharacterPoseType) Enum.ToObject(typeof(CharacterPoseType), p_Value);
					break;

				case 3976931807:
					TransitionTime = (float) p_Value;
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
				case 3237354551:
					return ToPose;

				case 3976931807:
					return TransitionTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3237354551:
					return typeof(PoseTransitionTime).GetProperty(nameof(ToPose));

				case 3976931807:
					return typeof(PoseTransitionTime).GetProperty(nameof(TransitionTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
