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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class AnimationDrivenBinding : FrostbiteContainer
	{
		[ContainerField(Name: "Velocity", Offset: 0, NameHash: 3860766482, Flags: 41)]
		public AntRef Velocity { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "EnableCollision", Offset: 4, NameHash: 2198364250, Flags: 41)]
		public AntRef EnableCollision { get; set; } = new AntRef(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3860766482:
					Velocity = (AntRef) p_Value;
					break;

				case 2198364250:
					EnableCollision = (AntRef) p_Value;
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
				case 3860766482:
					return Velocity;

				case 2198364250:
					return EnableCollision;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3860766482:
					return typeof(AnimationDrivenBinding).GetProperty(nameof(Velocity));

				case 2198364250:
					return typeof(AnimationDrivenBinding).GetProperty(nameof(EnableCollision));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
