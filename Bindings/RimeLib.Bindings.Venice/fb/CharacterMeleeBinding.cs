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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class CharacterMeleeBinding : FrostbiteContainer
	{
		[ContainerField(Name: "TriggerMelee", Offset: 0, NameHash: 3578873369, Flags: 41)]
		public AntRef TriggerMelee { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "SelfActor", Offset: 4, NameHash: 68504242, Flags: 41)]
		public AntRef SelfActor { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(Name: "OtherActor", Offset: 8, NameHash: 15471402, Flags: 41)]
		public AntRef OtherActor { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(Name: "MeleeActive", Offset: 12, NameHash: 818515309, Flags: 41)]
		public AntRef MeleeActive { get; set; } = new AntRef(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3578873369:
					TriggerMelee = (AntRef) p_Value;
					break;

				case 68504242:
					SelfActor = (AntRef) p_Value;
					break;

				case 15471402:
					OtherActor = (AntRef) p_Value;
					break;

				case 818515309:
					MeleeActive = (AntRef) p_Value;
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
				case 3578873369:
					return TriggerMelee;

				case 68504242:
					return SelfActor;

				case 15471402:
					return OtherActor;

				case 818515309:
					return MeleeActive;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3578873369:
					return typeof(CharacterMeleeBinding).GetProperty(nameof(TriggerMelee));

				case 68504242:
					return typeof(CharacterMeleeBinding).GetProperty(nameof(SelfActor));

				case 15471402:
					return typeof(CharacterMeleeBinding).GetProperty(nameof(OtherActor));

				case 818515309:
					return typeof(CharacterMeleeBinding).GetProperty(nameof(MeleeActive));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
