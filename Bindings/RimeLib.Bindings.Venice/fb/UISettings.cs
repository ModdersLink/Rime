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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 36)]
	public class UISettings : 
		SystemSettings
	{
		protected UISystemType m_System = new UISystemType();
		[ContainerField(Name: "System", Offset: 12, NameHash: 3333232768, Flags: 137)]
		public UISystemType System { get { return m_System; } set { if (OnPropertyChanging("UISettings." + nameof(System), this, m_System, value)) m_System = value; } } // 0xC (12)
		
		protected CtrRef<UIBundlesAsset> m_Bundles = new CtrRef<UIBundlesAsset>();
		[ContainerField(Name: "Bundles", Offset: 16, NameHash: 2774764642, Flags: 53)]
		public CtrRef<UIBundlesAsset> Bundles { get { return m_Bundles; } set { if (OnPropertyChanging("UISettings." + nameof(Bundles), this, m_Bundles, value)) m_Bundles = value; } } // 0x10 (16)
		
		protected CtrRef<ProfileOptionsAsset> m_ProfileOptions = new CtrRef<ProfileOptionsAsset>();
		[ContainerField(Name: "ProfileOptions", Offset: 20, NameHash: 1140566110, Flags: 53)]
		public CtrRef<ProfileOptionsAsset> ProfileOptions { get { return m_ProfileOptions; } set { if (OnPropertyChanging("UISettings." + nameof(ProfileOptions), this, m_ProfileOptions, value)) m_ProfileOptions = value; } } // 0x14 (20)
		
		protected LanguageFormat m_Language = new LanguageFormat();
		[ContainerField(Name: "Language", Offset: 24, NameHash: 3872303031, Flags: 137)]
		public LanguageFormat Language { get { return m_Language; } set { if (OnPropertyChanging("UISettings." + nameof(Language), this, m_Language, value)) m_Language = value; } } // 0x18 (24)
		
		protected DataCopSettings m_DataCop = new DataCopSettings();
		[ContainerField(Name: "DataCop", Offset: 28, NameHash: 3872848489, Flags: 41)]
		public DataCopSettings DataCop { get { return m_DataCop; } set { if (OnPropertyChanging("UISettings." + nameof(DataCop), this, m_DataCop, value)) m_DataCop = value; } } // 0x1C (28)
		
		protected bool m_OneBundlePerGraph = new bool();
		[ContainerField(Name: "OneBundlePerGraph", Offset: 32, NameHash: 1787189790, Flags: 49325), LayoutImmutable, Blittable]
		public bool OneBundlePerGraph { get { return m_OneBundlePerGraph; } set { if (OnPropertyChanging("UISettings." + nameof(OneBundlePerGraph), this, m_OneBundlePerGraph, value)) m_OneBundlePerGraph = value; } } // 0x20 (32)
		
		protected bool m_DrawEnable = new bool();
		[ContainerField(Name: "DrawEnable", Offset: 33, NameHash: 1347356004, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawEnable { get { return m_DrawEnable; } set { if (OnPropertyChanging("UISettings." + nameof(DrawEnable), this, m_DrawEnable, value)) m_DrawEnable = value; } } // 0x21 (33)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3333232768:
					System = (UISystemType) Enum.ToObject(typeof(UISystemType), p_Value);
					break;

				case 2774764642:
					Bundles = (CtrRef<UIBundlesAsset>) p_Value;
					break;

				case 1140566110:
					ProfileOptions = (CtrRef<ProfileOptionsAsset>) p_Value;
					break;

				case 3872303031:
					Language = (LanguageFormat) Enum.ToObject(typeof(LanguageFormat), p_Value);
					break;

				case 3872848489:
					DataCop = (DataCopSettings) p_Value;
					break;

				case 1787189790:
					OneBundlePerGraph = (bool) p_Value;
					break;

				case 1347356004:
					DrawEnable = (bool) p_Value;
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
				case 3333232768:
					return System;

				case 2774764642:
					return Bundles;

				case 1140566110:
					return ProfileOptions;

				case 3872303031:
					return Language;

				case 3872848489:
					return DataCop;

				case 1787189790:
					return OneBundlePerGraph;

				case 1347356004:
					return DrawEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3333232768:
					return typeof(UISettings).GetProperty(nameof(System));

				case 2774764642:
					return typeof(UISettings).GetProperty(nameof(Bundles));

				case 1140566110:
					return typeof(UISettings).GetProperty(nameof(ProfileOptions));

				case 3872303031:
					return typeof(UISettings).GetProperty(nameof(Language));

				case 3872848489:
					return typeof(UISettings).GetProperty(nameof(DataCop));

				case 1787189790:
					return typeof(UISettings).GetProperty(nameof(OneBundlePerGraph));

				case 1347356004:
					return typeof(UISettings).GetProperty(nameof(DrawEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
