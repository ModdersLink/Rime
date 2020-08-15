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
	public class LfoNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Hz = new AudioGraphNodePort();
		[ContainerField(8), ContainerFieldNameHash(5862391)]
		public AudioGraphNodePort Hz { get { return m_Hz; } set { if (OnPropertyChanging("LfoNodeData." + nameof(Hz), this, m_Hz, value)) m_Hz = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Amplitude = new AudioGraphNodePort();
		[ContainerField(16), ContainerFieldNameHash(698564572)]
		public AudioGraphNodePort Amplitude { get { return m_Amplitude; } set { if (OnPropertyChanging("LfoNodeData." + nameof(Amplitude), this, m_Amplitude, value)) m_Amplitude = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Out = new AudioGraphNodePort();
		[ContainerField(24), ContainerFieldNameHash(193453899)]
		public AudioGraphNodePort Out { get { return m_Out; } set { if (OnPropertyChanging("LfoNodeData." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x18 (24)
		
		protected float m_Min = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(193446607)]
		public float Min { get { return m_Min; } set { if (OnPropertyChanging("LfoNodeData." + nameof(Min), this, m_Min, value)) m_Min = value; } } // 0x20 (32)
		
		protected float m_Max = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(193446865)]
		public float Max { get { return m_Max; } set { if (OnPropertyChanging("LfoNodeData." + nameof(Max), this, m_Max, value)) m_Max = value; } } // 0x24 (36)
		
		protected bool m_StartAtRandomValue = new bool();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(2693653696)]
		public bool StartAtRandomValue { get { return m_StartAtRandomValue; } set { if (OnPropertyChanging("LfoNodeData." + nameof(StartAtRandomValue), this, m_StartAtRandomValue, value)) m_StartAtRandomValue = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862391:
					Hz = (AudioGraphNodePort) p_Value;
					break;

				case 698564572:
					Amplitude = (AudioGraphNodePort) p_Value;
					break;

				case 193453899:
					Out = (AudioGraphNodePort) p_Value;
					break;

				case 193446607:
					Min = (float) p_Value;
					break;

				case 193446865:
					Max = (float) p_Value;
					break;

				case 2693653696:
					StartAtRandomValue = (bool) p_Value;
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
				case 5862391:
					return Hz;

				case 698564572:
					return Amplitude;

				case 193453899:
					return Out;

				case 193446607:
					return Min;

				case 193446865:
					return Max;

				case 2693653696:
					return StartAtRandomValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862391:
					return typeof(LfoNodeData).GetProperty(nameof(Hz));

				case 698564572:
					return typeof(LfoNodeData).GetProperty(nameof(Amplitude));

				case 193453899:
					return typeof(LfoNodeData).GetProperty(nameof(Out));

				case 193446607:
					return typeof(LfoNodeData).GetProperty(nameof(Min));

				case 193446865:
					return typeof(LfoNodeData).GetProperty(nameof(Max));

				case 2693653696:
					return typeof(LfoNodeData).GetProperty(nameof(StartAtRandomValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
