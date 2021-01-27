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
	public class DeMuxNodeData : 
		AudioGraphNodeData
	{
		protected RefArray<DeMuxOutput> m_Outputs = new RefArray<DeMuxOutput>();
		[ContainerField(Name: "Outputs", Offset: 8, NameHash: 1070022089, Flags: 65)]
		public RefArray<DeMuxOutput> Outputs { get { return m_Outputs; } set { if (OnPropertyChanging("DeMuxNodeData." + nameof(Outputs), this, m_Outputs, value)) m_Outputs = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Trigger = new AudioGraphNodePort();
		[ContainerField(Name: "Trigger", Offset: 12, NameHash: 2606354109, Flags: 41)]
		public AudioGraphNodePort Trigger { get { return m_Trigger; } set { if (OnPropertyChanging("DeMuxNodeData." + nameof(Trigger), this, m_Trigger, value)) m_Trigger = value; } } // 0xC (12)
		
		protected AudioGraphNodePort m_Value = new AudioGraphNodePort();
		[ContainerField(Name: "Value", Offset: 20, NameHash: 225375086, Flags: 41)]
		public AudioGraphNodePort Value { get { return m_Value; } set { if (OnPropertyChanging("DeMuxNodeData." + nameof(Value), this, m_Value, value)) m_Value = value; } } // 0x14 (20)
		
		protected bool m_WrapValue = new bool();
		[ContainerField(Name: "WrapValue", Offset: 28, NameHash: 1779662746, Flags: 49325), LayoutImmutable, Blittable]
		public bool WrapValue { get { return m_WrapValue; } set { if (OnPropertyChanging("DeMuxNodeData." + nameof(WrapValue), this, m_WrapValue, value)) m_WrapValue = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1070022089:
					Outputs = (RefArray<DeMuxOutput>) p_Value;
					break;

				case 2606354109:
					Trigger = (AudioGraphNodePort) p_Value;
					break;

				case 225375086:
					Value = (AudioGraphNodePort) p_Value;
					break;

				case 1779662746:
					WrapValue = (bool) p_Value;
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
				case 1070022089:
					return Outputs;

				case 2606354109:
					return Trigger;

				case 225375086:
					return Value;

				case 1779662746:
					return WrapValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1070022089:
					return typeof(DeMuxNodeData).GetProperty(nameof(Outputs));

				case 2606354109:
					return typeof(DeMuxNodeData).GetProperty(nameof(Trigger));

				case 225375086:
					return typeof(DeMuxNodeData).GetProperty(nameof(Value));

				case 1779662746:
					return typeof(DeMuxNodeData).GetProperty(nameof(WrapValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
