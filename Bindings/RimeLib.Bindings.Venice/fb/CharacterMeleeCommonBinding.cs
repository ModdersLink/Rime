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
	public class CharacterMeleeCommonBinding : FrostbiteContainer
	{
		[ContainerField(0)]
		public AntRef MeleeDistance { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4)]
		public AntRef MeleeAngle { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8)]
		public AntRef MeleeDefenceTime { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12)]
		public AntRef MeleeSequenceTime { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16)]
		public AntRef MeleeAborted { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(20)]
		public AntRef CloseToTarget { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24)]
		public AntRef MeleeType { get; set; } = new AntRef(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 406541282:
					MeleeDistance = (AntRef) p_Value;
					break;

				case 936017920:
					MeleeAngle = (AntRef) p_Value;
					break;

				case 1004498494:
					MeleeDefenceTime = (AntRef) p_Value;
					break;

				case 2874332555:
					MeleeSequenceTime = (AntRef) p_Value;
					break;

				case 966530666:
					MeleeAborted = (AntRef) p_Value;
					break;

				case 1097044025:
					CloseToTarget = (AntRef) p_Value;
					break;

				case 2762192025:
					MeleeType = (AntRef) p_Value;
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
				case 406541282:
					return MeleeDistance;

				case 936017920:
					return MeleeAngle;

				case 1004498494:
					return MeleeDefenceTime;

				case 2874332555:
					return MeleeSequenceTime;

				case 966530666:
					return MeleeAborted;

				case 1097044025:
					return CloseToTarget;

				case 2762192025:
					return MeleeType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 406541282:
					return typeof(CharacterMeleeCommonBinding).GetProperty(nameof(MeleeDistance));

				case 936017920:
					return typeof(CharacterMeleeCommonBinding).GetProperty(nameof(MeleeAngle));

				case 1004498494:
					return typeof(CharacterMeleeCommonBinding).GetProperty(nameof(MeleeDefenceTime));

				case 2874332555:
					return typeof(CharacterMeleeCommonBinding).GetProperty(nameof(MeleeSequenceTime));

				case 966530666:
					return typeof(CharacterMeleeCommonBinding).GetProperty(nameof(MeleeAborted));

				case 1097044025:
					return typeof(CharacterMeleeCommonBinding).GetProperty(nameof(CloseToTarget));

				case 2762192025:
					return typeof(CharacterMeleeCommonBinding).GetProperty(nameof(MeleeType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
