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
	public class SoundTestSuite : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string Name { get; set; } // 0x8 (8)
		
		[ContainerField(12)]
		public RefArray<SoundAsset> Assets { get; set; } = new RefArray<SoundAsset>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<SoundTestSpec> Tests { get; set; } = new RefArray<SoundTestSpec>(); // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool ProfileTests { get; set; } // 0x14 (20)
		
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
