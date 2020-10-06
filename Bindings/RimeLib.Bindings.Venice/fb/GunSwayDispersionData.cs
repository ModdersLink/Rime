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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(16), ContainerStruct]
	public class GunSwayDispersionData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MinAngle { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float MaxAngle { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float IncreasePerShot { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469)]
		public float DecreasePerSecond { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3356124462:
					MinAngle = (float) p_Value;
					break;

				case 417488496:
					MaxAngle = (float) p_Value;
					break;

				case 95639814:
					IncreasePerShot = (float) p_Value;
					break;

				case 3208554608:
					DecreasePerSecond = (float) p_Value;
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
				case 3356124462:
					return MinAngle;

				case 417488496:
					return MaxAngle;

				case 95639814:
					return IncreasePerShot;

				case 3208554608:
					return DecreasePerSecond;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3356124462:
					return typeof(GunSwayDispersionData).GetProperty(nameof(MinAngle));

				case 417488496:
					return typeof(GunSwayDispersionData).GetProperty(nameof(MaxAngle));

				case 95639814:
					return typeof(GunSwayDispersionData).GetProperty(nameof(IncreasePerShot));

				case 3208554608:
					return typeof(GunSwayDispersionData).GetProperty(nameof(DecreasePerSecond));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
