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
	public class ReceiveEntry : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(Name: "Out", Offset: 8, NameHash: 193453899, Flags: 41)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("ReceiveEntry." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x8 (8)
		
		protected CtrRef<AudioGraphParameter> m_Source = new CtrRef<AudioGraphParameter>();
		[ContainerField(Name: "Source", Offset: 16, NameHash: 3339738264, Flags: 53)]
		public CtrRef<AudioGraphParameter> Source { get { return m_Source; } set { if (OnPropertyChanging("ReceiveEntry." + nameof(Source), this, m_Source, value)) m_Source = value; } } // 0x10 (16)
		
		protected float m_Parameter = new float();
		[ContainerField(Name: "Parameter", Offset: 20, NameHash: 2964084716, Flags: 49469), LayoutImmutable, Blittable]
		public float Parameter { get { return m_Parameter; } set { if (OnPropertyChanging("ReceiveEntry." + nameof(Parameter), this, m_Parameter, value)) m_Parameter = value; } } // 0x14 (20)
		
		protected float m_SavedValue = new float();
		[ContainerField(Name: "SavedValue", Offset: 24, NameHash: 2552725931, Flags: 49469), LayoutImmutable, Blittable]
		public float SavedValue { get { return m_SavedValue; } set { if (OnPropertyChanging("ReceiveEntry." + nameof(SavedValue), this, m_SavedValue, value)) m_SavedValue = value; } } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 3339738264:
					Source = (CtrRef<AudioGraphParameter>) p_Value;
					break;

				case 2964084716:
					Parameter = (float) p_Value;
					break;

				case 2552725931:
					SavedValue = (float) p_Value;
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

				case 3339738264:
					return Source;

				case 2964084716:
					return Parameter;

				case 2552725931:
					return SavedValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193453899:
					return typeof(ReceiveEntry).GetProperty(nameof(Out));

				case 3339738264:
					return typeof(ReceiveEntry).GetProperty(nameof(Source));

				case 2964084716:
					return typeof(ReceiveEntry).GetProperty(nameof(Parameter));

				case 2552725931:
					return typeof(ReceiveEntry).GetProperty(nameof(SavedValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
