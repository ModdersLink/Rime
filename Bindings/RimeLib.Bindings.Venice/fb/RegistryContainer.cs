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
	[ContainerType(4)]
	public class RegistryContainer : 
		DataContainer
	{
		protected RefArray<DataContainer> m_EntityRegistry = new RefArray<DataContainer>();
		[ContainerField(8), ContainerFieldNameHash(398962539)]
		public RefArray<DataContainer> EntityRegistry { get { return m_EntityRegistry; } set { if (OnPropertyChanging("RegistryContainer." + nameof(EntityRegistry), this, m_EntityRegistry, value)) m_EntityRegistry = value; } } // 0x8 (8)
		
		protected RefArray<DataContainer> m_AssetRegistry = new RefArray<DataContainer>();
		[ContainerField(12), ContainerFieldNameHash(3305796672)]
		public RefArray<DataContainer> AssetRegistry { get { return m_AssetRegistry; } set { if (OnPropertyChanging("RegistryContainer." + nameof(AssetRegistry), this, m_AssetRegistry, value)) m_AssetRegistry = value; } } // 0xC (12)
		
		protected RefArray<DataContainer> m_BlueprintRegistry = new RefArray<DataContainer>();
		[ContainerField(16), ContainerFieldNameHash(3531202111)]
		public RefArray<DataContainer> BlueprintRegistry { get { return m_BlueprintRegistry; } set { if (OnPropertyChanging("RegistryContainer." + nameof(BlueprintRegistry), this, m_BlueprintRegistry, value)) m_BlueprintRegistry = value; } } // 0x10 (16)
		
		protected RefArray<DataContainer> m_ReferenceObjectRegistry = new RefArray<DataContainer>();
		[ContainerField(20), ContainerFieldNameHash(1248214958)]
		public RefArray<DataContainer> ReferenceObjectRegistry { get { return m_ReferenceObjectRegistry; } set { if (OnPropertyChanging("RegistryContainer." + nameof(ReferenceObjectRegistry), this, m_ReferenceObjectRegistry, value)) m_ReferenceObjectRegistry = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 398962539:
					EntityRegistry = (RefArray<DataContainer>) p_Value;
					break;

				case 3305796672:
					AssetRegistry = (RefArray<DataContainer>) p_Value;
					break;

				case 3531202111:
					BlueprintRegistry = (RefArray<DataContainer>) p_Value;
					break;

				case 1248214958:
					ReferenceObjectRegistry = (RefArray<DataContainer>) p_Value;
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
				case 398962539:
					return EntityRegistry;

				case 3305796672:
					return AssetRegistry;

				case 3531202111:
					return BlueprintRegistry;

				case 1248214958:
					return ReferenceObjectRegistry;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 398962539:
					return typeof(RegistryContainer).GetProperty(nameof(EntityRegistry));

				case 3305796672:
					return typeof(RegistryContainer).GetProperty(nameof(AssetRegistry));

				case 3531202111:
					return typeof(RegistryContainer).GetProperty(nameof(BlueprintRegistry));

				case 1248214958:
					return typeof(RegistryContainer).GetProperty(nameof(ReferenceObjectRegistry));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
