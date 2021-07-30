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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 48)]
	public class StateNode : 
		UINodeData
	{
		protected CtrRef<UIScreenAsset> m_Screen = new CtrRef<UIScreenAsset>();
		[ContainerField(Name: "Screen", Offset: 20, NameHash: 3334722793, Flags: 53)]
		public CtrRef<UIScreenAsset> Screen { get { return m_Screen; } set { if (OnPropertyChanging("StateNode." + nameof(Screen), this, m_Screen, value)) m_Screen = value; } } // 0x14 (20)
		
		protected CtrRef<UINodePort> m_In = new CtrRef<UINodePort>();
		[ContainerField(Name: "In", Offset: 24, NameHash: 5862146, Flags: 53)]
		public CtrRef<UINodePort> In { get { return m_In; } set { if (OnPropertyChanging("StateNode." + nameof(In), this, m_In, value)) m_In = value; } } // 0x18 (24)
		
		protected CtrRef<UINodePort> m_Show = new CtrRef<UINodePort>();
		[ContainerField(Name: "Show", Offset: 28, NameHash: 2089430886, Flags: 53)]
		public CtrRef<UINodePort> Show { get { return m_Show; } set { if (OnPropertyChanging("StateNode." + nameof(Show), this, m_Show, value)) m_Show = value; } } // 0x1C (28)
		
		protected CtrRef<UINodePort> m_Hide = new CtrRef<UINodePort>();
		[ContainerField(Name: "Hide", Offset: 32, NameHash: 2089152613, Flags: 53)]
		public CtrRef<UINodePort> Hide { get { return m_Hide; } set { if (OnPropertyChanging("StateNode." + nameof(Hide), this, m_Hide, value)) m_Hide = value; } } // 0x20 (32)
		
		protected RefArray<UINodePort> m_Inputs = new RefArray<UINodePort>();
		[ContainerField(Name: "Inputs", Offset: 36, NameHash: 2784267136, Flags: 65)]
		public RefArray<UINodePort> Inputs { get { return m_Inputs; } set { if (OnPropertyChanging("StateNode." + nameof(Inputs), this, m_Inputs, value)) m_Inputs = value; } } // 0x24 (36)
		
		protected RefArray<UINodePort> m_Outputs = new RefArray<UINodePort>();
		[ContainerField(Name: "Outputs", Offset: 40, NameHash: 1070022089, Flags: 65)]
		public RefArray<UINodePort> Outputs { get { return m_Outputs; } set { if (OnPropertyChanging("StateNode." + nameof(Outputs), this, m_Outputs, value)) m_Outputs = value; } } // 0x28 (40)
		
		protected bool m_RenderToTexture = new bool();
		[ContainerField(Name: "RenderToTexture", Offset: 44, NameHash: 627956363, Flags: 49325), LayoutImmutable, Blittable]
		public bool RenderToTexture { get { return m_RenderToTexture; } set { if (OnPropertyChanging("StateNode." + nameof(RenderToTexture), this, m_RenderToTexture, value)) m_RenderToTexture = value; } } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3334722793:
					Screen = (CtrRef<UIScreenAsset>) p_Value;
					break;

				case 5862146:
					In = (CtrRef<UINodePort>) p_Value;
					break;

				case 2089430886:
					Show = (CtrRef<UINodePort>) p_Value;
					break;

				case 2089152613:
					Hide = (CtrRef<UINodePort>) p_Value;
					break;

				case 2784267136:
					Inputs = (RefArray<UINodePort>) p_Value;
					break;

				case 1070022089:
					Outputs = (RefArray<UINodePort>) p_Value;
					break;

				case 627956363:
					RenderToTexture = (bool) p_Value;
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
				case 3334722793:
					return Screen;

				case 5862146:
					return In;

				case 2089430886:
					return Show;

				case 2089152613:
					return Hide;

				case 2784267136:
					return Inputs;

				case 1070022089:
					return Outputs;

				case 627956363:
					return RenderToTexture;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3334722793:
					return typeof(StateNode).GetProperty(nameof(Screen));

				case 5862146:
					return typeof(StateNode).GetProperty(nameof(In));

				case 2089430886:
					return typeof(StateNode).GetProperty(nameof(Show));

				case 2089152613:
					return typeof(StateNode).GetProperty(nameof(Hide));

				case 2784267136:
					return typeof(StateNode).GetProperty(nameof(Inputs));

				case 1070022089:
					return typeof(StateNode).GetProperty(nameof(Outputs));

				case 627956363:
					return typeof(StateNode).GetProperty(nameof(RenderToTexture));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
