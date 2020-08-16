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
	public class CreateRawFileParams : 
		DataContainer
	{
		protected string m_AssetName = string.Empty;
		[ContainerField(8), LayoutImmutable, ContainerFieldNameHash(3654276786)]
		public string AssetName { get { return m_AssetName; } set { if (OnPropertyChanging("CreateRawFileParams." + nameof(AssetName), this, m_AssetName, value)) m_AssetName = value; } } // 0x8 (8)
		
		protected string m_SourceFile = string.Empty;
		[ContainerField(12), LayoutImmutable, ContainerFieldNameHash(1522844286)]
		public string SourceFile { get { return m_SourceFile; } set { if (OnPropertyChanging("CreateRawFileParams." + nameof(SourceFile), this, m_SourceFile, value)) m_SourceFile = value; } } // 0xC (12)
		
		protected bool m_CreateResource = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(4248986347)]
		public bool CreateResource { get { return m_CreateResource; } set { if (OnPropertyChanging("CreateRawFileParams." + nameof(CreateResource), this, m_CreateResource, value)) m_CreateResource = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3654276786:
					AssetName = (string) p_Value;
					break;

				case 1522844286:
					SourceFile = (string) p_Value;
					break;

				case 4248986347:
					CreateResource = (bool) p_Value;
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
				case 3654276786:
					return AssetName;

				case 1522844286:
					return SourceFile;

				case 4248986347:
					return CreateResource;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3654276786:
					return typeof(CreateRawFileParams).GetProperty(nameof(AssetName));

				case 1522844286:
					return typeof(CreateRawFileParams).GetProperty(nameof(SourceFile));

				case 4248986347:
					return typeof(CreateRawFileParams).GetProperty(nameof(CreateResource));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
