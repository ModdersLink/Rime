///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SoldierDecalComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<DecalTemplateData> SplashDecal { get; set; } = new CtrRef<DecalTemplateData>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float SplashRayLength { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public CtrRef<DecalTemplateData> PoolDecal { get; set; } = new CtrRef<DecalTemplateData>(); // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float PoolRayYOffset { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float PoolRayLength { get; set; } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2194140991:
					SplashDecal = (CtrRef<DecalTemplateData>) p_Value;
					break;

				case 1743765414:
					SplashRayLength = (float) p_Value;
					break;

				case 3686889142:
					PoolDecal = (CtrRef<DecalTemplateData>) p_Value;
					break;

				case 41417415:
					PoolRayYOffset = (float) p_Value;
					break;

				case 3617868719:
					PoolRayLength = (float) p_Value;
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
				case 2194140991:
					return SplashDecal;

				case 1743765414:
					return SplashRayLength;

				case 3686889142:
					return PoolDecal;

				case 41417415:
					return PoolRayYOffset;

				case 3617868719:
					return PoolRayLength;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2194140991:
					return typeof(SoldierDecalComponentData).GetProperty(nameof(SplashDecal));

				case 1743765414:
					return typeof(SoldierDecalComponentData).GetProperty(nameof(SplashRayLength));

				case 3686889142:
					return typeof(SoldierDecalComponentData).GetProperty(nameof(PoolDecal));

				case 41417415:
					return typeof(SoldierDecalComponentData).GetProperty(nameof(PoolRayYOffset));

				case 3617868719:
					return typeof(SoldierDecalComponentData).GetProperty(nameof(PoolRayLength));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
