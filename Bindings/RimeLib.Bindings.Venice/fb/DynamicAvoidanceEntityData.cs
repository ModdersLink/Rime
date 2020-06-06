///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class DynamicAvoidanceEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public DynamicAvoidanceMode RepelOthers { get; set; } = new DynamicAvoidanceMode(); // 0xC (12)
		
		[ContainerField(16)]
		public DynamicAvoidanceMode ReportPredictedCollision { get; set; } = new DynamicAvoidanceMode(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float CollisionRadius { get; set; } // 0x14 (20)
		
		[ContainerField(24)]
		public Realm Realm { get; set; } = new Realm(); // 0x18 (24)
		
		[ContainerField(28)]
		public AntDynamicAvoidanceBinding AntBinding { get; set; } = new AntDynamicAvoidanceBinding(); // 0x1C (28)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool AffectedByRepellingForce { get; set; } // 0x2C (44)
		
		[ContainerField(45), LayoutImmutable, Blittable]
		public bool PredictedByOthers { get; set; } // 0x2D (45)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2680634556:
					RepelOthers = (DynamicAvoidanceMode) Enum.ToObject(typeof(DynamicAvoidanceMode), p_Value);
					break;

				case 690685961:
					ReportPredictedCollision = (DynamicAvoidanceMode) Enum.ToObject(typeof(DynamicAvoidanceMode), p_Value);
					break;

				case 1874505603:
					CollisionRadius = (float) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2293128415:
					AntBinding = (AntDynamicAvoidanceBinding) p_Value;
					break;

				case 2759712179:
					AffectedByRepellingForce = (bool) p_Value;
					break;

				case 1713837653:
					PredictedByOthers = (bool) p_Value;
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
				case 2680634556:
					return RepelOthers;

				case 690685961:
					return ReportPredictedCollision;

				case 1874505603:
					return CollisionRadius;

				case 229961746:
					return Realm;

				case 2293128415:
					return AntBinding;

				case 2759712179:
					return AffectedByRepellingForce;

				case 1713837653:
					return PredictedByOthers;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2680634556:
					return typeof(DynamicAvoidanceEntityData).GetProperty(nameof(RepelOthers));

				case 690685961:
					return typeof(DynamicAvoidanceEntityData).GetProperty(nameof(ReportPredictedCollision));

				case 1874505603:
					return typeof(DynamicAvoidanceEntityData).GetProperty(nameof(CollisionRadius));

				case 229961746:
					return typeof(DynamicAvoidanceEntityData).GetProperty(nameof(Realm));

				case 2293128415:
					return typeof(DynamicAvoidanceEntityData).GetProperty(nameof(AntBinding));

				case 2759712179:
					return typeof(DynamicAvoidanceEntityData).GetProperty(nameof(AffectedByRepellingForce));

				case 1713837653:
					return typeof(DynamicAvoidanceEntityData).GetProperty(nameof(PredictedByOthers));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
