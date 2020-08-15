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
	public class ServerBackendData : 
		Asset
	{
		protected List<ServerBackendAttributeMapping> m_Mappings = new List<ServerBackendAttributeMapping>();
		[ContainerField(12), ContainerFieldNameHash(673881690)]
		public List<ServerBackendAttributeMapping> Mappings { get { return m_Mappings; } set { if (OnPropertyChanging("ServerBackendData." + nameof(Mappings), this, m_Mappings, value)) m_Mappings = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 673881690:
					Mappings = (List<ServerBackendAttributeMapping>) p_Value;
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
				case 673881690:
					return Mappings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 673881690:
					return typeof(ServerBackendData).GetProperty(nameof(Mappings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
