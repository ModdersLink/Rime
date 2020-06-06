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
	public class FadeEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float FadeTime { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float MaxWaitFadedWhileStreamingTime { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool FadeScreen { get; set; } // 0x14 (20)
		
		[ContainerField(21), LayoutImmutable, Blittable]
		public bool FadeUI { get; set; } // 0x15 (21)
		
		[ContainerField(22), LayoutImmutable, Blittable]
		public bool FadeRumble { get; set; } // 0x16 (22)
		
		[ContainerField(23), LayoutImmutable, Blittable]
		public bool FadeAudio { get; set; } // 0x17 (23)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool FadeMovie { get; set; } // 0x18 (24)
		
		[ContainerField(25), LayoutImmutable, Blittable]
		public bool StartFaded { get; set; } // 0x19 (25)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4001222838:
					FadeTime = (float) p_Value;
					break;

				case 3945633230:
					MaxWaitFadedWhileStreamingTime = (float) p_Value;
					break;

				case 1880126671:
					FadeScreen = (bool) p_Value;
					break;

				case 2515973727:
					FadeUI = (bool) p_Value;
					break;

				case 1825215970:
					FadeRumble = (bool) p_Value;
					break;

				case 3169106133:
					FadeAudio = (bool) p_Value;
					break;

				case 3182278683:
					FadeMovie = (bool) p_Value;
					break;

				case 2729539719:
					StartFaded = (bool) p_Value;
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
				case 4001222838:
					return FadeTime;

				case 3945633230:
					return MaxWaitFadedWhileStreamingTime;

				case 1880126671:
					return FadeScreen;

				case 2515973727:
					return FadeUI;

				case 1825215970:
					return FadeRumble;

				case 3169106133:
					return FadeAudio;

				case 3182278683:
					return FadeMovie;

				case 2729539719:
					return StartFaded;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4001222838:
					return typeof(FadeEntityData).GetProperty(nameof(FadeTime));

				case 3945633230:
					return typeof(FadeEntityData).GetProperty(nameof(MaxWaitFadedWhileStreamingTime));

				case 1880126671:
					return typeof(FadeEntityData).GetProperty(nameof(FadeScreen));

				case 2515973727:
					return typeof(FadeEntityData).GetProperty(nameof(FadeUI));

				case 1825215970:
					return typeof(FadeEntityData).GetProperty(nameof(FadeRumble));

				case 3169106133:
					return typeof(FadeEntityData).GetProperty(nameof(FadeAudio));

				case 3182278683:
					return typeof(FadeEntityData).GetProperty(nameof(FadeMovie));

				case 2729539719:
					return typeof(FadeEntityData).GetProperty(nameof(StartFaded));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
