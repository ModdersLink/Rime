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
	public class UIGraphEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public List<EventSpec> Events { get; set; } = new List<EventSpec>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<UIGraphAsset> GraphAsset { get; set; } = new CtrRef<UIGraphAsset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public UIGraphPriority GraphPriority { get; set; } = new UIGraphPriority(); // 0x14 (20)
		
		[ContainerField(24)]
		public UIState State { get; set; } = new UIState(); // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool PopPreviousGraph { get; set; } // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2352146554:
					Events = (List<EventSpec>) p_Value;
					break;

				case 3545549337:
					GraphAsset = (CtrRef<UIGraphAsset>) p_Value;
					break;

				case 2838537403:
					GraphPriority = (UIGraphPriority) Enum.ToObject(typeof(UIGraphPriority), p_Value);
					break;

				case 230748402:
					State = (UIState) Enum.ToObject(typeof(UIState), p_Value);
					break;

				case 3277878647:
					PopPreviousGraph = (bool) p_Value;
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
				case 2352146554:
					return Events;

				case 3545549337:
					return GraphAsset;

				case 2838537403:
					return GraphPriority;

				case 230748402:
					return State;

				case 3277878647:
					return PopPreviousGraph;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2352146554:
					return typeof(UIGraphEntityData).GetProperty(nameof(Events));

				case 3545549337:
					return typeof(UIGraphEntityData).GetProperty(nameof(GraphAsset));

				case 2838537403:
					return typeof(UIGraphEntityData).GetProperty(nameof(GraphPriority));

				case 230748402:
					return typeof(UIGraphEntityData).GetProperty(nameof(State));

				case 3277878647:
					return typeof(UIGraphEntityData).GetProperty(nameof(PopPreviousGraph));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
