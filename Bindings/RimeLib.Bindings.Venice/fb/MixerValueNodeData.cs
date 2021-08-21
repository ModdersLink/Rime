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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class MixerValueNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(Name: "Out", Offset: 8, NameHash: 193453899, Flags: 41)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("MixerValueNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x8 (8)
		
		protected float m_DefaultValue = new float();
		[ContainerField(Name: "DefaultValue", Offset: 16, NameHash: 2066049125, Flags: 49469), LayoutImmutable, Blittable]
		public float DefaultValue { get { return m_DefaultValue; } set { if (OnPropertyChanging("MixerValueNodeData." + nameof(DefaultValue), this, m_DefaultValue, value)) m_DefaultValue = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 2066049125:
					DefaultValue = (float) p_Value;
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
				case 193453899:
					return Out;

				case 2066049125:
					return DefaultValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193453899:
					return typeof(MixerValueNodeData).GetProperty(nameof(Out));

				case 2066049125:
					return typeof(MixerValueNodeData).GetProperty(nameof(DefaultValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
