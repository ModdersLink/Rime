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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class UIDistanceFieldAsset : 
		Asset
	{
		protected CtrRef<TextureAsset> m_DistanceFieldTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "DistanceFieldTexture", Offset: 12, NameHash: 62920603, Flags: 53)]
		public CtrRef<TextureAsset> DistanceFieldTexture { get { return m_DistanceFieldTexture; } set { if (OnPropertyChanging("UIDistanceFieldAsset." + nameof(DistanceFieldTexture), this, m_DistanceFieldTexture, value)) m_DistanceFieldTexture = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 62920603:
					DistanceFieldTexture = (CtrRef<TextureAsset>) p_Value;
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
				case 62920603:
					return DistanceFieldTexture;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 62920603:
					return typeof(UIDistanceFieldAsset).GetProperty(nameof(DistanceFieldTexture));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
