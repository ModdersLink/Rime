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
	public class DebugValueInput : 
		AudioGraphNodePortGroup
	{
		protected AudioGraphNodePort m_V = new AudioGraphNodePort();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(177651)]
		public AudioGraphNodePort V { get { return m_V; } set { if (OnPropertyChanging("DebugValueInput." + nameof(V), this, m_V, value)) m_V = value; } } // 0x8 (8)
		
		protected string m_Name = string.Empty;
		[ContainerField(16), LayoutImmutable, MemberInfoFlag(16509), ContainerFieldNameHash(2088949890)]
		public string Name { get { return m_Name; } set { if (OnPropertyChanging("DebugValueInput." + nameof(Name), this, m_Name, value)) m_Name = value; } } // 0x10 (16)
		
		protected DebugRenderType m_RenderType = new DebugRenderType();
		[ContainerField(20), MemberInfoFlag(137), ContainerFieldNameHash(604852279)]
		public DebugRenderType RenderType { get { return m_RenderType; } set { if (OnPropertyChanging("DebugValueInput." + nameof(RenderType), this, m_RenderType, value)) m_RenderType = value; } } // 0x14 (20)
		
		protected float m_Min = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(193446607)]
		public float Min { get { return m_Min; } set { if (OnPropertyChanging("DebugValueInput." + nameof(Min), this, m_Min, value)) m_Min = value; } } // 0x18 (24)
		
		protected float m_Max = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(193446865)]
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
