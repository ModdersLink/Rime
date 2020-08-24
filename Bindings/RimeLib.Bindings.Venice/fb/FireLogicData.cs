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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class FireLogicData : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public HoldAndReleaseData HoldAndRelease { get; set; } = new HoldAndReleaseData(); // 0x0 (0)
		
		[ContainerField(28), MemberInfoFlag(41)]
		public BoltActionData BoltAction { get; set; } = new BoltActionData(); // 0x1C (28)
		
		[ContainerField(44), MemberInfoFlag(41)]
		public RecoilData Recoil { get; set; } = new RecoilData(); // 0x2C (44)
		
		[ContainerField(80), MemberInfoFlag(137)]
		public EntryInputActionEnum FireInputAction { get; set; } = new EntryInputActionEnum(); // 0x50 (80)
		
		[ContainerField(84), MemberInfoFlag(137)]
		public EntryInputActionEnum ReloadInputAction { get; set; } = new EntryInputActionEnum(); // 0x54 (84)
		
		[ContainerField(88), MemberInfoFlag(137)]
		public EntryInputActionEnum CycleFireModeInputAction { get; set; } = new EntryInputActionEnum(); // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float TriggerPullWeight { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RateOfFire { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float RateOfFireForBurst { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float ClientFireRateMultiplier { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float ReloadDelay { get; set; } // 0x6C (108)
		
		[ContainerField(112), MemberInfoFlag(65), ContainerArray]
		public List<FireLogicType> FireLogicTypeArray { get; set; } = new List<FireLogicType>(); // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float ReloadThreshold { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float PreFireDelay { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float ReloadTime { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float ReloadTimeBulletsLeft { get; set; } // 0x80 (128)
		
		[ContainerField(132), MemberInfoFlag(137)]
		public FireLogicType FireLogicType { get; set; } = new FireLogicType(); // 0x84 (132)
		
		[ContainerField(136), MemberInfoFlag(137)]
		public ReloadLogic ReloadLogic { get; set; } = new ReloadLogic(); // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float AutomaticDelay { get; set; } // 0x8C (140)
		
		[ContainerField(144), MemberInfoFlag(137)]
		public ReloadType ReloadType { get; set; } = new ReloadType(); // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool HoldOffReloadUntilZoomRelease { get; set; } // 0x94 (148)
		
		[ContainerField(149), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool ForceReloadActionOnFireTrigger { get; set; } // 0x95 (149)
		
		[ContainerField(150), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool HoldOffReloadUntilFireRelease { get; set; } // 0x96 (150)
		
		[ContainerField(151), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool AlwaysAutoReload { get; set; } // 0x97 (151)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 990430632:
					HoldAndRelease = (HoldAndReleaseData) p_Value;
					break;

				case 2541973070:
					BoltAction = (BoltActionData) p_Value;
					break;

				case 3293845435:
					Recoil = (RecoilData) p_Value;
					break;

				case 2678055381:
						FireInputAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 3775146780:
						ReloadInputAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 1729611942:
						CycleFireModeInputAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 2750237048:
					TriggerPullWeight = (float) p_Value;
					break;

				case 3866082710:
					RateOfFire = (float) p_Value;
					break;

				case 1393806543:
					RateOfFireForBurst = (float) p_Value;
					break;

				case 4266906285:
					ClientFireRateMultiplier = (float) p_Value;
					break;

				case 2958021633:
					ReloadDelay = (float) p_Value;
					break;

				case 4279400946:
					if (p_Value.GetType() == typeof (List<uint>))
						FireLogicTypeArray = ((List<uint>) p_Value).Select(x => (FireLogicType) Enum.ToObject(typeof(FireLogicType), x)).ToList();
					else
						FireLogicTypeArray = (List<FireLogicType>) p_Value;
					break;

				case 607792483:
					ReloadThreshold = (float) p_Value;
					break;

				case 52152975:
					PreFireDelay = (float) p_Value;
					break;

				case 1390571137:
					ReloadTime = (float) p_Value;
					break;

				case 257608303:
					ReloadTimeBulletsLeft = (float) p_Value;
					break;

				case 1365968171:
						FireLogicType = (FireLogicType) Enum.ToObject(typeof(FireLogicType), p_Value);
					break;

				case 2967140250:
						ReloadLogic = (ReloadLogic) Enum.ToObject(typeof(ReloadLogic), p_Value);
					break;

				case 3726024813:
					AutomaticDelay = (float) p_Value;
					break;

				case 1390588396:
						ReloadType = (ReloadType) Enum.ToObject(typeof(ReloadType), p_Value);
					break;

				case 3888370560:
					HoldOffReloadUntilZoomRelease = (bool) p_Value;
					break;

				case 2262034806:
					ForceReloadActionOnFireTrigger = (bool) p_Value;
					break;

				case 957247311:
					HoldOffReloadUntilFireRelease = (bool) p_Value;
					break;

				case 3053142090:
					AlwaysAutoReload = (bool) p_Value;
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
				case 990430632:
					return HoldAndRelease;

				case 2541973070:
					return BoltAction;

				case 3293845435:
					return Recoil;

				case 2678055381:
					return FireInputAction;

				case 3775146780:
					return ReloadInputAction;

				case 1729611942:
					return CycleFireModeInputAction;

				case 2750237048:
					return TriggerPullWeight;

				case 3866082710:
					return RateOfFire;

				case 1393806543:
					return RateOfFireForBurst;

				case 4266906285:
					return ClientFireRateMultiplier;

				case 2958021633:
					return ReloadDelay;

				case 4279400946:
					return FireLogicTypeArray;

				case 607792483:
					return ReloadThreshold;

				case 52152975:
					return PreFireDelay;

				case 1390571137:
					return ReloadTime;

				case 257608303:
					return ReloadTimeBulletsLeft;

				case 1365968171:
					return FireLogicType;

				case 2967140250:
					return ReloadLogic;

				case 3726024813:
					return AutomaticDelay;

				case 1390588396:
					return ReloadType;

				case 3888370560:
					return HoldOffReloadUntilZoomRelease;

				case 2262034806:
					return ForceReloadActionOnFireTrigger;

				case 957247311:
					return HoldOffReloadUntilFireRelease;

				case 3053142090:
					return AlwaysAutoReload;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 990430632:
					return typeof(FireLogicData).GetProperty(nameof(HoldAndRelease));

				case 2541973070:
					return typeof(FireLogicData).GetProperty(nameof(BoltAction));

				case 3293845435:
					return typeof(FireLogicData).GetProperty(nameof(Recoil));

				case 2678055381:
					return typeof(FireLogicData).GetProperty(nameof(FireInputAction));

				case 3775146780:
					return typeof(FireLogicData).GetProperty(nameof(ReloadInputAction));

				case 1729611942:
					return typeof(FireLogicData).GetProperty(nameof(CycleFireModeInputAction));

				case 2750237048:
					return typeof(FireLogicData).GetProperty(nameof(TriggerPullWeight));

				case 3866082710:
					return typeof(FireLogicData).GetProperty(nameof(RateOfFire));

				case 1393806543:
					return typeof(FireLogicData).GetProperty(nameof(RateOfFireForBurst));

				case 4266906285:
					return typeof(FireLogicData).GetProperty(nameof(ClientFireRateMultiplier));

				case 2958021633:
					return typeof(FireLogicData).GetProperty(nameof(ReloadDelay));

				case 4279400946:
					return typeof(FireLogicData).GetProperty(nameof(FireLogicTypeArray));

				case 607792483:
					return typeof(FireLogicData).GetProperty(nameof(ReloadThreshold));

				case 52152975:
					return typeof(FireLogicData).GetProperty(nameof(PreFireDelay));

				case 1390571137:
					return typeof(FireLogicData).GetProperty(nameof(ReloadTime));

				case 257608303:
					return typeof(FireLogicData).GetProperty(nameof(ReloadTimeBulletsLeft));

				case 1365968171:
					return typeof(FireLogicData).GetProperty(nameof(FireLogicType));

				case 2967140250:
					return typeof(FireLogicData).GetProperty(nameof(ReloadLogic));

				case 3726024813:
					return typeof(FireLogicData).GetProperty(nameof(AutomaticDelay));

				case 1390588396:
					return typeof(FireLogicData).GetProperty(nameof(ReloadType));

				case 3888370560:
					return typeof(FireLogicData).GetProperty(nameof(HoldOffReloadUntilZoomRelease));

				case 2262034806:
					return typeof(FireLogicData).GetProperty(nameof(ForceReloadActionOnFireTrigger));

				case 957247311:
					return typeof(FireLogicData).GetProperty(nameof(HoldOffReloadUntilFireRelease));

				case 3053142090:
					return typeof(FireLogicData).GetProperty(nameof(AlwaysAutoReload));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
