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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class MaterialRelationVehicleData : 
		PhysicsMaterialRelationPropertyData
	{
		protected CtrRef<EffectBlueprint> m_ChassiEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(Name: "ChassiEffect", Offset: 8, NameHash: 2206681905, Flags: 53)]
		public CtrRef<EffectBlueprint> ChassiEffect { get { return m_ChassiEffect; } set { if (OnPropertyChanging("MaterialRelationVehicleData." + nameof(ChassiEffect), this, m_ChassiEffect, value)) m_ChassiEffect = value; } } // 0x8 (8)
		
		protected CtrRef<EffectBlueprint> m_TrackEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(Name: "TrackEffect", Offset: 12, NameHash: 1006696637, Flags: 53)]
		public CtrRef<EffectBlueprint> TrackEffect { get { return m_TrackEffect; } set { if (OnPropertyChanging("MaterialRelationVehicleData." + nameof(TrackEffect), this, m_TrackEffect, value)) m_TrackEffect = value; } } // 0xC (12)
		
		protected CtrRef<EffectBlueprint> m_WheelEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(Name: "WheelEffect", Offset: 16, NameHash: 3303703137, Flags: 53)]
		public CtrRef<EffectBlueprint> WheelEffect { get { return m_WheelEffect; } set { if (OnPropertyChanging("MaterialRelationVehicleData." + nameof(WheelEffect), this, m_WheelEffect, value)) m_WheelEffect = value; } } // 0x10 (16)
		
		protected CtrRef<EffectBlueprint> m_GroundEffect = new CtrRef<EffectBlueprint>();
		[ContainerField(Name: "GroundEffect", Offset: 20, NameHash: 2819688663, Flags: 53)]
		public CtrRef<EffectBlueprint> GroundEffect { get { return m_GroundEffect; } set { if (OnPropertyChanging("MaterialRelationVehicleData." + nameof(GroundEffect), this, m_GroundEffect, value)) m_GroundEffect = value; } } // 0x14 (20)
		
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
