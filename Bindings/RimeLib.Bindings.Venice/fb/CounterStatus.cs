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
	public class CounterStatus : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float CurrentValue { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float OriginalValue { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1144276871:
					CurrentValue = (float) p_Value;
					break;

				case 3950775415:
					OriginalValue = (float) p_Value;
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
				case 1144276871:
					return CurrentValue;

				case 3950775415:
					return OriginalValue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1144276871:
					return typeof(CounterStatus).GetProperty(nameof(CurrentValue));

				case 3950775415:
					return typeof(CounterStatus).GetProperty(nameof(OriginalValue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
