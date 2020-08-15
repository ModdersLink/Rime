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
	public class OnlineServicesAsset : 
		Asset
	{
		protected RefArray<PresenceServiceData> m_OnlineServices = new RefArray<PresenceServiceData>();
		[ContainerField(12), ContainerFieldNameHash(1539201604)]
		public RefArray<PresenceServiceData> OnlineServices { get { return m_OnlineServices; } set { if (OnPropertyChanging("OnlineServicesAsset." + nameof(OnlineServices), this, m_OnlineServices, value)) m_OnlineServices = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1539201604:
					OnlineServices = (RefArray<PresenceServiceData>) p_Value;
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
				case 1539201604:
					return OnlineServices;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1539201604:
					return typeof(OnlineServicesAsset).GetProperty(nameof(OnlineServices));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
