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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 128)]
	public class UIMinimapZoomConfig : FrostbiteContainer
	{
		[ContainerField(Name: "State", Offset: 0, NameHash: 230748402, Flags: 137)]
		public UIMinimapZoomState State { get; set; } = new UIMinimapZoomState(); // 0x0 (0)
		
		[ContainerField(Name: "Data", Offset: 16, NameHash: 2088730869, Flags: 41)]
		public MinimapData Data { get; set; } = new MinimapData(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 230748402:
						State = (UIMinimapZoomState) Enum.ToObject(typeof(UIMinimapZoomState), p_Value);
					break;

				case 2088730869:
					Data = (MinimapData) p_Value;
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
				case 230748402:
					return State;

				case 2088730869:
					return Data;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 230748402:
					return typeof(UIMinimapZoomConfig).GetProperty(nameof(State));

				case 2088730869:
					return typeof(UIMinimapZoomConfig).GetProperty(nameof(Data));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
