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
	public class MixerPresetNodeData : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<AudioGraphNodeData> Node { get; set; } = new CtrRef<AudioGraphNodeData>(); // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Value { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088947621:
					Node = (CtrRef<AudioGraphNodeData>) p_Value;
					break;

				case 225375086:
					Value = (float) p_Value;
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
				case 2088947621:
					return Node;

				case 225375086:
					return Value;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088947621:
					return typeof(MixerPresetNodeData).GetProperty(nameof(Node));

				case 225375086:
					return typeof(MixerPresetNodeData).GetProperty(nameof(Value));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
