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
	[ContainerType(16)]
	public class GameInteractionEntityData : 
		InteractionEntityData
	{
		protected BlinkType m_Blink = new BlinkType();
		[ContainerField(128), ContainerFieldNameHash(211512871)]
		public BlinkType Blink { get { return m_Blink; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(Blink), this, m_Blink, value)) m_Blink = value; } } // 0x80 (128)
		
		protected float m_CapturepointVerticalOffset = new float();
		[ContainerField(132), LayoutImmutable, Blittable, ContainerFieldNameHash(3396848754)]
		public float CapturepointVerticalOffset { get { return m_CapturepointVerticalOffset; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(CapturepointVerticalOffset), this, m_CapturepointVerticalOffset, value)) m_CapturepointVerticalOffset = value; } } // 0x84 (132)
		
		protected float m_DelayBetweenUses = new float();
		[ContainerField(136), LayoutImmutable, Blittable, ContainerFieldNameHash(2736691946)]
		public float DelayBetweenUses { get { return m_DelayBetweenUses; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(DelayBetweenUses), this, m_DelayBetweenUses, value)) m_DelayBetweenUses = value; } } // 0x88 (136)
		
		protected TeamId m_TeamId = new TeamId();
		[ContainerField(140), ContainerFieldNameHash(3220374101)]
		public TeamId TeamId { get { return m_TeamId; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(TeamId), this, m_TeamId, value)) m_TeamId = value; } } // 0x8C (140)
		
		protected EntryInputActionEnum m_InputAction = new EntryInputActionEnum();
		[ContainerField(144), ContainerFieldNameHash(1407707693)]
		public EntryInputActionEnum InputAction { get { return m_InputAction; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(InputAction), this, m_InputAction, value)) m_InputAction = value; } } // 0x90 (144)
		
		protected float m_HoldToInteractTime = new float();
		[ContainerField(148), LayoutImmutable, Blittable, ContainerFieldNameHash(594026294)]
		public float HoldToInteractTime { get { return m_HoldToInteractTime; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(HoldToInteractTime), this, m_HoldToInteractTime, value)) m_HoldToInteractTime = value; } } // 0x94 (148)
		
		protected InteractionEntityType m_InteractionEntityType = new InteractionEntityType();
		[ContainerField(152), ContainerFieldNameHash(740392700)]
		public InteractionEntityType InteractionEntityType { get { return m_InteractionEntityType; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(InteractionEntityType), this, m_InteractionEntityType, value)) m_InteractionEntityType = value; } } // 0x98 (152)
		
		protected string m_InteractionSid = new string();
		[ContainerField(156), LayoutImmutable, ContainerFieldNameHash(3925445313)]
		public string InteractionSid { get { return m_InteractionSid; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(InteractionSid), this, m_InteractionSid, value)) m_InteractionSid = value; } } // 0x9C (156)
		
		protected string m_InteractingSid = new string();
		[ContainerField(160), LayoutImmutable, ContainerFieldNameHash(3926175337)]
		public string InteractingSid { get { return m_InteractingSid; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(InteractingSid), this, m_InteractingSid, value)) m_InteractingSid = value; } } // 0xA0 (160)
		
		protected string m_FriendlyTextSid = new string();
		[ContainerField(164), LayoutImmutable, ContainerFieldNameHash(2455269025)]
		public string FriendlyTextSid { get { return m_FriendlyTextSid; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(FriendlyTextSid), this, m_FriendlyTextSid, value)) m_FriendlyTextSid = value; } } // 0xA4 (164)
		
		protected string m_NameSid = new string();
		[ContainerField(168), LayoutImmutable, ContainerFieldNameHash(3153745340)]
		public string NameSid { get { return m_NameSid; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(NameSid), this, m_NameSid, value)) m_NameSid = value; } } // 0xA8 (168)
		
		protected float m_InteractionVerticalOffset = new float();
		[ContainerField(172), LayoutImmutable, Blittable, ContainerFieldNameHash(2621963328)]
		public float InteractionVerticalOffset { get { return m_InteractionVerticalOffset; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(InteractionVerticalOffset), this, m_InteractionVerticalOffset, value)) m_InteractionVerticalOffset = value; } } // 0xAC (172)
		
		protected string m_EnemyTextSid = new string();
		[ContainerField(176), LayoutImmutable, ContainerFieldNameHash(1333856348)]
		public string EnemyTextSid { get { return m_EnemyTextSid; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(EnemyTextSid), this, m_EnemyTextSid, value)) m_EnemyTextSid = value; } } // 0xB0 (176)
		
		protected bool m_ShrinkSnap = new bool();
		[ContainerField(180), LayoutImmutable, Blittable, ContainerFieldNameHash(232640812)]
		public bool ShrinkSnap { get { return m_ShrinkSnap; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(ShrinkSnap), this, m_ShrinkSnap, value)) m_ShrinkSnap = value; } } // 0xB4 (180)
		
		protected bool m_ShowAsCapturePoint = new bool();
		[ContainerField(181), LayoutImmutable, Blittable, ContainerFieldNameHash(2335255676)]
		public bool ShowAsCapturePoint { get { return m_ShowAsCapturePoint; } set { if (OnPropertyChanging("GameInteractionEntityData." + nameof(ShowAsCapturePoint), this, m_ShowAsCapturePoint, value)) m_ShowAsCapturePoint = value; } } // 0xB5 (181)
		
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
