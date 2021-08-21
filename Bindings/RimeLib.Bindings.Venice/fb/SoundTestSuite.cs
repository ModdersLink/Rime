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
	public class SoundTestSuite : 
		DataContainer
	{
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 8, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("SoundTestSuite." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x8 (8)
		
		protected RefArray<SoundAsset> m_Assets = new RefArray<SoundAsset>();
		[ContainerField(Name: "Assets", Offset: 12, NameHash: 2502242534, Flags: 65)]
		public RefArray<SoundAsset> Assets { get { return m_Assets; } set { if (OnPropertyChanging("SoundTestSuite." + nameof(Assets), this, m_Assets, value)) m_Assets = value; } } // 0xC (12)
		
		protected RefArray<SoundTestSpec> m_Tests = new RefArray<SoundTestSpec>();
		[ContainerField(Name: "Tests", Offset: 16, NameHash: 227718400, Flags: 65)]
		public RefArray<SoundTestSpec> Tests { get { return m_Tests; } set { if (OnPropertyChanging("SoundTestSuite." + nameof(Tests), this, m_Tests, value)) m_Tests = value; } } // 0x10 (16)
		
		protected bool m_ProfileTests = new bool();
		[ContainerField(Name: "ProfileTests", Offset: 20, NameHash: 3447328075, Flags: 49325), LayoutImmutable, Blittable]
		public bool ProfileTests { get { return m_ProfileTests; } set { if (OnPropertyChanging("SoundTestSuite." + nameof(ProfileTests), this, m_ProfileTests, value)) m_ProfileTests = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 2502242534:
					Assets = (RefArray<SoundAsset>) p_Value;
					break;

				case 227718400:
					Tests = (RefArray<SoundTestSpec>) p_Value;
					break;

				case 3447328075:
					ProfileTests = (bool) p_Value;
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
				case 2088949890:
					return Name;

				case 2502242534:
					return Assets;

				case 227718400:
					return Tests;

				case 3447328075:
					return ProfileTests;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(SoundTestSuite).GetProperty(nameof(Name));

				case 2502242534:
					return typeof(SoundTestSuite).GetProperty(nameof(Assets));

				case 227718400:
					return typeof(SoundTestSuite).GetProperty(nameof(Tests));

				case 3447328075:
					return typeof(SoundTestSuite).GetProperty(nameof(ProfileTests));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
