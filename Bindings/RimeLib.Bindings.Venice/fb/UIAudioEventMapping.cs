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
	public class UIAudioEventMapping : FrostbiteContainer
	{
		[ContainerField(Name: "EventName", Offset: 0, NameHash: 4132530094, Flags: 16509), LayoutImmutable]
		public string EventName { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "SoundAsset", Offset: 4, NameHash: 112978902, Flags: 53)]
		public CtrRef<SoundAsset> SoundAsset { get; set; } = new CtrRef<SoundAsset>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4132530094:
					EventName = (string) p_Value;
					break;

				case 112978902:
					SoundAsset = (CtrRef<SoundAsset>) p_Value;
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
				case 4132530094:
					return EventName;

				case 112978902:
					return SoundAsset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4132530094:
					return typeof(UIAudioEventMapping).GetProperty(nameof(EventName));

				case 112978902:
					return typeof(UIAudioEventMapping).GetProperty(nameof(SoundAsset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
