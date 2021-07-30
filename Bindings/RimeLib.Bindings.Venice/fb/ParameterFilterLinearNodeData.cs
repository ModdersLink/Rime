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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class ParameterFilterLinearNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_In = new AudioGraphNodePort();
		[ContainerField(Name: "In", Offset: 8, NameHash: 5862146, Flags: 41)]
		public AudioGraphNodePort In { get { return m_In; } set { if (OnPropertyChanging("ParameterFilterLinearNodeData." + nameof(In), this, m_In, value)) m_In = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(Name: "Out", Offset: 16, NameHash: 193453899, Flags: 41)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("ParameterFilterLinearNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_AttackSpeed = new AudioGraphNodePort();
		[ContainerField(Name: "AttackSpeed", Offset: 24, NameHash: 3633653226, Flags: 41)]
		public AudioGraphNodePort AttackSpeed { get { return m_AttackSpeed; } set { if (OnPropertyChanging("ParameterFilterLinearNodeData." + nameof(AttackSpeed), this, m_AttackSpeed, value)) m_AttackSpeed = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_ReleaseSpeed = new AudioGraphNodePort();
		[ContainerField(Name: "ReleaseSpeed", Offset: 32, NameHash: 3687083307, Flags: 41)]
		public AudioGraphNodePort ReleaseSpeed { get { return m_ReleaseSpeed; } set { if (OnPropertyChanging("ParameterFilterLinearNodeData." + nameof(ReleaseSpeed), this, m_ReleaseSpeed, value)) m_ReleaseSpeed = value; } } // 0x20 (32)
		
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

				case 3633653226:
					AttackSpeed = (AudioGraphNodePort) p_Value;
					break;

				case 3687083307:
					ReleaseSpeed = (AudioGraphNodePort) p_Value;
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

				case 3633653226:
					return AttackSpeed;

				case 3687083307:
					return ReleaseSpeed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(ParameterFilterLinearNodeData).GetProperty(nameof(In));

				case 193453899:
					return typeof(ParameterFilterLinearNodeData).GetProperty(nameof(Out));

				case 3633653226:
					return typeof(ParameterFilterLinearNodeData).GetProperty(nameof(AttackSpeed));

				case 3687083307:
					return typeof(ParameterFilterLinearNodeData).GetProperty(nameof(ReleaseSpeed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
