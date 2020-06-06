///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class WidgetNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UIWidgetAsset> WidgetAsset { get; set; } = new CtrRef<UIWidgetAsset>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int FocusIndex { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public int ZDepthLevel { get; set; } // 0x1C (28)
		
		[ContainerField(32)]
		public WidgetVerticalAlignment VerticalAlign { get; set; } = new WidgetVerticalAlignment(); // 0x20 (32)
		
		[ContainerField(36)]
		public WidgetHorisontalAlignment HorisontalAlign { get; set; } = new WidgetHorisontalAlignment(); // 0x24 (36)
		
		[ContainerField(40)]
		public CtrRef<UIDataBinding> DataBinding { get; set; } = new CtrRef<UIDataBinding>(); // 0x28 (40)
		
		[ContainerField(44)]
		public List<UIWidgetProperty> WidgetProperties { get; set; } = new List<UIWidgetProperty>(); // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable]
		public string InstanceName { get; set; } // 0x30 (48)
		
		[ContainerField(52)]
		public RefArray<UINodePort> Inputs { get; set; } = new RefArray<UINodePort>(); // 0x34 (52)
		
		[ContainerField(56)]
		public RefArray<UINodePort> Outputs { get; set; } = new RefArray<UINodePort>(); // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool AlwaysInFocus { get; set; } // 0x3C (60)
		
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
