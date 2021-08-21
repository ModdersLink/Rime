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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 32)]
	public class HitReactionComponentBinding : FrostbiteContainer
	{
		[ContainerField(Name: "Hit", Offset: 0, NameHash: 193458192, Flags: 41)]
		public AntRef Hit { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "AllowKillFromAnimation", Offset: 4, NameHash: 3918793758, Flags: 41)]
		public AntRef AllowKillFromAnimation { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(Name: "Direction", Offset: 8, NameHash: 2698949952, Flags: 41)]
		public AntRef Direction { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(Name: "FiringDistance", Offset: 12, NameHash: 1253253819, Flags: 41)]
		public AntRef FiringDistance { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(Name: "BoneType", Offset: 16, NameHash: 1590859931, Flags: 41)]
		public AntRef BoneType { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(Name: "ImpactType", Offset: 20, NameHash: 2853987935, Flags: 41)]
		public AntRef ImpactType { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(Name: "Immortal", Offset: 24, NameHash: 922982664, Flags: 41)]
		public AntRef Immortal { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(Name: "RandomAnimationIndex", Offset: 28, NameHash: 3646496566, Flags: 41)]
		public AntRef RandomAnimationIndex { get; set; } = new AntRef(); // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193458192:
					Hit = (AntRef) p_Value;
					break;

				case 3918793758:
					AllowKillFromAnimation = (AntRef) p_Value;
					break;

				case 2698949952:
					Direction = (AntRef) p_Value;
					break;

				case 1253253819:
					FiringDistance = (AntRef) p_Value;
					break;

				case 1590859931:
					BoneType = (AntRef) p_Value;
					break;

				case 2853987935:
					ImpactType = (AntRef) p_Value;
					break;

				case 922982664:
					Immortal = (AntRef) p_Value;
					break;

				case 3646496566:
					RandomAnimationIndex = (AntRef) p_Value;
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
				case 193458192:
					return Hit;

				case 3918793758:
					return AllowKillFromAnimation;

				case 2698949952:
					return Direction;

				case 1253253819:
					return FiringDistance;

				case 1590859931:
					return BoneType;

				case 2853987935:
					return ImpactType;

				case 922982664:
					return Immortal;

				case 3646496566:
					return RandomAnimationIndex;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193458192:
					return typeof(HitReactionComponentBinding).GetProperty(nameof(Hit));

				case 3918793758:
					return typeof(HitReactionComponentBinding).GetProperty(nameof(AllowKillFromAnimation));

				case 2698949952:
					return typeof(HitReactionComponentBinding).GetProperty(nameof(Direction));

				case 1253253819:
					return typeof(HitReactionComponentBinding).GetProperty(nameof(FiringDistance));

				case 1590859931:
					return typeof(HitReactionComponentBinding).GetProperty(nameof(BoneType));

				case 2853987935:
					return typeof(HitReactionComponentBinding).GetProperty(nameof(ImpactType));

				case 922982664:
					return typeof(HitReactionComponentBinding).GetProperty(nameof(Immortal));

				case 3646496566:
					return typeof(HitReactionComponentBinding).GetProperty(nameof(RandomAnimationIndex));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
