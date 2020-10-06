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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(128), ContainerClass]
	public class IKComponentData : 
		ComponentData
	{
		protected IKEffectorEnum m_IKEffector = new IKEffectorEnum();
		[ContainerField(96), MemberInfoFlag(137), ContainerFieldNameHash(4088955053)]
		public IKEffectorEnum IKEffector { get { return m_IKEffector; } set { if (OnPropertyChanging("IKComponentData." + nameof(IKEffector), this, m_IKEffector, value)) m_IKEffector = value; } } // 0x60 (96)
		
		protected HIKData m_IKData = new HIKData();
		[ContainerField(100), MemberInfoFlag(41), ContainerFieldNameHash(2831034455)]
		public HIKData IKData { get { return m_IKData; } set { if (OnPropertyChanging("IKComponentData." + nameof(IKData), this, m_IKData, value)) m_IKData = value; } } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4088955053:
					IKEffector = (IKEffectorEnum) Enum.ToObject(typeof(IKEffectorEnum), p_Value);
					break;

				case 2831034455:
					IKData = (HIKData) p_Value;
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
				case 4088955053:
					return IKEffector;

				case 2831034455:
					return IKData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4088955053:
					return typeof(IKComponentData).GetProperty(nameof(IKEffector));

				case 2831034455:
					return typeof(IKComponentData).GetProperty(nameof(IKData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
