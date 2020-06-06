///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UITextDatabase : 
		Asset
	{
		[ContainerField(12)]
		public LanguageFormat Language { get; set; } = new LanguageFormat(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public GUID BinaryChunk { get; set; } // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public uint BinaryChunkSize { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public GUID HistogramChunk { get; set; } // 0x24 (36)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public uint HistogramChunkSize { get; set; } // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3872303031:
					Language = (LanguageFormat) Enum.ToObject(typeof(LanguageFormat), p_Value);
					break;

				case 1121887089:
					BinaryChunk = (GUID) p_Value;
					break;

				case 261197236:
					BinaryChunkSize = (uint) p_Value;
					break;

				case 423724782:
					HistogramChunk = (GUID) p_Value;
					break;

				case 1536427179:
					HistogramChunkSize = (uint) p_Value;
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
				case 3872303031:
					return Language;

				case 1121887089:
					return BinaryChunk;

				case 261197236:
					return BinaryChunkSize;

				case 423724782:
					return HistogramChunk;

				case 1536427179:
					return HistogramChunkSize;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3872303031:
					return typeof(UITextDatabase).GetProperty(nameof(Language));

				case 1121887089:
					return typeof(UITextDatabase).GetProperty(nameof(BinaryChunk));

				case 261197236:
					return typeof(UITextDatabase).GetProperty(nameof(BinaryChunkSize));

				case 423724782:
					return typeof(UITextDatabase).GetProperty(nameof(HistogramChunk));

				case 1536427179:
					return typeof(UITextDatabase).GetProperty(nameof(HistogramChunkSize));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
