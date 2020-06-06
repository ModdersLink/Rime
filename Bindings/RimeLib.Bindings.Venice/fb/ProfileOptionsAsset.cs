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
	public class ProfileOptionsAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string FileName { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string ContentName { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint FileSize { get; set; } // 0x14 (20)
		
		[ContainerField(24)]
		public RefArray<ProfileOptionData> Options { get; set; } = new RefArray<ProfileOptionData>(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool AutoSaveOnQuit { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1134474212:
					FileName = (string) p_Value;
					break;

				case 4236678091:
					ContentName = (string) p_Value;
					break;

				case 1134658022:
					FileSize = (uint) p_Value;
					break;

				case 958915349:
					Options = (RefArray<ProfileOptionData>) p_Value;
					break;

				case 2066387635:
					AutoSaveOnQuit = (bool) p_Value;
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
				case 1134474212:
					return FileName;

				case 4236678091:
					return ContentName;

				case 1134658022:
					return FileSize;

				case 958915349:
					return Options;

				case 2066387635:
					return AutoSaveOnQuit;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1134474212:
					return typeof(ProfileOptionsAsset).GetProperty(nameof(FileName));

				case 4236678091:
					return typeof(ProfileOptionsAsset).GetProperty(nameof(ContentName));

				case 1134658022:
					return typeof(ProfileOptionsAsset).GetProperty(nameof(FileSize));

				case 958915349:
					return typeof(ProfileOptionsAsset).GetProperty(nameof(Options));

				case 2066387635:
					return typeof(ProfileOptionsAsset).GetProperty(nameof(AutoSaveOnQuit));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
