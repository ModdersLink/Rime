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
	public class UIQueuedEventsCompData : 
		UIComponentData
	{
		protected float m_InitialQueueDelay = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3503517055)]
		public float InitialQueueDelay { get { return m_InitialQueueDelay; } set { if (OnPropertyChanging("UIQueuedEventsCompData." + nameof(InitialQueueDelay), this, m_InitialQueueDelay, value)) m_InitialQueueDelay = value; } } // 0x1C (28)
		
		protected bool m_ShowUnlocksBecomingAvailable = new bool();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3270144506)]
		public bool ShowUnlocksBecomingAvailable { get { return m_ShowUnlocksBecomingAvailable; } set { if (OnPropertyChanging("UIQueuedEventsCompData." + nameof(ShowUnlocksBecomingAvailable), this, m_ShowUnlocksBecomingAvailable, value)) m_ShowUnlocksBecomingAvailable = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3503517055:
					InitialQueueDelay = (float) p_Value;
					break;

				case 3270144506:
					ShowUnlocksBecomingAvailable = (bool) p_Value;
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
				case 3503517055:
					return InitialQueueDelay;

				case 3270144506:
					return ShowUnlocksBecomingAvailable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3503517055:
					return typeof(UIQueuedEventsCompData).GetProperty(nameof(InitialQueueDelay));

				case 3270144506:
					return typeof(UIQueuedEventsCompData).GetProperty(nameof(ShowUnlocksBecomingAvailable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
