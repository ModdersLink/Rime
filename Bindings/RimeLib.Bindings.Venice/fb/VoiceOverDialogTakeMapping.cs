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
	public class VoiceOverDialogTakeMapping : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float TakeControlMin { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float TakeControlMax { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49341)]
		public sbyte TakeIndex { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3913807443:
					TakeControlMin = (float) p_Value;
					break;

				case 3913807181:
					TakeControlMax = (float) p_Value;
					break;

				case 3325975776:
					TakeIndex = (sbyte) p_Value;
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
				case 3913807443:
					return TakeControlMin;

				case 3913807181:
					return TakeControlMax;

				case 3325975776:
					return TakeIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3913807443:
					return typeof(VoiceOverDialogTakeMapping).GetProperty(nameof(TakeControlMin));

				case 3913807181:
					return typeof(VoiceOverDialogTakeMapping).GetProperty(nameof(TakeControlMax));

				case 3325975776:
					return typeof(VoiceOverDialogTakeMapping).GetProperty(nameof(TakeIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
