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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 64)]
	public class WidgetNode : 
		UINodeData
	{
		protected CtrRef<UIWidgetAsset> m_WidgetAsset = new CtrRef<UIWidgetAsset>();
		[ContainerField(Name: "WidgetAsset", Offset: 20, NameHash: 2246087193, Flags: 53)]
		public CtrRef<UIWidgetAsset> WidgetAsset { get { return m_WidgetAsset; } set { if (OnPropertyChanging("WidgetNode." + nameof(WidgetAsset), this, m_WidgetAsset, value)) m_WidgetAsset = value; } } // 0x14 (20)
		
		protected int m_FocusIndex = new int();
		[ContainerField(Name: "FocusIndex", Offset: 24, NameHash: 2956357495, Flags: 49405), LayoutImmutable, Blittable]
		public int FocusIndex { get { return m_FocusIndex; } set { if (OnPropertyChanging("WidgetNode." + nameof(FocusIndex), this, m_FocusIndex, value)) m_FocusIndex = value; } } // 0x18 (24)
		
		protected int m_ZDepthLevel = new int();
		[ContainerField(Name: "ZDepthLevel", Offset: 28, NameHash: 2052497316, Flags: 49405), LayoutImmutable, Blittable]
		public int ZDepthLevel { get { return m_ZDepthLevel; } set { if (OnPropertyChanging("WidgetNode." + nameof(ZDepthLevel), this, m_ZDepthLevel, value)) m_ZDepthLevel = value; } } // 0x1C (28)
		
		protected WidgetVerticalAlignment m_VerticalAlign = new WidgetVerticalAlignment();
		[ContainerField(Name: "VerticalAlign", Offset: 32, NameHash: 457166266, Flags: 137)]
		public WidgetVerticalAlignment VerticalAlign { get { return m_VerticalAlign; } set { if (OnPropertyChanging("WidgetNode." + nameof(VerticalAlign), this, m_VerticalAlign, value)) m_VerticalAlign = value; } } // 0x20 (32)
		
		protected WidgetHorisontalAlignment m_HorisontalAlign = new WidgetHorisontalAlignment();
		[ContainerField(Name: "HorisontalAlign", Offset: 36, NameHash: 1564108319, Flags: 137)]
		public WidgetHorisontalAlignment HorisontalAlign { get { return m_HorisontalAlign; } set { if (OnPropertyChanging("WidgetNode." + nameof(HorisontalAlign), this, m_HorisontalAlign, value)) m_HorisontalAlign = value; } } // 0x24 (36)
		
		protected CtrRef<UIDataBinding> m_DataBinding = new CtrRef<UIDataBinding>();
		[ContainerField(Name: "DataBinding", Offset: 40, NameHash: 3592963508, Flags: 53)]
		public CtrRef<UIDataBinding> DataBinding { get { return m_DataBinding; } set { if (OnPropertyChanging("WidgetNode." + nameof(DataBinding), this, m_DataBinding, value)) m_DataBinding = value; } } // 0x28 (40)
		
		protected List<UIWidgetProperty> m_WidgetProperties = new List<UIWidgetProperty>();
		[ContainerField(Name: "WidgetProperties", Offset: 44, NameHash: 1380677224, Flags: 65)]
		public List<UIWidgetProperty> WidgetProperties { get { return m_WidgetProperties; } set { if (OnPropertyChanging("WidgetNode." + nameof(WidgetProperties), this, m_WidgetProperties, value)) m_WidgetProperties = value; } } // 0x2C (44)
		
		protected string m_InstanceName = string.Empty;
		[ContainerField(Name: "InstanceName", Offset: 48, NameHash: 1186954283, Flags: 16509), LayoutImmutable]
		public string InstanceName { get { return m_InstanceName; } set { if (OnPropertyChanging("WidgetNode." + nameof(InstanceName), this, m_InstanceName, value)) m_InstanceName = value; } } // 0x30 (48)
		
		protected RefArray<UINodePort> m_Inputs = new RefArray<UINodePort>();
		[ContainerField(Name: "Inputs", Offset: 52, NameHash: 2784267136, Flags: 65)]
		public RefArray<UINodePort> Inputs { get { return m_Inputs; } set { if (OnPropertyChanging("WidgetNode." + nameof(Inputs), this, m_Inputs, value)) m_Inputs = value; } } // 0x34 (52)
		
		protected RefArray<UINodePort> m_Outputs = new RefArray<UINodePort>();
		[ContainerField(Name: "Outputs", Offset: 56, NameHash: 1070022089, Flags: 65)]
		public RefArray<UINodePort> Outputs { get { return m_Outputs; } set { if (OnPropertyChanging("WidgetNode." + nameof(Outputs), this, m_Outputs, value)) m_Outputs = value; } } // 0x38 (56)
		
		protected bool m_AlwaysInFocus = new bool();
		[ContainerField(Name: "AlwaysInFocus", Offset: 60, NameHash: 253379903, Flags: 49325), LayoutImmutable, Blittable]
		public bool AlwaysInFocus { get { return m_AlwaysInFocus; } set { if (OnPropertyChanging("WidgetNode." + nameof(AlwaysInFocus), this, m_AlwaysInFocus, value)) m_AlwaysInFocus = value; } } // 0x3C (60)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2246087193:
					WidgetAsset = (CtrRef<UIWidgetAsset>) p_Value;
					break;

				case 2956357495:
					FocusIndex = (int) p_Value;
					break;

				case 2052497316:
					ZDepthLevel = (int) p_Value;
					break;

				case 457166266:
					VerticalAlign = (WidgetVerticalAlignment) Enum.ToObject(typeof(WidgetVerticalAlignment), p_Value);
					break;

				case 1564108319:
					HorisontalAlign = (WidgetHorisontalAlignment) Enum.ToObject(typeof(WidgetHorisontalAlignment), p_Value);
					break;

				case 3592963508:
					DataBinding = (CtrRef<UIDataBinding>) p_Value;
					break;

				case 1380677224:
					WidgetProperties = (List<UIWidgetProperty>) p_Value;
					break;

				case 1186954283:
					InstanceName = (string) p_Value;
					break;

				case 2784267136:
					Inputs = (RefArray<UINodePort>) p_Value;
					break;

				case 1070022089:
					Outputs = (RefArray<UINodePort>) p_Value;
					break;

				case 253379903:
					AlwaysInFocus = (bool) p_Value;
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
				case 2246087193:
					return WidgetAsset;

				case 2956357495:
					return FocusIndex;

				case 2052497316:
					return ZDepthLevel;

				case 457166266:
					return VerticalAlign;

				case 1564108319:
					return HorisontalAlign;

				case 3592963508:
					return DataBinding;

				case 1380677224:
					return WidgetProperties;

				case 1186954283:
					return InstanceName;

				case 2784267136:
					return Inputs;

				case 1070022089:
					return Outputs;

				case 253379903:
					return AlwaysInFocus;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2246087193:
					return typeof(WidgetNode).GetProperty(nameof(WidgetAsset));

				case 2956357495:
					return typeof(WidgetNode).GetProperty(nameof(FocusIndex));

				case 2052497316:
					return typeof(WidgetNode).GetProperty(nameof(ZDepthLevel));

				case 457166266:
					return typeof(WidgetNode).GetProperty(nameof(VerticalAlign));

				case 1564108319:
					return typeof(WidgetNode).GetProperty(nameof(HorisontalAlign));

				case 3592963508:
					return typeof(WidgetNode).GetProperty(nameof(DataBinding));

				case 1380677224:
					return typeof(WidgetNode).GetProperty(nameof(WidgetProperties));

				case 1186954283:
					return typeof(WidgetNode).GetProperty(nameof(InstanceName));

				case 2784267136:
					return typeof(WidgetNode).GetProperty(nameof(Inputs));

				case 1070022089:
					return typeof(WidgetNode).GetProperty(nameof(Outputs));

				case 253379903:
					return typeof(WidgetNode).GetProperty(nameof(AlwaysInFocus));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
