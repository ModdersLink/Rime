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
	[ContainerType(8), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class ClientJuiceState : 
		MetricState
	{
		protected int m_SessionId = new int();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1655214230)]
		public int SessionId { get { return m_SessionId; } set { if (OnPropertyChanging("ClientJuiceState." + nameof(SessionId), this, m_SessionId, value)) m_SessionId = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1655214230:
					SessionId = (int) p_Value;
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
				case 1655214230:
					return SessionId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1655214230:
					return typeof(ClientJuiceState).GetProperty(nameof(SessionId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
