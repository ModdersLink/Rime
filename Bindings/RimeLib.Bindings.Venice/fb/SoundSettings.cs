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
	public class SoundSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable]
		public string VOEnglish { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string AudioSystemUri { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string VOCommon { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string VOItalian { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable]
		public string VOSpanish { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable]
		public string VOFrench { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable]
		public string VOGerman { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 433771118:
					VOEnglish = (string) p_Value;
					break;

				case 2343912184:
					AudioSystemUri = (string) p_Value;
					break;

				case 2339452753:
					VOCommon = (string) p_Value;
					break;

				case 3307845866:
					VOItalian = (string) p_Value;
					break;

				case 1980789858:
					VOSpanish = (string) p_Value;
					break;

				case 2213601832:
					VOFrench = (string) p_Value;
					break;

				case 2207675566:
					VOGerman = (string) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
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
				case 433771118:
					return VOEnglish;

				case 2343912184:
					return AudioSystemUri;

				case 2339452753:
					return VOCommon;

				case 3307845866:
					return VOItalian;

				case 1980789858:
					return VOSpanish;

				case 2213601832:
					return VOFrench;

				case 2207675566:
					return VOGerman;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 433771118:
					return typeof(SoundSettings).GetProperty(nameof(VOEnglish));

				case 2343912184:
					return typeof(SoundSettings).GetProperty(nameof(AudioSystemUri));

				case 2339452753:
					return typeof(SoundSettings).GetProperty(nameof(VOCommon));

				case 3307845866:
					return typeof(SoundSettings).GetProperty(nameof(VOItalian));

				case 1980789858:
					return typeof(SoundSettings).GetProperty(nameof(VOSpanish));

				case 2213601832:
					return typeof(SoundSettings).GetProperty(nameof(VOFrench));

				case 2207675566:
					return typeof(SoundSettings).GetProperty(nameof(VOGerman));

				case 2342790116:
					return typeof(SoundSettings).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
