///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class DestructionVolumeAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<TextureAsset> DiffuseAtlas { get; set; } = new CtrRef<TextureAsset>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<TextureAsset> NormalmapAtlas { get; set; } = new CtrRef<TextureAsset>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float AtlasTextureScale { get; set; } // 0x14 (20)
		
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
