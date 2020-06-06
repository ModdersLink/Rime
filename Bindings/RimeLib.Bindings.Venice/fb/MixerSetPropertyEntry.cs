///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class MixerSetPropertyEntry : 
		AudioGraphNodePortGroup
	{
		[ContainerField(8)]
		public AudioGraphNodePort In { get; set; } = new AudioGraphNodePort(); // 0x8 (8)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint Target { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<MixGroup> Group { get; set; } = new CtrRef<MixGroup>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float AttackTime { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float ReleaseTime { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 3215022804:
					Target = (uint) p_Value;
					break;

				case 208130522:
					Group = (CtrRef<MixGroup>) p_Value;
					break;

				case 1150936440:
					AttackTime = (float) p_Value;
					break;

				case 892319833:
					ReleaseTime = (float) p_Value;
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
				case 5862146:
					return In;

				case 3215022804:
					return Target;

				case 208130522:
					return Group;

				case 1150936440:
					return AttackTime;

				case 892319833:
					return ReleaseTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(MixerSetPropertyEntry).GetProperty(nameof(In));

				case 3215022804:
					return typeof(MixerSetPropertyEntry).GetProperty(nameof(Target));

				case 208130522:
					return typeof(MixerSetPropertyEntry).GetProperty(nameof(Group));

				case 1150936440:
					return typeof(MixerSetPropertyEntry).GetProperty(nameof(AttackTime));

				case 892319833:
					return typeof(MixerSetPropertyEntry).GetProperty(nameof(ReleaseTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
