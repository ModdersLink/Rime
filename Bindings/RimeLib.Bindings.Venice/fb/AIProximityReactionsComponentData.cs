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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(176), ContainerClass]
	public class AIProximityReactionsComponentData : 
		ComponentData
	{
		protected AIProximityReactionsBinding m_Binding = new AIProximityReactionsBinding();
		[ContainerField(96), MemberInfoFlag(41), ContainerFieldNameHash(2590060228)]
		public AIProximityReactionsBinding Binding { get { return m_Binding; } set { if (OnPropertyChanging("AIProximityReactionsComponentData." + nameof(Binding), this, m_Binding, value)) m_Binding = value; } } // 0x60 (96)
		
		protected float m_MinExplosionImpulseForce = new float();
		[ContainerField(152), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1140171772)]
		public float MinExplosionImpulseForce { get { return m_MinExplosionImpulseForce; } set { if (OnPropertyChanging("AIProximityReactionsComponentData." + nameof(MinExplosionImpulseForce), this, m_MinExplosionImpulseForce, value)) m_MinExplosionImpulseForce = value; } } // 0x98 (152)
		
		protected float m_MaxExplosionLookDistance = new float();
		[ContainerField(156), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(322238752)]
		public float MaxExplosionLookDistance { get { return m_MaxExplosionLookDistance; } set { if (OnPropertyChanging("AIProximityReactionsComponentData." + nameof(MaxExplosionLookDistance), this, m_MaxExplosionLookDistance, value)) m_MaxExplosionLookDistance = value; } } // 0x9C (156)
		
		protected float m_FireReactionDistance = new float();
		[ContainerField(160), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2123733591)]
		public float FireReactionDistance { get { return m_FireReactionDistance; } set { if (OnPropertyChanging("AIProximityReactionsComponentData." + nameof(FireReactionDistance), this, m_FireReactionDistance, value)) m_FireReactionDistance = value; } } // 0xA0 (160)
		
		protected bool m_Enabled = new bool();
		[ContainerField(164), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2662400)]
		public bool Enabled { get { return m_Enabled; } set { if (OnPropertyChanging("AIProximityReactionsComponentData." + nameof(Enabled), this, m_Enabled, value)) m_Enabled = value; } } // 0xA4 (164)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2590060228:
					Binding = (AIProximityReactionsBinding) p_Value;
					break;

				case 1140171772:
					MinExplosionImpulseForce = (float) p_Value;
					break;

				case 322238752:
					MaxExplosionLookDistance = (float) p_Value;
					break;

				case 2123733591:
					FireReactionDistance = (float) p_Value;
					break;

				case 2662400:
					Enabled = (bool) p_Value;
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
				case 2590060228:
					return Binding;

				case 1140171772:
					return MinExplosionImpulseForce;

				case 322238752:
					return MaxExplosionLookDistance;

				case 2123733591:
					return FireReactionDistance;

				case 2662400:
					return Enabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2590060228:
					return typeof(AIProximityReactionsComponentData).GetProperty(nameof(Binding));

				case 1140171772:
					return typeof(AIProximityReactionsComponentData).GetProperty(nameof(MinExplosionImpulseForce));

				case 322238752:
					return typeof(AIProximityReactionsComponentData).GetProperty(nameof(MaxExplosionLookDistance));

				case 2123733591:
					return typeof(AIProximityReactionsComponentData).GetProperty(nameof(FireReactionDistance));

				case 2662400:
					return typeof(AIProximityReactionsComponentData).GetProperty(nameof(Enabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
