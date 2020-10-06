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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(48), ContainerClass]
	public class CrossfaderNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In1 = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(193450867)]
		public AudioGraphNodePort In1 { get { return m_In1; } set { if (OnPropertyChanging("CrossfaderNodeData." + nameof(In1), this, m_In1, value)) m_In1 = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_In2 = new AudioGraphNodePort();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(193450864)]
		public AudioGraphNodePort In2 { get { return m_In2; } set { if (OnPropertyChanging("CrossfaderNodeData." + nameof(In2), this, m_In2, value)) m_In2 = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Ctrl = new AudioGraphNodePort();
		[ContainerField(24), MemberInfoFlag(41), ContainerFieldNameHash(2088859916)]
		public AudioGraphNodePort Ctrl { get { return m_Ctrl; } set { if (OnPropertyChanging("CrossfaderNodeData." + nameof(Ctrl), this, m_Ctrl, value)) m_Ctrl = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(32), MemberInfoFlag(41), ContainerFieldNameHash(193453899)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("CrossfaderNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x20 (32)
		
		protected SoundGraphPluginRef m_Plugin1 = new SoundGraphPluginRef();
		[ContainerField(40), MemberInfoFlag(41), ContainerFieldNameHash(14514205)]
		public SoundGraphPluginRef Plugin1 { get { return m_Plugin1; } set { if (OnPropertyChanging("CrossfaderNodeData." + nameof(Plugin1), this, m_Plugin1, value)) m_Plugin1 = value; } } // 0x28 (40)
		
		protected SoundGraphPluginRef m_Plugin2 = new SoundGraphPluginRef();
		[ContainerField(43), MemberInfoFlag(41), ContainerFieldNameHash(14514206)]
		public SoundGraphPluginRef Plugin2 { get { return m_Plugin2; } set { if (OnPropertyChanging("CrossfaderNodeData." + nameof(Plugin2), this, m_Plugin2, value)) m_Plugin2 = value; } } // 0x2B (43)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193450867:
					In1 = (AudioGraphNodePort) p_Value;
					break;

				case 193450864:
					In2 = (AudioGraphNodePort) p_Value;
					break;

				case 2088859916:
					Ctrl = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 14514205:
					Plugin1 = (SoundGraphPluginRef) p_Value;
					break;

				case 14514206:
					Plugin2 = (SoundGraphPluginRef) p_Value;
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
				case 193450867:
					return In1;

				case 193450864:
					return In2;

				case 2088859916:
					return Ctrl;

				case 193453899:
					return Out;

				case 14514205:
					return Plugin1;

				case 14514206:
					return Plugin2;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193450867:
					return typeof(CrossfaderNodeData).GetProperty(nameof(In1));

				case 193450864:
					return typeof(CrossfaderNodeData).GetProperty(nameof(In2));

				case 2088859916:
					return typeof(CrossfaderNodeData).GetProperty(nameof(Ctrl));

				case 193453899:
					return typeof(CrossfaderNodeData).GetProperty(nameof(Out));

				case 14514205:
					return typeof(CrossfaderNodeData).GetProperty(nameof(Plugin1));

				case 14514206:
					return typeof(CrossfaderNodeData).GetProperty(nameof(Plugin2));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
