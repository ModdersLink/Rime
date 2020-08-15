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
	[ContainerType(4)]
	public class VehicleVisualCustomizationAsset : 
		Asset
	{
		protected RefArray<ShaderTextureUnlockPartCollection> m_TextureUnlockPartCollections = new RefArray<ShaderTextureUnlockPartCollection>();
		[ContainerField(12), ContainerFieldNameHash(3762069016)]
		public RefArray<ShaderTextureUnlockPartCollection> TextureUnlockPartCollections { get { return m_TextureUnlockPartCollections; } set { if (OnPropertyChanging("VehicleVisualCustomizationAsset." + nameof(TextureUnlockPartCollections), this, m_TextureUnlockPartCollections, value)) m_TextureUnlockPartCollections = value; } } // 0xC (12)
		
		protected RefArray<TextUnlockPartData> m_TextUnlockParts = new RefArray<TextUnlockPartData>();
		[ContainerField(16), ContainerFieldNameHash(1176201452)]
		public RefArray<TextUnlockPartData> TextUnlockParts { get { return m_TextUnlockParts; } set { if (OnPropertyChanging("VehicleVisualCustomizationAsset." + nameof(TextUnlockParts), this, m_TextUnlockParts, value)) m_TextUnlockParts = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3762069016:
					TextureUnlockPartCollections = (RefArray<ShaderTextureUnlockPartCollection>) p_Value;
					break;

				case 1176201452:
					TextUnlockParts = (RefArray<TextUnlockPartData>) p_Value;
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
				case 3762069016:
					return TextureUnlockPartCollections;

				case 1176201452:
					return TextUnlockParts;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3762069016:
					return typeof(VehicleVisualCustomizationAsset).GetProperty(nameof(TextureUnlockPartCollections));

				case 1176201452:
					return typeof(VehicleVisualCustomizationAsset).GetProperty(nameof(TextUnlockParts));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
