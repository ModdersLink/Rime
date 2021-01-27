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
	public class BlueprintBundle : 
		Asset
	{
		protected CtrRef<Blueprint> m_Blueprint = new CtrRef<Blueprint>();
		[ContainerField(Name: "Blueprint", Offset: 12, NameHash: 4232469066, Flags: 53)]
		public CtrRef<Blueprint> Blueprint { get { return m_Blueprint; } set { if (OnPropertyChanging("BlueprintBundle." + nameof(Blueprint), this, m_Blueprint, value)) m_Blueprint = value; } } // 0xC (12)
		
		protected CtrRef<RegistryContainer> m_RegistryContainer = new CtrRef<RegistryContainer>();
		[ContainerField(Name: "RegistryContainer", Offset: 16, NameHash: 1535522391, Flags: 53)]
		public CtrRef<RegistryContainer> RegistryContainer { get { return m_RegistryContainer; } set { if (OnPropertyChanging("BlueprintBundle." + nameof(RegistryContainer), this, m_RegistryContainer, value)) m_RegistryContainer = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4232469066:
					Blueprint = (CtrRef<Blueprint>) p_Value;
					break;

				case 1535522391:
					RegistryContainer = (CtrRef<RegistryContainer>) p_Value;
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
				case 4232469066:
					return Blueprint;

				case 1535522391:
					return RegistryContainer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4232469066:
					return typeof(BlueprintBundle).GetProperty(nameof(Blueprint));

				case 1535522391:
					return typeof(BlueprintBundle).GetProperty(nameof(RegistryContainer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
