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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class SoundGraphPluginConnection : FrostbiteContainer
	{
		[ContainerField(Name: "ConnectionType", Offset: 0, NameHash: 720217643, Flags: 137)]
		public SoundGraphPluginConnectionType ConnectionType { get; set; } = new SoundGraphPluginConnectionType(); // 0x0 (0)
		
		[ContainerField(Name: "Parameters", Offset: 4, NameHash: 3325515039, Flags: 65)]
		public List<SoundGraphPluginConnectionParam> Parameters { get; set; } = new List<SoundGraphPluginConnectionParam>(); // 0x4 (4)
		
		[ContainerField(Name: "Bus", Offset: 8, NameHash: 193448065, Flags: 53)]
		public CtrRef<SoundBusData> Bus { get; set; } = new CtrRef<SoundBusData>(); // 0x8 (8)
		
		[ContainerField(Name: "VoiceIndex", Offset: 12, NameHash: 785984109, Flags: 49341), LayoutImmutable, Blittable]
		public sbyte VoiceIndex { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 720217643:
						ConnectionType = (SoundGraphPluginConnectionType) Enum.ToObject(typeof(SoundGraphPluginConnectionType), p_Value);
					break;

				case 3325515039:
					Parameters = (List<SoundGraphPluginConnectionParam>) p_Value;
					break;

				case 193448065:
					Bus = (CtrRef<SoundBusData>) p_Value;
					break;

				case 785984109:
					VoiceIndex = (sbyte) p_Value;
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
				case 720217643:
					return ConnectionType;

				case 3325515039:
					return Parameters;

				case 193448065:
					return Bus;

				case 785984109:
					return VoiceIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 720217643:
					return typeof(SoundGraphPluginConnection).GetProperty(nameof(ConnectionType));

				case 3325515039:
					return typeof(SoundGraphPluginConnection).GetProperty(nameof(Parameters));

				case 193448065:
					return typeof(SoundGraphPluginConnection).GetProperty(nameof(Bus));

				case 785984109:
					return typeof(SoundGraphPluginConnection).GetProperty(nameof(VoiceIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
