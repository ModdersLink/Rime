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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 28)]
	public class BusNodeData : 
		SoundBusData
	{
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(Name: "Out", Offset: 16, NameHash: 193453899, Flags: 41)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("BusNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x10 (16)
		
		protected SoundGraphPluginRef m_VuPlugin = new SoundGraphPluginRef();
		[ContainerField(Name: "VuPlugin", Offset: 24, NameHash: 2033640783, Flags: 41)]
		public SoundGraphPluginRef VuPlugin { get { return m_VuPlugin; } set { if (OnPropertyChanging("BusNodeData." + nameof(VuPlugin), this, m_VuPlugin, value)) m_VuPlugin = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 2033640783:
					VuPlugin = (SoundGraphPluginRef) p_Value;
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

				case 2033640783:
					return VuPlugin;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193453899:
					return typeof(BusNodeData).GetProperty(nameof(Out));

				case 2033640783:
					return typeof(BusNodeData).GetProperty(nameof(VuPlugin));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
