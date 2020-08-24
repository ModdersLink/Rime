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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class CameraSineCurveData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Frequency { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float Amplitude { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
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
