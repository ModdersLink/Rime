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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class BlueprintBundleMetadata : 
		DataContainer
	{
		protected string m_BundlePathName = string.Empty;
		[ContainerField(Name: "BundlePathName", Offset: 8, NameHash: 852575899, Flags: 16509), LayoutImmutable]
		public string BundlePathName { get { return m_BundlePathName; } set { if (OnPropertyChanging("BlueprintBundleMetadata." + nameof(BundlePathName), this, m_BundlePathName, value)) m_BundlePathName = value; } } // 0x8 (8)
		
		protected string m_BundleName = string.Empty;
		[ContainerField(Name: "BundleName", Offset: 12, NameHash: 461157046, Flags: 16509), LayoutImmutable]
		public string BundleName { get { return m_BundleName; } set { if (OnPropertyChanging("BlueprintBundleMetadata." + nameof(BundleName), this, m_BundleName, value)) m_BundleName = value; } } // 0xC (12)
		
		protected string m_BlueprintName = string.Empty;
		[ContainerField(Name: "BlueprintName", Offset: 16, NameHash: 289256909, Flags: 16509), LayoutImmutable]
		public string BlueprintName { get { return m_BlueprintName; } set { if (OnPropertyChanging("BlueprintBundleMetadata." + nameof(BlueprintName), this, m_BlueprintName, value)) m_BlueprintName = value; } } // 0x10 (16)
		
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
