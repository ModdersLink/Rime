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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 48)]
	public class SpecialMovesBinding : FrostbiteContainer
	{
		[ContainerField(Name: "TriggerHighVault", Offset: 0, NameHash: 44544169, Flags: 41)]
		public AntRef TriggerHighVault { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "TriggerUpVault", Offset: 4, NameHash: 333133442, Flags: 41)]
		public AntRef TriggerUpVault { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(Name: "TriggerLowVault", Offset: 8, NameHash: 548543603, Flags: 41)]
		public AntRef TriggerLowVault { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(Name: "TriggerSlideIntoProne", Offset: 12, NameHash: 2509228816, Flags: 41)]
		public AntRef TriggerSlideIntoProne { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(Name: "TriggerSpecialAnimation", Offset: 16, NameHash: 949651018, Flags: 41)]
		public AntRef TriggerSpecialAnimation { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(Name: "SpecialAnimationIndex", Offset: 20, NameHash: 502517260, Flags: 41)]
		public AntRef SpecialAnimationIndex { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(Name: "ObjectHeight", Offset: 24, NameHash: 3307956847, Flags: 41)]
		public AntRef ObjectHeight { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(Name: "ObjectDistance", Offset: 28, NameHash: 709323379, Flags: 41)]
		public AntRef ObjectDistance { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(Name: "StartObjectDistanceTimer", Offset: 32, NameHash: 1175862644, Flags: 41)]
		public AntRef StartObjectDistanceTimer { get; set; } = new AntRef(); // 0x20 (32)
		
		[ContainerField(Name: "VaultObjectPositionX", Offset: 36, NameHash: 6864875, Flags: 41)]
		public AntRef VaultObjectPositionX { get; set; } = new AntRef(); // 0x24 (36)
		
		[ContainerField(Name: "VaultObjectPositionZ", Offset: 40, NameHash: 6864873, Flags: 41)]
		public AntRef VaultObjectPositionZ { get; set; } = new AntRef(); // 0x28 (40)
		
		[ContainerField(Name: "CancelAnimation", Offset: 44, NameHash: 636163605, Flags: 41)]
		public AntRef CancelAnimation { get; set; } = new AntRef(); // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 44544169:
					TriggerHighVault = (AntRef) p_Value;
					break;

				case 333133442:
					TriggerUpVault = (AntRef) p_Value;
					break;

				case 548543603:
					TriggerLowVault = (AntRef) p_Value;
					break;

				case 2509228816:
					TriggerSlideIntoProne = (AntRef) p_Value;
					break;

				case 949651018:
					TriggerSpecialAnimation = (AntRef) p_Value;
					break;

				case 502517260:
					SpecialAnimationIndex = (AntRef) p_Value;
					break;

				case 3307956847:
					ObjectHeight = (AntRef) p_Value;
					break;

				case 709323379:
					ObjectDistance = (AntRef) p_Value;
					break;

				case 1175862644:
					StartObjectDistanceTimer = (AntRef) p_Value;
					break;

				case 6864875:
					VaultObjectPositionX = (AntRef) p_Value;
					break;

				case 6864873:
					VaultObjectPositionZ = (AntRef) p_Value;
					break;

				case 636163605:
					CancelAnimation = (AntRef) p_Value;
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
				case 44544169:
					return TriggerHighVault;

				case 333133442:
					return TriggerUpVault;

				case 548543603:
					return TriggerLowVault;

				case 2509228816:
					return TriggerSlideIntoProne;

				case 949651018:
					return TriggerSpecialAnimation;

				case 502517260:
					return SpecialAnimationIndex;

				case 3307956847:
					return ObjectHeight;

				case 709323379:
					return ObjectDistance;

				case 1175862644:
					return StartObjectDistanceTimer;

				case 6864875:
					return VaultObjectPositionX;

				case 6864873:
					return VaultObjectPositionZ;

				case 636163605:
					return CancelAnimation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 44544169:
					return typeof(SpecialMovesBinding).GetProperty(nameof(TriggerHighVault));

				case 333133442:
					return typeof(SpecialMovesBinding).GetProperty(nameof(TriggerUpVault));

				case 548543603:
					return typeof(SpecialMovesBinding).GetProperty(nameof(TriggerLowVault));

				case 2509228816:
					return typeof(SpecialMovesBinding).GetProperty(nameof(TriggerSlideIntoProne));

				case 949651018:
					return typeof(SpecialMovesBinding).GetProperty(nameof(TriggerSpecialAnimation));

				case 502517260:
					return typeof(SpecialMovesBinding).GetProperty(nameof(SpecialAnimationIndex));

				case 3307956847:
					return typeof(SpecialMovesBinding).GetProperty(nameof(ObjectHeight));

				case 709323379:
					return typeof(SpecialMovesBinding).GetProperty(nameof(ObjectDistance));

				case 1175862644:
					return typeof(SpecialMovesBinding).GetProperty(nameof(StartObjectDistanceTimer));

				case 6864875:
					return typeof(SpecialMovesBinding).GetProperty(nameof(VaultObjectPositionX));

				case 6864873:
					return typeof(SpecialMovesBinding).GetProperty(nameof(VaultObjectPositionZ));

				case 636163605:
					return typeof(SpecialMovesBinding).GetProperty(nameof(CancelAnimation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
