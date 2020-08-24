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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class AbstractLocoWaypointData : 
		WaypointData
	{
		protected AILocoBaseTaskData m_BaseTask = new AILocoBaseTaskData();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(3174633565)]
		public AILocoBaseTaskData BaseTask { get { return m_BaseTask; } set { if (OnPropertyChanging("AbstractLocoWaypointData." + nameof(BaseTask), this, m_BaseTask, value)) m_BaseTask = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3174633565:
					BaseTask = (AILocoBaseTaskData) p_Value;
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
				case 3174633565:
					return BaseTask;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3174633565:
					return typeof(AbstractLocoWaypointData).GetProperty(nameof(BaseTask));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
