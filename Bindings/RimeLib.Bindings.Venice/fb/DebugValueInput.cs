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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class DebugValueInput : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_V = new AudioGraphNodePort();
		[ContainerField(Name: "V", Offset: 8, NameHash: 177651, Flags: 41)]
		public AudioGraphNodePort V { get { return m_V; } set { if (OnPropertyChanging("DebugValueInput." + nameof(V), this, m_V, value)) m_V = value; } } // 0x8 (8)
		
		protected string m_Name = string.Empty;
		[ContainerField(Name: "Name", Offset: 16, NameHash: 2088949890, Flags: 16509), LayoutImmutable]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("DebugValueInput." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x10 (16)
		
		protected DebugRenderType m_RenderType = new DebugRenderType();
		[ContainerField(Name: "RenderType", Offset: 20, NameHash: 604852279, Flags: 137)]
		public DebugRenderType RenderType { get { return m_RenderType; } set { if (OnPropertyChanging("DebugValueInput." + nameof(RenderType), this, m_RenderType, value)) m_RenderType = value; } } // 0x14 (20)
		
		protected float m_Min = new float();
		[ContainerField(Name: "Min", Offset: 24, NameHash: 193446607, Flags: 49469), LayoutImmutable, Blittable]
		public float Min { get { return m_Min; } set { if (OnPropertyChanging("DebugValueInput." + nameof(Min), this, m_Min, value)) m_Min = value; } } // 0x18 (24)
		
		protected float m_Max = new float();
		[ContainerField(Name: "Max", Offset: 28, NameHash: 193446865, Flags: 49469), LayoutImmutable, Blittable]
		public float Max { get { return m_Max; } set { if (OnPropertyChanging("DebugValueInput." + nameof(Max), this, m_Max, value)) m_Max = value; } } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 177651:
					V = (AudioGraphNodePort) p_Value;
					break;

				case 2088949890:
					Name = (string) p_Value;
					break;

				case 604852279:
					RenderType = (DebugRenderType) Enum.ToObject(typeof(DebugRenderType), p_Value);
					break;

				case 193446607:
					Min = (float) p_Value;
					break;

				case 193446865:
					Max = (float) p_Value;
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
				case 177651:
					return V;

				case 2088949890:
					return Name;

				case 604852279:
					return RenderType;

				case 193446607:
					return Min;

				case 193446865:
					return Max;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177651:
					return typeof(DebugValueInput).GetProperty(nameof(V));

				case 2088949890:
					return typeof(DebugValueInput).GetProperty(nameof(Name));

				case 604852279:
					return typeof(DebugValueInput).GetProperty(nameof(RenderType));

				case 193446607:
					return typeof(DebugValueInput).GetProperty(nameof(Min));

				case 193446865:
					return typeof(DebugValueInput).GetProperty(nameof(Max));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
