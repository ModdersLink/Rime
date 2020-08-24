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
	public class WeaponLagBinding : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public AntRef EntityPitch { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(41)]
		public AntRef EntityYaw { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(41)]
		public AntRef PitchResult { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12), MemberInfoFlag(41)]
		public AntRef YawResult { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16), MemberInfoFlag(41)]
		public AntRef RollResult { get; set; } = new AntRef(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 177871704:
					EntityPitch = (AntRef) p_Value;
					break;

				case 572027185:
					EntityYaw = (AntRef) p_Value;
					break;

				case 1982335530:
					PitchResult = (AntRef) p_Value;
					break;

				case 2023530371:
					YawResult = (AntRef) p_Value;
					break;

				case 1227528625:
					RollResult = (AntRef) p_Value;
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
				case 177871704:
					return EntityPitch;

				case 572027185:
					return EntityYaw;

				case 1982335530:
					return PitchResult;

				case 2023530371:
					return YawResult;

				case 1227528625:
					return RollResult;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 177871704:
					return typeof(WeaponLagBinding).GetProperty(nameof(EntityPitch));

				case 572027185:
					return typeof(WeaponLagBinding).GetProperty(nameof(EntityYaw));

				case 1982335530:
					return typeof(WeaponLagBinding).GetProperty(nameof(PitchResult));

				case 2023530371:
					return typeof(WeaponLagBinding).GetProperty(nameof(YawResult));

				case 1227528625:
					return typeof(WeaponLagBinding).GetProperty(nameof(RollResult));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
