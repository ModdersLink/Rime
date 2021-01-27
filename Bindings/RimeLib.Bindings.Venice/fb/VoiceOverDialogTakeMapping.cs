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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class VoiceOverDialogTakeMapping : FrostbiteContainer
	{
		[ContainerField(Name: "TakeControlMin", Offset: 0, NameHash: 3913807443, Flags: 49469), LayoutImmutable, Blittable]
		public float TakeControlMin { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "TakeControlMax", Offset: 4, NameHash: 3913807181, Flags: 49469), LayoutImmutable, Blittable]
		public float TakeControlMax { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "TakeIndex", Offset: 8, NameHash: 3325975776, Flags: 49341), LayoutImmutable, Blittable]
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
