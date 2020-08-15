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
	public class DelayNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(8), ContainerFieldNameHash(5862146)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("DelayNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_DelayTime = new AudioGraphNodePort();
		[ContainerField(16), ContainerFieldNameHash(3694246245)]
		public AudioGraphNodePort DelayTime { get { return m_DelayTime; } set { if (OnPropertyChanging("DelayNodeData." + nameof(DelayTime), this, m_DelayTime, value)) m_DelayTime = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Feedback = new AudioGraphNodePort();
		[ContainerField(24), ContainerFieldNameHash(229061996)]
		public AudioGraphNodePort Feedback { get { return m_Feedback; } set { if (OnPropertyChanging("DelayNodeData." + nameof(Feedback), this, m_Feedback, value)) m_Feedback = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(32), ContainerFieldNameHash(193453899)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("DelayNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x20 (32)
		
		protected float m_MaxDelayTime = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(3367546161)]
		public float MaxDelayTime { get { return m_MaxDelayTime; } set { if (OnPropertyChanging("DelayNodeData." + nameof(MaxDelayTime), this, m_MaxDelayTime, value)) m_MaxDelayTime = value; } } // 0x28 (40)
		
		protected SoundGraphPluginRef m_Plugin = new SoundGraphPluginRef();
		[ContainerField(44), ContainerFieldNameHash(3384353452)]
		public SoundGraphPluginRef Plugin { get { return m_Plugin; } set { if (OnPropertyChanging("DelayNodeData." + nameof(Plugin), this, m_Plugin, value)) m_Plugin = value; } } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 3694246245:
					DelayTime = (AudioGraphNodePort) p_Value;
					break;

				case 229061996:
					Feedback = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 3367546161:
					MaxDelayTime = (float) p_Value;
					break;

				case 3384353452:
					Plugin = (SoundGraphPluginRef) p_Value;
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
				case 5862146:
					return In;

				case 3694246245:
					return DelayTime;

				case 229061996:
					return Feedback;

				case 193453899:
					return Out;

				case 3367546161:
					return MaxDelayTime;

				case 3384353452:
					return Plugin;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(DelayNodeData).GetProperty(nameof(In));

				case 3694246245:
					return typeof(DelayNodeData).GetProperty(nameof(DelayTime));

				case 229061996:
					return typeof(DelayNodeData).GetProperty(nameof(Feedback));

				case 193453899:
					return typeof(DelayNodeData).GetProperty(nameof(Out));

				case 3367546161:
					return typeof(DelayNodeData).GetProperty(nameof(MaxDelayTime));

				case 3384353452:
					return typeof(DelayNodeData).GetProperty(nameof(Plugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
