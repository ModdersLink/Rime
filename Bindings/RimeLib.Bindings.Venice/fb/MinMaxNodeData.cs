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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class MinMaxNodeData : 
		AudioGraphNodeData
	{
		protected AudioGraphNodePort m_X = new AudioGraphNodePort();
		[ContainerField(Name: "X", Offset: 8, NameHash: 177661, Flags: 41)]
		public AudioGraphNodePort X { get { return m_X; } set { if (OnPropertyChanging("MinMaxNodeData." + nameof(X), this, m_X, value)) m_X = value; } } // 0x8 (8)
		
		protected AudioGraphNodePort m_Y = new AudioGraphNodePort();
		[ContainerField(Name: "Y", Offset: 16, NameHash: 177660, Flags: 41)]
		public AudioGraphNodePort Y { get { return m_Y; } set { if (OnPropertyChanging("MinMaxNodeData." + nameof(Y), this, m_Y, value)) m_Y = value; } } // 0x10 (16)
		
		protected AudioGraphNodePort m_Max = new AudioGraphNodePort();
		[ContainerField(Name: "Max", Offset: 24, NameHash: 193446865, Flags: 41)]
		public AudioGraphNodePort Max { get { return m_Max; } set { if (OnPropertyChanging("MinMaxNodeData." + nameof(Max), this, m_Max, value)) m_Max = value; } } // 0x18 (24)
		
		protected AudioGraphNodePort m_Min = new AudioGraphNodePort();
		[ContainerField(Name: "Min", Offset: 32, NameHash: 193446607, Flags: 41)]
		public AudioGraphNodePort Min { get { return m_Min; } set { if (OnPropertyChanging("MinMaxNodeData." + nameof(Min), this, m_Min, value)) m_Min = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 177661:
					X = (AudioGraphNodePort) p_Value;
					break;

				case 177660:
					Y = (AudioGraphNodePort) p_Value;
					break;

				case 193446865:
					Max = (AudioGraphNodePort) p_Value;
					break;

				case 193446607:
					Min = (AudioGraphNodePort) p_Value;
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
				case 177661:
					return X;

				case 177660:
					return Y;

				case 193446865:
					return Max;

				case 193446607:
					return Min;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177661:
					return typeof(MinMaxNodeData).GetProperty(nameof(X));

				case 177660:
					return typeof(MinMaxNodeData).GetProperty(nameof(Y));

				case 193446865:
					return typeof(MinMaxNodeData).GetProperty(nameof(Max));

				case 193446607:
					return typeof(MinMaxNodeData).GetProperty(nameof(Min));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
