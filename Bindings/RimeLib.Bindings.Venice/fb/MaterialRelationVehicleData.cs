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
	public class MaterialRelationVehicleData : 
		PhysicsMaterialRelationPropertyData
	{
		[ContainerField(8)]
		public CtrRef<EffectBlueprint> ChassiEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<EffectBlueprint> TrackEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<EffectBlueprint> WheelEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<EffectBlueprint> GroundEffect { get; set; } = new CtrRef<EffectBlueprint>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2206681905:
					ChassiEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 1006696637:
					TrackEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 3303703137:
					WheelEffect = (CtrRef<EffectBlueprint>) p_Value;
					break;

				case 2819688663:
					GroundEffect = (CtrRef<EffectBlueprint>) p_Value;
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
				case 2206681905:
					return ChassiEffect;

				case 1006696637:
					return TrackEffect;

				case 3303703137:
					return WheelEffect;

				case 2819688663:
					return GroundEffect;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2206681905:
					return typeof(MaterialRelationVehicleData).GetProperty(nameof(ChassiEffect));

				case 1006696637:
					return typeof(MaterialRelationVehicleData).GetProperty(nameof(TrackEffect));

				case 3303703137:
					return typeof(MaterialRelationVehicleData).GetProperty(nameof(WheelEffect));

				case 2819688663:
					return typeof(MaterialRelationVehicleData).GetProperty(nameof(GroundEffect));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
