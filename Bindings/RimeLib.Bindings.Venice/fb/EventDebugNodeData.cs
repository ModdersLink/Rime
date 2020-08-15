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
	public class EventDebugNodeData : 
		AudioGraphNodeData
	{
		protected RefArray<DebugEventInput> m_Events = new RefArray<DebugEventInput>();
		[ContainerField(8), ContainerFieldNameHash(2352146554)]
		public RefArray<DebugEventInput> Events { get { return m_Events; } set { if (OnPropertyChanging("EventDebugNodeData." + nameof(Events), this, m_Events, value)) m_Events = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2352146554:
					Events = (RefArray<DebugEventInput>) p_Value;
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
				case 2352146554:
					return Events;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2352146554:
					return typeof(EventDebugNodeData).GetProperty(nameof(Events));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
