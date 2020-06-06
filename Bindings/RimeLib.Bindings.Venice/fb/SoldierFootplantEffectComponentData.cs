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
	public class SoldierFootplantEffectComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<MaterialContainerPair> FootMaterialPair { get; set; } = new CtrRef<MaterialContainerPair>(); // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float HeightOverGroundThreshold { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float FootVelocityThreshold { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float LodDistance { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public bool FullFootplantingEnabled { get; set; } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3867460534:
					FootMaterialPair = (CtrRef<MaterialContainerPair>) p_Value;
					break;

				case 1421561158:
					HeightOverGroundThreshold = (float) p_Value;
					break;

				case 4147690487:
					FootVelocityThreshold = (float) p_Value;
					break;

				case 3054638721:
					LodDistance = (float) p_Value;
					break;

				case 2514567430:
					FullFootplantingEnabled = (bool) p_Value;
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
				case 3867460534:
					return FootMaterialPair;

				case 1421561158:
					return HeightOverGroundThreshold;

				case 4147690487:
					return FootVelocityThreshold;

				case 3054638721:
					return LodDistance;

				case 2514567430:
					return FullFootplantingEnabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3867460534:
					return typeof(SoldierFootplantEffectComponentData).GetProperty(nameof(FootMaterialPair));

				case 1421561158:
					return typeof(SoldierFootplantEffectComponentData).GetProperty(nameof(HeightOverGroundThreshold));

				case 4147690487:
					return typeof(SoldierFootplantEffectComponentData).GetProperty(nameof(FootVelocityThreshold));

				case 3054638721:
					return typeof(SoldierFootplantEffectComponentData).GetProperty(nameof(LodDistance));

				case 2514567430:
					return typeof(SoldierFootplantEffectComponentData).GetProperty(nameof(FullFootplantingEnabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
