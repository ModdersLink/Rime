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
	public class UIMinimapIconUv : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec2 MinUv { get; set; } = new Vec2(); // 0x0 (0)
		
		[ContainerField(8), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public Vec2 MaxUv { get; set; } = new Vec2(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 209960012:
					MinUv = (Vec2) p_Value;
					break;

				case 210235986:
					MaxUv = (Vec2) p_Value;
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
				case 209960012:
					return MinUv;

				case 210235986:
					return MaxUv;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 209960012:
					return typeof(UIMinimapIconUv).GetProperty(nameof(MinUv));

				case 210235986:
					return typeof(UIMinimapIconUv).GetProperty(nameof(MaxUv));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
