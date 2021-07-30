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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class CameraSineCurveData : FrostbiteContainer
	{
		[ContainerField(Name: "Frequency", Offset: 0, NameHash: 4112821953, Flags: 49469), LayoutImmutable, Blittable]
		public float Frequency { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Amplitude", Offset: 4, NameHash: 698564572, Flags: 49469), LayoutImmutable, Blittable]
		public float Amplitude { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "PhaseShift", Offset: 8, NameHash: 3261548234, Flags: 49469), LayoutImmutable, Blittable]
		public float PhaseShift { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4112821953:
					Frequency = (float) p_Value;
					break;

				case 698564572:
					Amplitude = (float) p_Value;
					break;

				case 3261548234:
					PhaseShift = (float) p_Value;
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
				case 4112821953:
					return Frequency;

				case 698564572:
					return Amplitude;

				case 3261548234:
					return PhaseShift;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4112821953:
					return typeof(CameraSineCurveData).GetProperty(nameof(Frequency));

				case 698564572:
					return typeof(CameraSineCurveData).GetProperty(nameof(Amplitude));

				case 3261548234:
					return typeof(CameraSineCurveData).GetProperty(nameof(PhaseShift));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
