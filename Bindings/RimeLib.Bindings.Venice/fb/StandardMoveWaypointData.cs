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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 96)]
	public class StandardMoveWaypointData : 
		AbstractLocoWaypointData
	{
		protected AILocoMoveTaskData m_MoveTask = new AILocoMoveTaskData();
		[ContainerField(Name: "MoveTask", Offset: 48, NameHash: 1607355097, Flags: 41)]
		public AILocoMoveTaskData MoveTask { get { return m_MoveTask; } set { if (OnPropertyChanging("StandardMoveWaypointData." + nameof(MoveTask), this, m_MoveTask, value)) m_MoveTask = value; } } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1607355097:
					MoveTask = (AILocoMoveTaskData) p_Value;
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
				case 1607355097:
					return MoveTask;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1607355097:
					return typeof(StandardMoveWaypointData).GetProperty(nameof(MoveTask));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
