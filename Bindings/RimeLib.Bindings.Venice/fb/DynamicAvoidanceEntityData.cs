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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(48), ContainerClass]
	public class DynamicAvoidanceEntityData : 
		EntityData
	{
		protected DynamicAvoidanceMode m_RepelOthers = new DynamicAvoidanceMode();
		[ContainerField(12), MemberInfoFlag(137), ContainerFieldNameHash(2680634556)]
		public DynamicAvoidanceMode RepelOthers { get { return m_RepelOthers; } set { if (OnPropertyChanging("DynamicAvoidanceEntityData." + nameof(RepelOthers), this, m_RepelOthers, value)) m_RepelOthers = value; } } // 0xC (12)
		
		protected DynamicAvoidanceMode m_ReportPredictedCollision = new DynamicAvoidanceMode();
		[ContainerField(16), MemberInfoFlag(137), ContainerFieldNameHash(690685961)]
		public DynamicAvoidanceMode ReportPredictedCollision { get { return m_ReportPredictedCollision; } set { if (OnPropertyChanging("DynamicAvoidanceEntityData." + nameof(ReportPredictedCollision), this, m_ReportPredictedCollision, value)) m_ReportPredictedCollision = value; } } // 0x10 (16)
		
		protected float m_CollisionRadius = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1874505603)]
		public float CollisionRadius { get { return m_CollisionRadius; } set { if (OnPropertyChanging("DynamicAvoidanceEntityData." + nameof(CollisionRadius), this, m_CollisionRadius, value)) m_CollisionRadius = value; } } // 0x14 (20)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(24), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("DynamicAvoidanceEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x18 (24)
		
		protected AntDynamicAvoidanceBinding m_AntBinding = new AntDynamicAvoidanceBinding();
		[ContainerField(28), MemberInfoFlag(41), ContainerFieldNameHash(2293128415)]
		public AntDynamicAvoidanceBinding AntBinding { get { return m_AntBinding; } set { if (OnPropertyChanging("DynamicAvoidanceEntityData." + nameof(AntBinding), this, m_AntBinding, value)) m_AntBinding = value; } } // 0x1C (28)
		
		protected bool m_AffectedByRepellingForce = new bool();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2759712179)]
		public bool AffectedByRepellingForce { get { return m_AffectedByRepellingForce; } set { if (OnPropertyChanging("DynamicAvoidanceEntityData." + nameof(AffectedByRepellingForce), this, m_AffectedByRepellingForce, value)) m_AffectedByRepellingForce = value; } } // 0x2C (44)
		
		protected bool m_PredictedByOthers = new bool();
		[ContainerField(45), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1713837653)]
		public bool PredictedByOthers { get { return m_PredictedByOthers; } set { if (OnPropertyChanging("DynamicAvoidanceEntityData." + nameof(PredictedByOthers), this, m_PredictedByOthers, value)) m_PredictedByOthers = value; } } // 0x2D (45)
		
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
