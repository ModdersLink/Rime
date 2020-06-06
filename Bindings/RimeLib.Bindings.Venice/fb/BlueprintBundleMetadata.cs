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
	public class BlueprintBundleMetadata : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable]
		public string BundlePathName { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable]
		public string BundleName { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable]
		public string BlueprintName { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 852575899:
					BundlePathName = (string) p_Value;
					break;

				case 461157046:
					BundleName = (string) p_Value;
					break;

				case 289256909:
					BlueprintName = (string) p_Value;
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
				case 852575899:
					return BundlePathName;

				case 461157046:
					return BundleName;

				case 289256909:
					return BlueprintName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 852575899:
					return typeof(BlueprintBundleMetadata).GetProperty(nameof(BundlePathName));

				case 461157046:
					return typeof(BlueprintBundleMetadata).GetProperty(nameof(BundleName));

				case 289256909:
					return typeof(BlueprintBundleMetadata).GetProperty(nameof(BlueprintName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
