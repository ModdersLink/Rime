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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class UnlockableTextureCollection : 
		DataContainer
	{
		protected CtrRef<TextureAsset> m_DefaultValue = new CtrRef<TextureAsset>();
		[ContainerField(Name: "DefaultValue", Offset: 8, NameHash: 2066049125, Flags: 53)]
		public CtrRef<TextureAsset> DefaultValue { get { return m_DefaultValue; } set { if (OnPropertyChanging("UnlockableTextureCollection." + nameof(DefaultValue), this, m_DefaultValue, value)) m_DefaultValue = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2066049125:
					DefaultValue = (CtrRef<TextureAsset>) p_Value;
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
				case 2066049125:
					return DefaultValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2066049125:
					return typeof(UnlockableTextureCollection).GetProperty(nameof(DefaultValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
