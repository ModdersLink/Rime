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
    [ContainerType(16)]
	public class GameInteractionEntityData : 
		InteractionEntityData
	{
		[ContainerField(128)]
		public BlinkType Blink { get; set; } = new BlinkType(); // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float CapturepointVerticalOffset { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float DelayBetweenUses { get; set; } // 0x88 (136)
		
		[ContainerField(140)]
		public TeamId TeamId { get; set; } = new TeamId(); // 0x8C (140)
		
		[ContainerField(144)]
		public EntryInputActionEnum InputAction { get; set; } = new EntryInputActionEnum(); // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float HoldToInteractTime { get; set; } // 0x94 (148)
		
		[ContainerField(152)]
		public InteractionEntityType InteractionEntityType { get; set; } = new InteractionEntityType(); // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable]
		public string InteractionSid { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable]
		public string InteractingSid { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable]
		public string FriendlyTextSid { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable]
		public string NameSid { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public float InteractionVerticalOffset { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable]
		public string EnemyTextSid { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public bool ShrinkSnap { get; set; } // 0xB4 (180)
		
		[ContainerField(181), LayoutImmutable, Blittable]
		public bool ShowAsCapturePoint { get; set; } // 0xB5 (181)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 211512871:
					Blink = (BlinkType) Enum.ToObject(typeof(BlinkType), p_Value);
					break;

				case 3396848754:
					CapturepointVerticalOffset = (float) p_Value;
					break;

				case 2736691946:
					DelayBetweenUses = (float) p_Value;
					break;

				case 3220374101:
					TeamId = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 1407707693:
					InputAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 594026294:
					HoldToInteractTime = (float) p_Value;
					break;

				case 740392700:
					InteractionEntityType = (InteractionEntityType) Enum.ToObject(typeof(InteractionEntityType), p_Value);
					break;

				case 3925445313:
					InteractionSid = (string) p_Value;
					break;

				case 3926175337:
					InteractingSid = (string) p_Value;
					break;

				case 2455269025:
					FriendlyTextSid = (string) p_Value;
					break;

				case 3153745340:
					NameSid = (string) p_Value;
					break;

				case 2621963328:
					InteractionVerticalOffset = (float) p_Value;
					break;

				case 1333856348:
					EnemyTextSid = (string) p_Value;
					break;

				case 232640812:
					ShrinkSnap = (bool) p_Value;
					break;

				case 2335255676:
					ShowAsCapturePoint = (bool) p_Value;
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
				case 211512871:
					return Blink;

				case 3396848754:
					return CapturepointVerticalOffset;

				case 2736691946:
					return DelayBetweenUses;

				case 3220374101:
					return TeamId;

				case 1407707693:
					return InputAction;

				case 594026294:
					return HoldToInteractTime;

				case 740392700:
					return InteractionEntityType;

				case 3925445313:
					return InteractionSid;

				case 3926175337:
					return InteractingSid;

				case 2455269025:
					return FriendlyTextSid;

				case 3153745340:
					return NameSid;

				case 2621963328:
					return InteractionVerticalOffset;

				case 1333856348:
					return EnemyTextSid;

				case 232640812:
					return ShrinkSnap;

				case 2335255676:
					return ShowAsCapturePoint;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 211512871:
					return typeof(GameInteractionEntityData).GetProperty(nameof(Blink));

				case 3396848754:
					return typeof(GameInteractionEntityData).GetProperty(nameof(CapturepointVerticalOffset));

				case 2736691946:
					return typeof(GameInteractionEntityData).GetProperty(nameof(DelayBetweenUses));

				case 3220374101:
					return typeof(GameInteractionEntityData).GetProperty(nameof(TeamId));

				case 1407707693:
					return typeof(GameInteractionEntityData).GetProperty(nameof(InputAction));

				case 594026294:
					return typeof(GameInteractionEntityData).GetProperty(nameof(HoldToInteractTime));

				case 740392700:
					return typeof(GameInteractionEntityData).GetProperty(nameof(InteractionEntityType));

				case 3925445313:
					return typeof(GameInteractionEntityData).GetProperty(nameof(InteractionSid));

				case 3926175337:
					return typeof(GameInteractionEntityData).GetProperty(nameof(InteractingSid));

				case 2455269025:
					return typeof(GameInteractionEntityData).GetProperty(nameof(FriendlyTextSid));

				case 3153745340:
					return typeof(GameInteractionEntityData).GetProperty(nameof(NameSid));

				case 2621963328:
					return typeof(GameInteractionEntityData).GetProperty(nameof(InteractionVerticalOffset));

				case 1333856348:
					return typeof(GameInteractionEntityData).GetProperty(nameof(EnemyTextSid));

				case 232640812:
					return typeof(GameInteractionEntityData).GetProperty(nameof(ShrinkSnap));

				case 2335255676:
					return typeof(GameInteractionEntityData).GetProperty(nameof(ShowAsCapturePoint));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
