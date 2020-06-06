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
	public class PlayerInputTriggerEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new Realm(); // 0xC (12)
		
		[ContainerField(16)]
		public EntryInputActionEnum EntryInputActions { get; set; } = new EntryInputActionEnum(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float ValueModifier { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float TrailingValueAtStart { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float AccumulatedValueAtStart { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool SendTriggerEvents { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool EnabledFromStart { get; set; } // 0x21 (33)
		
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
