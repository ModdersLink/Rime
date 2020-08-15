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
	[ContainerType(4)]
	public class PlayerInputTriggerEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(12), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("PlayerInputTriggerEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected EntryInputActionEnum m_EntryInputActions = new EntryInputActionEnum();
		[ContainerField(16), ContainerFieldNameHash(4012574474)]
		public EntryInputActionEnum EntryInputActions { get { return m_EntryInputActions; } set { if (OnPropertyChanging("PlayerInputTriggerEntityData." + nameof(EntryInputActions), this, m_EntryInputActions, value)) m_EntryInputActions = value; } } // 0x10 (16)
		
		protected float m_ValueModifier = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(97668313)]
		public float ValueModifier { get { return m_ValueModifier; } set { if (OnPropertyChanging("PlayerInputTriggerEntityData." + nameof(ValueModifier), this, m_ValueModifier, value)) m_ValueModifier = value; } } // 0x14 (20)
		
		protected float m_TrailingValueAtStart = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(3374840281)]
		public float TrailingValueAtStart { get { return m_TrailingValueAtStart; } set { if (OnPropertyChanging("PlayerInputTriggerEntityData." + nameof(TrailingValueAtStart), this, m_TrailingValueAtStart, value)) m_TrailingValueAtStart = value; } } // 0x18 (24)
		
		protected float m_AccumulatedValueAtStart = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(421554895)]
		public float AccumulatedValueAtStart { get { return m_AccumulatedValueAtStart; } set { if (OnPropertyChanging("PlayerInputTriggerEntityData." + nameof(AccumulatedValueAtStart), this, m_AccumulatedValueAtStart, value)) m_AccumulatedValueAtStart = value; } } // 0x1C (28)
		
		protected bool m_SendTriggerEvents = new bool();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(118708318)]
		public bool SendTriggerEvents { get { return m_SendTriggerEvents; } set { if (OnPropertyChanging("PlayerInputTriggerEntityData." + nameof(SendTriggerEvents), this, m_SendTriggerEvents, value)) m_SendTriggerEvents = value; } } // 0x20 (32)
		
		protected bool m_EnabledFromStart = new bool();
		[ContainerField(33), LayoutImmutable, Blittable, ContainerFieldNameHash(4059145814)]
		public bool EnabledFromStart { get { return m_EnabledFromStart; } set { if (OnPropertyChanging("PlayerInputTriggerEntityData." + nameof(EnabledFromStart), this, m_EnabledFromStart, value)) m_EnabledFromStart = value; } } // 0x21 (33)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 4012574474:
					EntryInputActions = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 97668313:
					ValueModifier = (float) p_Value;
					break;

				case 3374840281:
					TrailingValueAtStart = (float) p_Value;
					break;

				case 421554895:
					AccumulatedValueAtStart = (float) p_Value;
					break;

				case 118708318:
					SendTriggerEvents = (bool) p_Value;
					break;

				case 4059145814:
					EnabledFromStart = (bool) p_Value;
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
				case 229961746:
					return Realm;

				case 4012574474:
					return EntryInputActions;

				case 97668313:
					return ValueModifier;

				case 3374840281:
					return TrailingValueAtStart;

				case 421554895:
					return AccumulatedValueAtStart;

				case 118708318:
					return SendTriggerEvents;

				case 4059145814:
					return EnabledFromStart;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(PlayerInputTriggerEntityData).GetProperty(nameof(Realm));

				case 4012574474:
					return typeof(PlayerInputTriggerEntityData).GetProperty(nameof(EntryInputActions));

				case 97668313:
					return typeof(PlayerInputTriggerEntityData).GetProperty(nameof(ValueModifier));

				case 3374840281:
					return typeof(PlayerInputTriggerEntityData).GetProperty(nameof(TrailingValueAtStart));

				case 421554895:
					return typeof(PlayerInputTriggerEntityData).GetProperty(nameof(AccumulatedValueAtStart));

				case 118708318:
					return typeof(PlayerInputTriggerEntityData).GetProperty(nameof(SendTriggerEvents));

				case 4059145814:
					return typeof(PlayerInputTriggerEntityData).GetProperty(nameof(EnabledFromStart));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
