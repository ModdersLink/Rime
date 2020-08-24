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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class TextureReference : 
		Asset
	{
		protected CtrRef<TextureAsset> m_Texture = new CtrRef<TextureAsset>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(3185041626), ContainerCtrRef]
		public CtrRef<TextureAsset> Texture { get { return m_Texture; } set { if (OnPropertyChanging("TextureReference." + nameof(Texture), this, m_Texture, value)) m_Texture = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3185041626:
					Texture = (CtrRef<TextureAsset>) p_Value;
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
				case 3185041626:
					return Texture;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3185041626:
					return typeof(TextureReference).GetProperty(nameof(Texture));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
