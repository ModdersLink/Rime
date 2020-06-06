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
	public class StaticEnlightenData : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<TextureAsset> StaticIrradianceChromaTexture { get; set; } = new CtrRef<TextureAsset>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<TextureAsset> StaticIrradianceLumaTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<TextureAsset> StaticDirectionTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1710622452:
					StaticIrradianceChromaTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 125414651:
					StaticIrradianceLumaTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2658604391:
					StaticDirectionTexture = (CtrRef<TextureAsset>) p_Value;
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
				case 1710622452:
					return StaticIrradianceChromaTexture;

				case 125414651:
					return StaticIrradianceLumaTexture;

				case 2658604391:
					return StaticDirectionTexture;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1710622452:
					return typeof(StaticEnlightenData).GetProperty(nameof(StaticIrradianceChromaTexture));

				case 125414651:
					return typeof(StaticEnlightenData).GetProperty(nameof(StaticIrradianceLumaTexture));

				case 2658604391:
					return typeof(StaticEnlightenData).GetProperty(nameof(StaticDirectionTexture));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
