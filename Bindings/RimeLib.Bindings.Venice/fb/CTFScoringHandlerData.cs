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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class CTFScoringHandlerData : 
		ScoringHandlerData
	{
		protected int m_MaxTeams = new int();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(401391615)]
		public int MaxTeams { get { return m_MaxTeams; } set { if (OnPropertyChanging("CTFScoringHandlerData." + nameof(MaxTeams), this, m_MaxTeams, value)) m_MaxTeams = value; } } // 0x8 (8)
		
		protected float m_PickUpAssistRadius = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1365389190)]
		public float PickUpAssistRadius { get { return m_PickUpAssistRadius; } set { if (OnPropertyChanging("CTFScoringHandlerData." + nameof(PickUpAssistRadius), this, m_PickUpAssistRadius, value)) m_PickUpAssistRadius = value; } } // 0xC (12)
		
		protected float m_CaptureAssistRadius = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2950263830)]
		public float CaptureAssistRadius { get { return m_CaptureAssistRadius; } set { if (OnPropertyChanging("CTFScoringHandlerData." + nameof(CaptureAssistRadius), this, m_CaptureAssistRadius, value)) m_CaptureAssistRadius = value; } } // 0x10 (16)
		
		protected float m_EnemyThreatRadius = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3061043225)]
		public float EnemyThreatRadius { get { return m_EnemyThreatRadius; } set { if (OnPropertyChanging("CTFScoringHandlerData." + nameof(EnemyThreatRadius), this, m_EnemyThreatRadius, value)) m_EnemyThreatRadius = value; } } // 0x14 (20)
		
		protected float m_EnemySuppressionTimeout = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1983551709)]
		public float EnemySuppressionTimeout { get { return m_EnemySuppressionTimeout; } set { if (OnPropertyChanging("CTFScoringHandlerData." + nameof(EnemySuppressionTimeout), this, m_EnemySuppressionTimeout, value)) m_EnemySuppressionTimeout = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 401391615:
					MaxTeams = (int) p_Value;
					break;

				case 1365389190:
					PickUpAssistRadius = (float) p_Value;
					break;

				case 2950263830:
					CaptureAssistRadius = (float) p_Value;
					break;

				case 3061043225:
					EnemyThreatRadius = (float) p_Value;
					break;

				case 1983551709:
					EnemySuppressionTimeout = (float) p_Value;
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
				case 401391615:
					return MaxTeams;

				case 1365389190:
					return PickUpAssistRadius;

				case 2950263830:
					return CaptureAssistRadius;

				case 3061043225:
					return EnemyThreatRadius;

				case 1983551709:
					return EnemySuppressionTimeout;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 401391615:
					return typeof(CTFScoringHandlerData).GetProperty(nameof(MaxTeams));

				case 1365389190:
					return typeof(CTFScoringHandlerData).GetProperty(nameof(PickUpAssistRadius));

				case 2950263830:
					return typeof(CTFScoringHandlerData).GetProperty(nameof(CaptureAssistRadius));

				case 3061043225:
					return typeof(CTFScoringHandlerData).GetProperty(nameof(EnemyThreatRadius));

				case 1983551709:
					return typeof(CTFScoringHandlerData).GetProperty(nameof(EnemySuppressionTimeout));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
