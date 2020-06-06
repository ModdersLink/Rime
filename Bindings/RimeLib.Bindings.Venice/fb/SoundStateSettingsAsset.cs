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
	public class SoundStateSettingsAsset : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<SoundState> SoundStates { get; set; } = new RefArray<SoundState>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float ImpairedHearingImpulseThreshold { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float ScreamThreshold { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float SupressionThreshold { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4087884162:
					SoundStates = (RefArray<SoundState>) p_Value;
					break;

				case 3350088792:
					ImpairedHearingImpulseThreshold = (float) p_Value;
					break;

				case 3986899289:
					ScreamThreshold = (float) p_Value;
					break;

				case 1285763547:
					SupressionThreshold = (float) p_Value;
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
				case 4087884162:
					return SoundStates;

				case 3350088792:
					return ImpairedHearingImpulseThreshold;

				case 3986899289:
					return ScreamThreshold;

				case 1285763547:
					return SupressionThreshold;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4087884162:
					return typeof(SoundStateSettingsAsset).GetProperty(nameof(SoundStates));

				case 3350088792:
					return typeof(SoundStateSettingsAsset).GetProperty(nameof(ImpairedHearingImpulseThreshold));

				case 3986899289:
					return typeof(SoundStateSettingsAsset).GetProperty(nameof(ScreamThreshold));

				case 1285763547:
					return typeof(SoundStateSettingsAsset).GetProperty(nameof(SupressionThreshold));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
