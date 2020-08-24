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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class NumberGeneratorNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_Trigger = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(2606354109)]
		public AudioGraphNodePort Trigger { get { return m_Trigger; } set { if (OnPropertyChanging("NumberGeneratorNodeData." + nameof(Trigger), this, m_Trigger, value)) m_Trigger = value; } } // 0x8 (8)
		
		protected float m_Min = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(193446607)]
		public float Min { get { return m_Min; } set { if (OnPropertyChanging("NumberGeneratorNodeData." + nameof(Min), this, m_Min, value)) m_Min = value; } } // 0x10 (16)
		
		protected float m_Max = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(193446865)]
		public float Max { get { return m_Max; } set { if (OnPropertyChanging("NumberGeneratorNodeData." + nameof(Max), this, m_Max, value)) m_Max = value; } } // 0x14 (20)
		
		protected NumberGeneratorMode m_Mode = new NumberGeneratorMode();
		[ContainerField(24), MemberInfoFlag(137), ContainerFieldNameHash(2088772358)]
		public NumberGeneratorMode Mode { get { return m_Mode; } set { if (OnPropertyChanging("NumberGeneratorNodeData." + nameof(Mode), this, m_Mode, value)) m_Mode = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Y = new AudioGraphNodePort();
		[ContainerField(28), MemberInfoFlag(41), ContainerFieldNameHash(177660)]
		public AudioGraphNodePort Y { get { return m_Y; } set { if (OnPropertyChanging("NumberGeneratorNodeData." + nameof(Y), this, m_Y, value)) m_Y = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2606354109:
					Trigger = (AudioGraphNodePort) p_Value;
					break;

				case 193446607:
					Min = (float) p_Value;
					break;

				case 193446865:
					Max = (float) p_Value;
					break;

				case 2088772358:
					Mode = (NumberGeneratorMode) Enum.ToObject(typeof(NumberGeneratorMode), p_Value);
					break;

				case 177660:
					Y = (AudioGraphNodePort) p_Value;
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
				case 2606354109:
					return Trigger;

				case 193446607:
					return Min;

				case 193446865:
					return Max;

				case 2088772358:
					return Mode;

				case 177660:
					return Y;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2606354109:
					return typeof(NumberGeneratorNodeData).GetProperty(nameof(Trigger));

				case 193446607:
					return typeof(NumberGeneratorNodeData).GetProperty(nameof(Min));

				case 193446865:
					return typeof(NumberGeneratorNodeData).GetProperty(nameof(Max));

				case 2088772358:
					return typeof(NumberGeneratorNodeData).GetProperty(nameof(Mode));

				case 177660:
					return typeof(NumberGeneratorNodeData).GetProperty(nameof(Y));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
