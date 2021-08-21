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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 4)]
	public class SimpleAnimationControlBinding : FrostbiteContainer
	{
		[ContainerField(Name: "LocoTarget", Offset: 0, NameHash: 1880034011, Flags: 41)]
		public AntRef LocoTarget { get; set; } = new AntRef(); // 0x0 (0)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1880034011:
					LocoTarget = (AntRef) p_Value;
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
				case 1880034011:
					return LocoTarget;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1880034011:
					return typeof(SimpleAnimationControlBinding).GetProperty(nameof(LocoTarget));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
