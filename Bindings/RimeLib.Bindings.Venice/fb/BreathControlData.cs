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
	public class BreathControlData : 
		DataContainer
	{
		protected float m_BreathControlTime = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4153846207)]
		public float BreathControlTime { get { return m_BreathControlTime; } set { if (OnPropertyChanging("BreathControlData." + nameof(BreathControlTime), this, m_BreathControlTime, value)) m_BreathControlTime = value; } } // 0x8 (8)
		
		protected float m_BreathControlReleaseTime = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1085847638)]
		public float BreathControlReleaseTime { get { return m_BreathControlReleaseTime; } set { if (OnPropertyChanging("BreathControlData." + nameof(BreathControlReleaseTime), this, m_BreathControlReleaseTime, value)) m_BreathControlReleaseTime = value; } } // 0xC (12)
		
		protected float m_BreathControlPenaltyMultiplier = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(735731002)]
		public float BreathControlPenaltyMultiplier { get { return m_BreathControlPenaltyMultiplier; } set { if (OnPropertyChanging("BreathControlData." + nameof(BreathControlPenaltyMultiplier), this, m_BreathControlPenaltyMultiplier, value)) m_BreathControlPenaltyMultiplier = value; } } // 0x10 (16)
		
		protected float m_BreathControlPenaltyTimeout = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3387044330)]
		public float BreathControlPenaltyTimeout { get { return m_BreathControlPenaltyTimeout; } set { if (OnPropertyChanging("BreathControlData." + nameof(BreathControlPenaltyTimeout), this, m_BreathControlPenaltyTimeout, value)) m_BreathControlPenaltyTimeout = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4153846207:
					BreathControlTime = (float) p_Value;
					break;

				case 1085847638:
					BreathControlReleaseTime = (float) p_Value;
					break;

				case 735731002:
					BreathControlPenaltyMultiplier = (float) p_Value;
					break;

				case 3387044330:
					BreathControlPenaltyTimeout = (float) p_Value;
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
				case 4153846207:
					return BreathControlTime;

				case 1085847638:
					return BreathControlReleaseTime;

				case 735731002:
					return BreathControlPenaltyMultiplier;

				case 3387044330:
					return BreathControlPenaltyTimeout;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4153846207:
					return typeof(BreathControlData).GetProperty(nameof(BreathControlTime));

				case 1085847638:
					return typeof(BreathControlData).GetProperty(nameof(BreathControlReleaseTime));

				case 735731002:
					return typeof(BreathControlData).GetProperty(nameof(BreathControlPenaltyMultiplier));

				case 3387044330:
					return typeof(BreathControlData).GetProperty(nameof(BreathControlPenaltyTimeout));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
