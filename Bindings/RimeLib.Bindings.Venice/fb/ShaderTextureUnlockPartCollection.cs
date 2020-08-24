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
	public class ShaderTextureUnlockPartCollection : 
		ShaderCustomizationUnlockPartCollection
	{
		protected CtrRef<TextureReference> m_DefaultTextureReference = new CtrRef<TextureReference>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(796555962), ContainerCtrRef]
		public CtrRef<TextureReference> DefaultTextureReference { get { return m_DefaultTextureReference; } set { if (OnPropertyChanging("ShaderTextureUnlockPartCollection." + nameof(DefaultTextureReference), this, m_DefaultTextureReference, value)) m_DefaultTextureReference = value; } } // 0x14 (20)
		
		protected RefArray<TextureUnlockPartData> m_UnlockParts = new RefArray<TextureUnlockPartData>();
		[ContainerField(24), MemberInfoFlag(65), ContainerFieldNameHash(4116003953), ContainerRefArray]
		public RefArray<TextureUnlockPartData> UnlockParts { get { return m_UnlockParts; } set { if (OnPropertyChanging("ShaderTextureUnlockPartCollection." + nameof(UnlockParts), this, m_UnlockParts, value)) m_UnlockParts = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 796555962:
					DefaultTextureReference = (CtrRef<TextureReference>) p_Value;
					break;

				case 4116003953:
					UnlockParts = (RefArray<TextureUnlockPartData>) p_Value;
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
				case 796555962:
					return DefaultTextureReference;

				case 4116003953:
					return UnlockParts;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 796555962:
					return typeof(ShaderTextureUnlockPartCollection).GetProperty(nameof(DefaultTextureReference));

				case 4116003953:
					return typeof(ShaderTextureUnlockPartCollection).GetProperty(nameof(UnlockParts));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
