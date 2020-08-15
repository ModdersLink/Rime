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
	public class PeerServerBackendData : 
		ServerBackendData
	{
		protected PeerCreateGameParameters m_CreateParameters = new PeerCreateGameParameters();
		[ContainerField(16), ContainerFieldNameHash(4233299195)]
		public PeerCreateGameParameters CreateParameters { get { return m_CreateParameters; } set { if (OnPropertyChanging("PeerServerBackendData." + nameof(CreateParameters), this, m_CreateParameters, value)) m_CreateParameters = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4233299195:
					CreateParameters = (PeerCreateGameParameters) p_Value;
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
				case 4233299195:
					return CreateParameters;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4233299195:
					return typeof(PeerServerBackendData).GetProperty(nameof(CreateParameters));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
