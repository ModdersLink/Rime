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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 20)]
	public class SoundDataChunk : FrostbiteContainer
	{
		[ContainerField(Name: "ChunkId", Offset: 0, NameHash: 4097216883, Flags: 49501), LayoutImmutable, Blittable]
		public GUID ChunkId { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "ChunkSize", Offset: 16, NameHash: 3692630139, Flags: 49421), LayoutImmutable, Blittable]
		public uint ChunkSize { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4097216883:
					ChunkId = (GUID) p_Value;
					break;

				case 3692630139:
					ChunkSize = (uint) p_Value;
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
				case 4097216883:
					return ChunkId;

				case 3692630139:
					return ChunkSize;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4097216883:
					return typeof(SoundDataChunk).GetProperty(nameof(ChunkId));

				case 3692630139:
					return typeof(SoundDataChunk).GetProperty(nameof(ChunkSize));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
