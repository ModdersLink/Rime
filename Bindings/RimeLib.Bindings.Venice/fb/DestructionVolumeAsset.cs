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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class DestructionVolumeAsset : 
		Asset
	{
		protected CtrRef<TextureAsset> m_DiffuseAtlas = new CtrRef<TextureAsset>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(4294572704), ContainerCtrRef]
		public CtrRef<TextureAsset> DiffuseAtlas { get { return m_DiffuseAtlas; } set { if (OnPropertyChanging("DestructionVolumeAsset." + nameof(DiffuseAtlas), this, m_DiffuseAtlas, value)) m_DiffuseAtlas = value; } } // 0xC (12)
		
		protected CtrRef<TextureAsset> m_NormalmapAtlas = new CtrRef<TextureAsset>();
		[ContainerField(16), MemberInfoFlag(53), ContainerFieldNameHash(529589985), ContainerCtrRef]
		public CtrRef<TextureAsset> NormalmapAtlas { get { return m_NormalmapAtlas; } set { if (OnPropertyChanging("DestructionVolumeAsset." + nameof(NormalmapAtlas), this, m_NormalmapAtlas, value)) m_NormalmapAtlas = value; } } // 0x10 (16)
		
		protected float m_AtlasTextureScale = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3639310441)]
		public float AtlasTextureScale { get { return m_AtlasTextureScale; } set { if (OnPropertyChanging("DestructionVolumeAsset." + nameof(AtlasTextureScale), this, m_AtlasTextureScale, value)) m_AtlasTextureScale = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4294572704:
					DiffuseAtlas = (CtrRef<TextureAsset>) p_Value;
					break;

				case 529589985:
					NormalmapAtlas = (CtrRef<TextureAsset>) p_Value;
					break;

				case 3639310441:
					AtlasTextureScale = (float) p_Value;
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
				case 4294572704:
					return DiffuseAtlas;

				case 529589985:
					return NormalmapAtlas;

				case 3639310441:
					return AtlasTextureScale;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4294572704:
					return typeof(DestructionVolumeAsset).GetProperty(nameof(DiffuseAtlas));

				case 529589985:
					return typeof(DestructionVolumeAsset).GetProperty(nameof(NormalmapAtlas));

				case 3639310441:
					return typeof(DestructionVolumeAsset).GetProperty(nameof(AtlasTextureScale));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
