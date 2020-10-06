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
	public class PlayerState : 
		MetricState
	{
		protected ulong m_OnlineId = new ulong();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49453), ContainerFieldNameHash(3139508999)]
		public ulong OnlineId { get { return m_OnlineId; } set { if (OnPropertyChanging("PlayerState." + nameof(OnlineId), this, m_OnlineId, value)) m_OnlineId = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3139508999:
					OnlineId = (ulong) p_Value;
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
				case 3139508999:
					return OnlineId;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3139508999:
					return typeof(PlayerState).GetProperty(nameof(OnlineId));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
