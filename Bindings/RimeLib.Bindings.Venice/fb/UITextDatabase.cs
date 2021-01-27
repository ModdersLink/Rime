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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 56)]
	public class UITextDatabase : 
		Asset
	{
		protected LanguageFormat m_Language = new LanguageFormat();
		[ContainerField(Name: "Language", Offset: 12, NameHash: 3872303031, Flags: 137)]
		public LanguageFormat Language { get { return m_Language; } set { if (OnPropertyChanging("UITextDatabase." + nameof(Language), this, m_Language, value)) m_Language = value; } } // 0xC (12)
		
		protected GUID m_BinaryChunk = new GUID();
		[ContainerField(Name: "BinaryChunk", Offset: 16, NameHash: 1121887089, Flags: 49501), LayoutImmutable, Blittable]
		public GUID BinaryChunk { get { return m_BinaryChunk; } set { if (OnPropertyChanging("UITextDatabase." + nameof(BinaryChunk), this, m_BinaryChunk, value)) m_BinaryChunk = value; } } // 0x10 (16)
		
		protected uint m_BinaryChunkSize = new uint();
		[ContainerField(Name: "BinaryChunkSize", Offset: 32, NameHash: 261197236, Flags: 49421), LayoutImmutable, Blittable]
		public uint BinaryChunkSize { get { return m_BinaryChunkSize; } set { if (OnPropertyChanging("UITextDatabase." + nameof(BinaryChunkSize), this, m_BinaryChunkSize, value)) m_BinaryChunkSize = value; } } // 0x20 (32)
		
		protected GUID m_HistogramChunk = new GUID();
		[ContainerField(Name: "HistogramChunk", Offset: 36, NameHash: 423724782, Flags: 49501), LayoutImmutable, Blittable]
		public GUID HistogramChunk { get { return m_HistogramChunk; } set { if (OnPropertyChanging("UITextDatabase." + nameof(HistogramChunk), this, m_HistogramChunk, value)) m_HistogramChunk = value; } } // 0x24 (36)
		
		protected uint m_HistogramChunkSize = new uint();
		[ContainerField(Name: "HistogramChunkSize", Offset: 52, NameHash: 1536427179, Flags: 49421), LayoutImmutable, Blittable]
		public uint HistogramChunkSize { get { return m_HistogramChunkSize; } set { if (OnPropertyChanging("UITextDatabase." + nameof(HistogramChunkSize), this, m_HistogramChunkSize, value)) m_HistogramChunkSize = value; } } // 0x34 (52)
		
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
