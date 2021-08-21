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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 24)]
	public class StaticEnlightenData : 
		Asset
	{
		protected CtrRef<TextureAsset> m_StaticIrradianceChromaTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "StaticIrradianceChromaTexture", Offset: 12, NameHash: 1710622452, Flags: 53)]
		public CtrRef<TextureAsset> StaticIrradianceChromaTexture { get { return m_StaticIrradianceChromaTexture; } set { if (OnPropertyChanging("StaticEnlightenData." + nameof(StaticIrradianceChromaTexture), this, m_StaticIrradianceChromaTexture, value)) m_StaticIrradianceChromaTexture = value; } } // 0xC (12)
		
		protected CtrRef<TextureAsset> m_StaticIrradianceLumaTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "StaticIrradianceLumaTexture", Offset: 16, NameHash: 125414651, Flags: 53)]
		public CtrRef<TextureAsset> StaticIrradianceLumaTexture { get { return m_StaticIrradianceLumaTexture; } set { if (OnPropertyChanging("StaticEnlightenData." + nameof(StaticIrradianceLumaTexture), this, m_StaticIrradianceLumaTexture, value)) m_StaticIrradianceLumaTexture = value; } } // 0x10 (16)
		
		protected CtrRef<TextureAsset> m_StaticDirectionTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "StaticDirectionTexture", Offset: 20, NameHash: 2658604391, Flags: 53)]
		public CtrRef<TextureAsset> StaticDirectionTexture { get { return m_StaticDirectionTexture; } set { if (OnPropertyChanging("StaticEnlightenData." + nameof(StaticDirectionTexture), this, m_StaticDirectionTexture, value)) m_StaticDirectionTexture = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1710622452:
					StaticIrradianceChromaTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 125414651:
					StaticIrradianceLumaTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2658604391:
					StaticDirectionTexture = (CtrRef<TextureAsset>) p_Value;
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
				case 1710622452:
					return StaticIrradianceChromaTexture;

				case 125414651:
					return StaticIrradianceLumaTexture;

				case 2658604391:
					return StaticDirectionTexture;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1710622452:
					return typeof(StaticEnlightenData).GetProperty(nameof(StaticIrradianceChromaTexture));

				case 125414651:
					return typeof(StaticEnlightenData).GetProperty(nameof(StaticIrradianceLumaTexture));

				case 2658604391:
					return typeof(StaticEnlightenData).GetProperty(nameof(StaticDirectionTexture));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
