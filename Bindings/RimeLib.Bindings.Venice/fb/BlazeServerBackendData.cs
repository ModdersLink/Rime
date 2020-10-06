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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(52), ContainerClass]
	public class BlazeServerBackendData : 
		ServerBackendData
	{
		protected BlazeCreateGameParameters m_CreateParameters = new BlazeCreateGameParameters();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(4233299195)]
		public BlazeCreateGameParameters CreateParameters { get { return m_CreateParameters; } set { if (OnPropertyChanging("BlazeServerBackendData." + nameof(CreateParameters), this, m_CreateParameters, value)) m_CreateParameters = value; } } // 0x10 (16)
		
		protected OnlineEnvironmentConsoleUrl m_ConfigUrl = new OnlineEnvironmentConsoleUrl();
		[ContainerField(48), MemberInfoFlag(41), ContainerFieldNameHash(1873884036)]
		public OnlineEnvironmentConsoleUrl ConfigUrl { get { return m_ConfigUrl; } set { if (OnPropertyChanging("BlazeServerBackendData." + nameof(ConfigUrl), this, m_ConfigUrl, value)) m_ConfigUrl = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4233299195:
					CreateParameters = (BlazeCreateGameParameters) p_Value;
					break;

				case 1873884036:
					ConfigUrl = (OnlineEnvironmentConsoleUrl) p_Value;
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

				case 1873884036:
					return ConfigUrl;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4233299195:
					return typeof(BlazeServerBackendData).GetProperty(nameof(CreateParameters));

				case 1873884036:
					return typeof(BlazeServerBackendData).GetProperty(nameof(ConfigUrl));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
