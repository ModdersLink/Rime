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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class PlayerInputTriggerEntityData : 
		EntityData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 12, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("PlayerInputTriggerEntityData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC (12)
		
		protected EntryInputActionEnum m_EntryInputActions = new EntryInputActionEnum();
		[ContainerField(Name: "EntryInputActions", Offset: 16, NameHash: 4012574474, Flags: 137)]
		public EntryInputActionEnum EntryInputActions { get { return m_EntryInputActions; } set { if (OnPropertyChanging("PlayerInputTriggerEntityData." + nameof(EntryInputActions), this, m_EntryInputActions, value)) m_EntryInputActions = value; } } // 0x10 (16)
		
		protected float m_ValueModifier = new float();
		[ContainerField(Name: "ValueModifier", Offset: 20, NameHash: 97668313, Flags: 49469), LayoutImmutable, Blittable]
		public float ValueModifier { get { return m_ValueModifier; } set { if (OnPropertyChanging("PlayerInputTriggerEntityData." + nameof(ValueModifier), this, m_ValueModifier, value)) m_ValueModifier = value; } } // 0x14 (20)
		
		protected float m_TrailingValueAtStart = new float();
		[ContainerField(Name: "TrailingValueAtStart", Offset: 24, NameHash: 3374840281, Flags: 49469), LayoutImmutable, Blittable]
		public float TrailingValueAtStart { get { return m_TrailingValueAtStart; } set { if (OnPropertyChanging("PlayerInputTriggerEntityData." + nameof(TrailingValueAtStart), this, m_TrailingValueAtStart, value)) m_TrailingValueAtStart = value; } } // 0x18 (24)
		
		protected float m_AccumulatedValueAtStart = new float();
		[ContainerField(Name: "AccumulatedValueAtStart", Offset: 28, NameHash: 421554895, Flags: 49469), LayoutImmutable, Blittable]
		public float AccumulatedValueAtStart { get { return m_AccumulatedValueAtStart; } set { if (OnPropertyChanging("PlayerInputTriggerEntityData." + nameof(AccumulatedValueAtStart), this, m_AccumulatedValueAtStart, value)) m_AccumulatedValueAtStart = value; } } // 0x1C (28)
		
		protected bool m_SendTriggerEvents = new bool();
		[ContainerField(Name: "SendTriggerEvents", Offset: 32, NameHash: 118708318, Flags: 49325), LayoutImmutable, Blittable]
		public bool SendTriggerEvents { get { return m_SendTriggerEvents; } set { if (OnPropertyChanging("PlayerInputTriggerEntityData." + nameof(SendTriggerEvents), this, m_SendTriggerEvents, value)) m_SendTriggerEvents = value; } } // 0x20 (32)
		
		protected bool m_EnabledFromStart = new bool();
		[ContainerField(Name: "EnabledFromStart", Offset: 33, NameHash: 4059145814, Flags: 49325), LayoutImmutable, Blittable]
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
