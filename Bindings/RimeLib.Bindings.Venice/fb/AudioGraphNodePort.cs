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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class AudioGraphNodePort : FrostbiteContainer
	{
		[ContainerField(Name: "UnconnectedValue", Offset: 0, NameHash: 1858729834, Flags: 49469), LayoutImmutable, Blittable]
		public float UnconnectedValue { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "ValueIndex", Offset: 4, NameHash: 2085408208, Flags: 49389), LayoutImmutable, Blittable]
		public ushort ValueIndex { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "IsConnected", Offset: 6, NameHash: 292566976, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsConnected { get; set; } // 0x6 (6)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1858729834:
					UnconnectedValue = (float) p_Value;
					break;

				case 2085408208:
					ValueIndex = (ushort) p_Value;
					break;

				case 292566976:
					IsConnected = (bool) p_Value;
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
				case 1858729834:
					return UnconnectedValue;

				case 2085408208:
					return ValueIndex;

				case 292566976:
					return IsConnected;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1858729834:
					return typeof(AudioGraphNodePort).GetProperty(nameof(UnconnectedValue));

				case 2085408208:
					return typeof(AudioGraphNodePort).GetProperty(nameof(ValueIndex));

				case 292566976:
					return typeof(AudioGraphNodePort).GetProperty(nameof(IsConnected));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
