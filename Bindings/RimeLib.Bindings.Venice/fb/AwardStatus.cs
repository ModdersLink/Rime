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
	public class AwardStatus : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string Code { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint CurrentValue { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49421)]
		public uint OriginalValue { get; set; } // 0x8 (8)
		
		[ContainerField(12), MemberInfoFlag(65), ContainerArray]
		public List<CounterStatus> Counters { get; set; } = new List<CounterStatus>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool IsCounting { get; set; } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088844616:
					Code = (string) p_Value;
					break;

				case 1144276871:
					CurrentValue = (uint) p_Value;
					break;

				case 3950775415:
					OriginalValue = (uint) p_Value;
					break;

				case 1361324322:
					Counters = (List<CounterStatus>) p_Value;
					break;

				case 2475040956:
					IsCounting = (bool) p_Value;
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
				case 2088844616:
					return Code;

				case 1144276871:
					return CurrentValue;

				case 3950775415:
					return OriginalValue;

				case 1361324322:
					return Counters;

				case 2475040956:
					return IsCounting;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088844616:
					return typeof(AwardStatus).GetProperty(nameof(Code));

				case 1144276871:
					return typeof(AwardStatus).GetProperty(nameof(CurrentValue));

				case 3950775415:
					return typeof(AwardStatus).GetProperty(nameof(OriginalValue));

				case 1361324322:
					return typeof(AwardStatus).GetProperty(nameof(Counters));

				case 2475040956:
					return typeof(AwardStatus).GetProperty(nameof(IsCounting));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
