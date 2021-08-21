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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class BlueprintBundleStateLogicEntityData : 
		GameEntityData
	{
		protected List<string> m_BundleNames = new List<string>();
		[ContainerField(Name: "BundleNames", Offset: 96, NameHash: 2333280517, Flags: 65)]
		public List<string> BundleNames { get { return m_BundleNames; } set { if (OnPropertyChanging("BlueprintBundleStateLogicEntityData." + nameof(BundleNames), this, m_BundleNames, value)) m_BundleNames = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2333280517:
					BundleNames = (List<string>) p_Value;
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
				case 2333280517:
					return BundleNames;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2333280517:
					return typeof(BlueprintBundleStateLogicEntityData).GetProperty(nameof(BundleNames));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
