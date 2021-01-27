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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class TextureUnlockPartData : 
		DataContainer
	{
		protected CtrRef<TextureReference> m_TextureReference = new CtrRef<TextureReference>();
		[ContainerField(Name: "TextureReference", Offset: 8, NameHash: 2751309329, Flags: 53)]
		public CtrRef<TextureReference> TextureReference { get { return m_TextureReference; } set { if (OnPropertyChanging("TextureUnlockPartData." + nameof(TextureReference), this, m_TextureReference, value)) m_TextureReference = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2751309329:
					TextureReference = (CtrRef<TextureReference>) p_Value;
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
				case 2751309329:
					return TextureReference;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2751309329:
					return typeof(TextureUnlockPartData).GetProperty(nameof(TextureReference));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
