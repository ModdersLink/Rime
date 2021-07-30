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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class MovieComponentData : 
		ComponentData
	{
		protected CtrRef<MovieTextureAsset> m_Movie = new CtrRef<MovieTextureAsset>();
		[ContainerField(Name: "Movie", Offset: 96, NameHash: 210030653, Flags: 53)]
		public CtrRef<MovieTextureAsset> Movie { get { return m_Movie; } set { if (OnPropertyChanging("MovieComponentData." + nameof(Movie), this, m_Movie, value)) m_Movie = value; } } // 0x60 (96)
		
		protected float m_ExternalTime = new float();
		[ContainerField(Name: "ExternalTime", Offset: 100, NameHash: 2162678253, Flags: 49469), LayoutImmutable, Blittable]
		public float ExternalTime { get { return m_ExternalTime; } set { if (OnPropertyChanging("MovieComponentData." + nameof(ExternalTime), this, m_ExternalTime, value)) m_ExternalTime = value; } } // 0x64 (100)
		
		protected bool m_IsNormalMap = new bool();
		[ContainerField(Name: "IsNormalMap", Offset: 104, NameHash: 797341680, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsNormalMap { get { return m_IsNormalMap; } set { if (OnPropertyChanging("MovieComponentData." + nameof(IsNormalMap), this, m_IsNormalMap, value)) m_IsNormalMap = value; } } // 0x68 (104)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 210030653:
					Movie = (CtrRef<MovieTextureAsset>) p_Value;
					break;

				case 2162678253:
					ExternalTime = (float) p_Value;
					break;

				case 797341680:
					IsNormalMap = (bool) p_Value;
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

				case 2162678253:
					return ExternalTime;

				case 797341680:
					return IsNormalMap;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 210030653:
					return typeof(MovieComponentData).GetProperty(nameof(Movie));

				case 2162678253:
					return typeof(MovieComponentData).GetProperty(nameof(ExternalTime));

				case 797341680:
					return typeof(MovieComponentData).GetProperty(nameof(IsNormalMap));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
