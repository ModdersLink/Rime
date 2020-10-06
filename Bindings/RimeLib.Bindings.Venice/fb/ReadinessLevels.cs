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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(36), ContainerStruct]
	public class ReadinessLevels : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public ReadinessLevelCharacteristics Patrol { get; set; } = new ReadinessLevelCharacteristics(); // 0x0 (0)
		
		[ContainerField(12), MemberInfoFlag(41)]
		public ReadinessLevelCharacteristics Ready { get; set; } = new ReadinessLevelCharacteristics(); // 0xC (12)
		
		[ContainerField(24), MemberInfoFlag(41)]
		public ReadinessLevelCharacteristics Combat { get; set; } = new ReadinessLevelCharacteristics(); // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3371506961:
					Patrol = (ReadinessLevelCharacteristics) p_Value;
					break;

				case 229961486:
					Ready = (ReadinessLevelCharacteristics) p_Value;
					break;

				case 2713842259:
					Combat = (ReadinessLevelCharacteristics) p_Value;
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
				case 3371506961:
					return Patrol;

				case 229961486:
					return Ready;

				case 2713842259:
					return Combat;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3371506961:
					return typeof(ReadinessLevels).GetProperty(nameof(Patrol));

				case 229961486:
					return typeof(ReadinessLevels).GetProperty(nameof(Ready));

				case 2713842259:
					return typeof(ReadinessLevels).GetProperty(nameof(Combat));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
