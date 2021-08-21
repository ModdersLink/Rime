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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class PlayVideoEntityData : 
		EntityData
	{
		protected CtrRef<MovieTextureAsset> m_Movie = new CtrRef<MovieTextureAsset>();
		[ContainerField(Name: "Movie", Offset: 12, NameHash: 210030653, Flags: 53)]
		public CtrRef<MovieTextureAsset> Movie { get { return m_Movie; } set { if (OnPropertyChanging("PlayVideoEntityData." + nameof(Movie), this, m_Movie, value)) m_Movie = value; } } // 0xC (12)
		
		protected bool m_KeepBlackScreen = new bool();
		[ContainerField(Name: "KeepBlackScreen", Offset: 16, NameHash: 1584450997, Flags: 49325), LayoutImmutable, Blittable]
		public bool KeepBlackScreen { get { return m_KeepBlackScreen; } set { if (OnPropertyChanging("PlayVideoEntityData." + nameof(KeepBlackScreen), this, m_KeepBlackScreen, value)) m_KeepBlackScreen = value; } } // 0x10 (16)
		
		protected bool m_AllowSkip = new bool();
		[ContainerField(Name: "AllowSkip", Offset: 17, NameHash: 2314030141, Flags: 49325), LayoutImmutable, Blittable]
		public bool AllowSkip { get { return m_AllowSkip; } set { if (OnPropertyChanging("PlayVideoEntityData." + nameof(AllowSkip), this, m_AllowSkip, value)) m_AllowSkip = value; } } // 0x11 (17)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 210030653:
					Movie = (CtrRef<MovieTextureAsset>) p_Value;
					break;

				case 1584450997:
					KeepBlackScreen = (bool) p_Value;
					break;

				case 2314030141:
					AllowSkip = (bool) p_Value;
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
				case 210030653:
					return Movie;

				case 1584450997:
					return KeepBlackScreen;

				case 2314030141:
					return AllowSkip;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 210030653:
					return typeof(PlayVideoEntityData).GetProperty(nameof(Movie));

				case 1584450997:
					return typeof(PlayVideoEntityData).GetProperty(nameof(KeepBlackScreen));

				case 2314030141:
					return typeof(PlayVideoEntityData).GetProperty(nameof(AllowSkip));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
