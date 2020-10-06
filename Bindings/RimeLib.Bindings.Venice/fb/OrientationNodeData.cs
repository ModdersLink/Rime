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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(32), ContainerClass]
	public class OrientationNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_ListenerRelativeYaw = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(3524495584)]
		public AudioGraphNodePort ListenerRelativeYaw { get { return m_ListenerRelativeYaw; } set { if (OnPropertyChanging("OrientationNodeData." + nameof(ListenerRelativeYaw), this, m_ListenerRelativeYaw, value)) m_ListenerRelativeYaw = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_ListenerRelativePitch = new AudioGraphNodePort();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(2777770313)]
		public AudioGraphNodePort ListenerRelativePitch { get { return m_ListenerRelativePitch; } set { if (OnPropertyChanging("OrientationNodeData." + nameof(ListenerRelativePitch), this, m_ListenerRelativePitch, value)) m_ListenerRelativePitch = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_ListenerRelativeRoll = new AudioGraphNodePort();
		[ContainerField(24), MemberInfoFlag(41), ContainerFieldNameHash(344546642)]
		public AudioGraphNodePort ListenerRelativeRoll { get { return m_ListenerRelativeRoll; } set { if (OnPropertyChanging("OrientationNodeData." + nameof(ListenerRelativeRoll), this, m_ListenerRelativeRoll, value)) m_ListenerRelativeRoll = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3524495584:
					ListenerRelativeYaw = (AudioGraphNodePort) p_Value;
					break;

				case 2777770313:
					ListenerRelativePitch = (AudioGraphNodePort) p_Value;
					break;

				case 344546642:
					ListenerRelativeRoll = (AudioGraphNodePort) p_Value;
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
				case 3524495584:
					return ListenerRelativeYaw;

				case 2777770313:
					return ListenerRelativePitch;

				case 344546642:
					return ListenerRelativeRoll;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3524495584:
					return typeof(OrientationNodeData).GetProperty(nameof(ListenerRelativeYaw));

				case 2777770313:
					return typeof(OrientationNodeData).GetProperty(nameof(ListenerRelativePitch));

				case 344546642:
					return typeof(OrientationNodeData).GetProperty(nameof(ListenerRelativeRoll));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
