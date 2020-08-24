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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class PlayVideoEntityData : 
		EntityData
	{
		protected CtrRef<MovieTextureAsset> m_Movie = new CtrRef<MovieTextureAsset>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(210030653), ContainerCtrRef]
		public CtrRef<MovieTextureAsset> Movie { get { return m_Movie; } set { if (OnPropertyChanging("PlayVideoEntityData." + nameof(Movie), this, m_Movie, value)) m_Movie = value; } } // 0xC (12)
		
		protected bool m_KeepBlackScreen = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1584450997)]
		public bool KeepBlackScreen { get { return m_KeepBlackScreen; } set { if (OnPropertyChanging("PlayVideoEntityData." + nameof(KeepBlackScreen), this, m_KeepBlackScreen, value)) m_KeepBlackScreen = value; } } // 0x10 (16)
		
		protected bool m_AllowSkip = new bool();
		[ContainerField(17), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2314030141)]
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
