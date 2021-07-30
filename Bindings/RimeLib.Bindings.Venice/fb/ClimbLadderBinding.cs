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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 24)]
	public class ClimbLadderBinding : FrostbiteContainer
	{
		[ContainerField(Name: "ClimbLadderPhase", Offset: 0, NameHash: 2303344697, Flags: 41)]
		public AntRef ClimbLadderPhase { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "ClimbLadderConnectPhase", Offset: 4, NameHash: 298090343, Flags: 41)]
		public AntRef ClimbLadderConnectPhase { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(Name: "ClimbLadderTransitionPhase", Offset: 8, NameHash: 940490966, Flags: 41)]
		public AntRef ClimbLadderTransitionPhase { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(Name: "OnLadder", Offset: 12, NameHash: 1979319070, Flags: 41)]
		public AntRef OnLadder { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(Name: "LadderTopTransition", Offset: 16, NameHash: 2037201883, Flags: 41)]
		public AntRef LadderTopTransition { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(Name: "FallHigh", Offset: 20, NameHash: 3473772, Flags: 41)]
		public AntRef FallHigh { get; set; } = new AntRef(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2303344697:
					ClimbLadderPhase = (AntRef) p_Value;
					break;

				case 298090343:
					ClimbLadderConnectPhase = (AntRef) p_Value;
					break;

				case 940490966:
					ClimbLadderTransitionPhase = (AntRef) p_Value;
					break;

				case 1979319070:
					OnLadder = (AntRef) p_Value;
					break;

				case 2037201883:
					LadderTopTransition = (AntRef) p_Value;
					break;

				case 3473772:
					FallHigh = (AntRef) p_Value;
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
				case 2303344697:
					return ClimbLadderPhase;

				case 298090343:
					return ClimbLadderConnectPhase;

				case 940490966:
					return ClimbLadderTransitionPhase;

				case 1979319070:
					return OnLadder;

				case 2037201883:
					return LadderTopTransition;

				case 3473772:
					return FallHigh;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2303344697:
					return typeof(ClimbLadderBinding).GetProperty(nameof(ClimbLadderPhase));

				case 298090343:
					return typeof(ClimbLadderBinding).GetProperty(nameof(ClimbLadderConnectPhase));

				case 940490966:
					return typeof(ClimbLadderBinding).GetProperty(nameof(ClimbLadderTransitionPhase));

				case 1979319070:
					return typeof(ClimbLadderBinding).GetProperty(nameof(OnLadder));

				case 2037201883:
					return typeof(ClimbLadderBinding).GetProperty(nameof(LadderTopTransition));

				case 3473772:
					return typeof(ClimbLadderBinding).GetProperty(nameof(FallHigh));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
