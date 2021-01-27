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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class LodBinding : FrostbiteContainer
	{
		[ContainerField(Name: "DisableControllerUpdate", Offset: 0, NameHash: 2089791388, Flags: 41)]
		public AntRef DisableControllerUpdate { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "DisablePoseUpdate", Offset: 4, NameHash: 605526569, Flags: 41)]
		public AntRef DisablePoseUpdate { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(Name: "DistanceFromCamera", Offset: 8, NameHash: 621427369, Flags: 41)]
		public AntRef DistanceFromCamera { get; set; } = new AntRef(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089791388:
					DisableControllerUpdate = (AntRef) p_Value;
					break;

				case 605526569:
					DisablePoseUpdate = (AntRef) p_Value;
					break;

				case 621427369:
					DistanceFromCamera = (AntRef) p_Value;
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
				case 2089791388:
					return DisableControllerUpdate;

				case 605526569:
					return DisablePoseUpdate;

				case 621427369:
					return DistanceFromCamera;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089791388:
					return typeof(LodBinding).GetProperty(nameof(DisableControllerUpdate));

				case 605526569:
					return typeof(LodBinding).GetProperty(nameof(DisablePoseUpdate));

				case 621427369:
					return typeof(LodBinding).GetProperty(nameof(DistanceFromCamera));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
