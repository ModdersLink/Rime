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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class ProfileOptionsAsset : 
		Asset
	{
		protected string m_FileName = string.Empty;
		[ContainerField(Name: "FileName", Offset: 12, NameHash: 1134474212, Flags: 16509), LayoutImmutable]
		public string FileName { get { return m_FileName; } set { if (OnPropertyChanging("ProfileOptionsAsset." + nameof(FileName), this, m_FileName, value)) m_FileName = value; } } // 0xC (12)
		
		protected string m_ContentName = string.Empty;
		[ContainerField(Name: "ContentName", Offset: 16, NameHash: 4236678091, Flags: 16509), LayoutImmutable]
		public string ContentName { get { return m_ContentName; } set { if (OnPropertyChanging("ProfileOptionsAsset." + nameof(ContentName), this, m_ContentName, value)) m_ContentName = value; } } // 0x10 (16)
		
		protected uint m_FileSize = new uint();
		[ContainerField(Name: "FileSize", Offset: 20, NameHash: 1134658022, Flags: 49421), LayoutImmutable, Blittable]
		public uint FileSize { get { return m_FileSize; } set { if (OnPropertyChanging("ProfileOptionsAsset." + nameof(FileSize), this, m_FileSize, value)) m_FileSize = value; } } // 0x14 (20)
		
		protected RefArray<ProfileOptionData> m_Options = new RefArray<ProfileOptionData>();
		[ContainerField(Name: "Options", Offset: 24, NameHash: 958915349, Flags: 65)]
		public RefArray<ProfileOptionData> Options { get { return m_Options; } set { if (OnPropertyChanging("ProfileOptionsAsset." + nameof(Options), this, m_Options, value)) m_Options = value; } } // 0x18 (24)
		
		protected bool m_AutoSaveOnQuit = new bool();
		[ContainerField(Name: "AutoSaveOnQuit", Offset: 28, NameHash: 2066387635, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoSaveOnQuit { get { return m_AutoSaveOnQuit; } set { if (OnPropertyChanging("ProfileOptionsAsset." + nameof(AutoSaveOnQuit), this, m_AutoSaveOnQuit, value)) m_AutoSaveOnQuit = value; } } // 0x1C (28)
		
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
