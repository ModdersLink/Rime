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
	public class Animated1pOnlyWeaponBinding : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public AntRef UndeployFinished { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(41)]
		public AntRef CameraFreeWeight { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(41)]
		public AntRef Deploy1P { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12), MemberInfoFlag(41)]
		public AntRef HideWeapon1p { get; set; } = new AntRef(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4033821511:
					UndeployFinished = (AntRef) p_Value;
					break;

				case 3255848968:
					CameraFreeWeight = (AntRef) p_Value;
					break;

				case 3961824271:
					Deploy1P = (AntRef) p_Value;
					break;

				case 3927973382:
					HideWeapon1p = (AntRef) p_Value;
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
				case 4033821511:
					return UndeployFinished;

				case 3255848968:
					return CameraFreeWeight;

				case 3961824271:
					return Deploy1P;

				case 3927973382:
					return HideWeapon1p;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4033821511:
					return typeof(Animated1pOnlyWeaponBinding).GetProperty(nameof(UndeployFinished));

				case 3255848968:
					return typeof(Animated1pOnlyWeaponBinding).GetProperty(nameof(CameraFreeWeight));

				case 3961824271:
					return typeof(Animated1pOnlyWeaponBinding).GetProperty(nameof(Deploy1P));

				case 3927973382:
					return typeof(Animated1pOnlyWeaponBinding).GetProperty(nameof(HideWeapon1p));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
