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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(12), ContainerClass]
	public class TextureUnlockPartData : 
		DataContainer
	{
		protected CtrRef<TextureReference> m_TextureReference = new CtrRef<TextureReference>();
		[ContainerField(8), MemberInfoFlag(53), ContainerFieldNameHash(2751309329), ContainerCtrRef]
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
