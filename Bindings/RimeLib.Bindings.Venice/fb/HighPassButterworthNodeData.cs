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
	public class HighPassButterworthNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(8), ContainerFieldNameHash(5862146)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("HighPassButterworthNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Frequency = new AudioGraphNodePort();
		[ContainerField(16), ContainerFieldNameHash(4112821953)]
		public AudioGraphNodePort Frequency { get { return m_Frequency; } set { if (OnPropertyChanging("HighPassButterworthNodeData." + nameof(Frequency), this, m_Frequency, value)) m_Frequency = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Order = new AudioGraphNodePort();
		[ContainerField(24), ContainerFieldNameHash(217604235)]
		public AudioGraphNodePort Order { get { return m_Order; } set { if (OnPropertyChanging("HighPassButterworthNodeData." + nameof(Order), this, m_Order, value)) m_Order = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(32), ContainerFieldNameHash(193453899)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("HighPassButterworthNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x20 (32)
		
		protected SoundGraphPluginRef m_Plugin = new SoundGraphPluginRef();
		[ContainerField(40), ContainerFieldNameHash(3384353452)]
		public SoundGraphPluginRef Plugin { get { return m_Plugin; } set { if (OnPropertyChanging("HighPassButterworthNodeData." + nameof(Plugin), this, m_Plugin, value)) m_Plugin = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 4112821953:
					Frequency = (AudioGraphNodePort) p_Value;
					break;

				case 217604235:
					Order = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
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

				case 4112821953:
					return Frequency;

				case 217604235:
					return Order;

				case 193453899:
					return Out;

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
					return typeof(HighPassButterworthNodeData).GetProperty(nameof(In));

				case 4112821953:
					return typeof(HighPassButterworthNodeData).GetProperty(nameof(Frequency));

				case 217604235:
					return typeof(HighPassButterworthNodeData).GetProperty(nameof(Order));

				case 193453899:
					return typeof(HighPassButterworthNodeData).GetProperty(nameof(Out));

				case 3384353452:
					return typeof(HighPassButterworthNodeData).GetProperty(nameof(Plugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
