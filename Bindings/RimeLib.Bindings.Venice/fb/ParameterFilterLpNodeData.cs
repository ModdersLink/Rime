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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class ParameterFilterLpNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(Name: "In", Offset: 8, NameHash: 5862146, Flags: 41)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("ParameterFilterLpNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(Name: "Out", Offset: 16, NameHash: 193453899, Flags: 41)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("ParameterFilterLpNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Hz = new AudioGraphNodePort();
		[ContainerField(Name: "Hz", Offset: 24, NameHash: 5862391, Flags: 41)]
		public AudioGraphNodePort Hz { get { return m_Hz; } set { if (OnPropertyChanging("ParameterFilterLpNodeData." + nameof(Hz), this, m_Hz, value)) m_Hz = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 5862391:
					Hz = (AudioGraphNodePort) p_Value;
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

				case 193453899:
					return Out;

				case 5862391:
					return Hz;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(ParameterFilterLpNodeData).GetProperty(nameof(In));

				case 193453899:
					return typeof(ParameterFilterLpNodeData).GetProperty(nameof(Out));

				case 5862391:
					return typeof(ParameterFilterLpNodeData).GetProperty(nameof(Hz));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
