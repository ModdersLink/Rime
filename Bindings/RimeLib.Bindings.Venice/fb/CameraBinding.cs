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
	public class CameraBinding : FrostbiteContainer
	{
		[ContainerField(Name: "Render1pInBackground", Offset: 0, NameHash: 4091026343, Flags: 41)]
		public AntRef Render1pInBackground { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "ForceRender1pInForeground", Offset: 4, NameHash: 708233967, Flags: 41)]
		public AntRef ForceRender1pInForeground { get; set; } = new AntRef(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4091026343:
					Render1pInBackground = (AntRef) p_Value;
					break;

				case 708233967:
					ForceRender1pInForeground = (AntRef) p_Value;
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
				case 4091026343:
					return Render1pInBackground;

				case 708233967:
					return ForceRender1pInForeground;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4091026343:
					return typeof(CameraBinding).GetProperty(nameof(Render1pInBackground));

				case 708233967:
					return typeof(CameraBinding).GetProperty(nameof(ForceRender1pInForeground));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
