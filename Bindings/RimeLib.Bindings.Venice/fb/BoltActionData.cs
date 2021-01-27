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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class BoltActionData : FrostbiteContainer
	{
		[ContainerField(Name: "BoltActionDelay", Offset: 0, NameHash: 322896091, Flags: 49469), LayoutImmutable, Blittable]
		public float BoltActionDelay { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "BoltActionTime", Offset: 4, NameHash: 1832454555, Flags: 49469), LayoutImmutable, Blittable]
		public float BoltActionTime { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "HoldBoltActionUntilFireRelease", Offset: 8, NameHash: 832817818, Flags: 49325), LayoutImmutable, Blittable]
		public bool HoldBoltActionUntilFireRelease { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "HoldBoltActionUntilZoomRelease", Offset: 9, NameHash: 3133940949, Flags: 49325), LayoutImmutable, Blittable]
		public bool HoldBoltActionUntilZoomRelease { get; set; } // 0x9 (9)
		
		[ContainerField(Name: "ForceBoltActionOnFireTrigger", Offset: 10, NameHash: 1053477586, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForceBoltActionOnFireTrigger { get; set; } // 0xA (10)
		
		[ContainerField(Name: "UnZoomOnBoltAction", Offset: 11, NameHash: 1438634691, Flags: 49325), LayoutImmutable, Blittable]
		public bool UnZoomOnBoltAction { get; set; } // 0xB (11)
		
		[ContainerField(Name: "ReturnToZoomAfterBoltAction", Offset: 12, NameHash: 3074155596, Flags: 49325), LayoutImmutable, Blittable]
		public bool ReturnToZoomAfterBoltAction { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 322896091:
					BoltActionDelay = (float) p_Value;
					break;

				case 1832454555:
					BoltActionTime = (float) p_Value;
					break;

				case 832817818:
					HoldBoltActionUntilFireRelease = (bool) p_Value;
					break;

				case 3133940949:
					HoldBoltActionUntilZoomRelease = (bool) p_Value;
					break;

				case 1053477586:
					ForceBoltActionOnFireTrigger = (bool) p_Value;
					break;

				case 1438634691:
					UnZoomOnBoltAction = (bool) p_Value;
					break;

				case 3074155596:
					ReturnToZoomAfterBoltAction = (bool) p_Value;
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
				case 322896091:
					return BoltActionDelay;

				case 1832454555:
					return BoltActionTime;

				case 832817818:
					return HoldBoltActionUntilFireRelease;

				case 3133940949:
					return HoldBoltActionUntilZoomRelease;

				case 1053477586:
					return ForceBoltActionOnFireTrigger;

				case 1438634691:
					return UnZoomOnBoltAction;

				case 3074155596:
					return ReturnToZoomAfterBoltAction;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 322896091:
					return typeof(BoltActionData).GetProperty(nameof(BoltActionDelay));

				case 1832454555:
					return typeof(BoltActionData).GetProperty(nameof(BoltActionTime));

				case 832817818:
					return typeof(BoltActionData).GetProperty(nameof(HoldBoltActionUntilFireRelease));

				case 3133940949:
					return typeof(BoltActionData).GetProperty(nameof(HoldBoltActionUntilZoomRelease));

				case 1053477586:
					return typeof(BoltActionData).GetProperty(nameof(ForceBoltActionOnFireTrigger));

				case 1438634691:
					return typeof(BoltActionData).GetProperty(nameof(UnZoomOnBoltAction));

				case 3074155596:
					return typeof(BoltActionData).GetProperty(nameof(ReturnToZoomAfterBoltAction));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
