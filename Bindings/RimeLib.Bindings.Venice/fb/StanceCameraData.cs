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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(8), ContainerStruct]
	public class StanceCameraData : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(65), ContainerArray]
		public List<int> ValidStances { get; set; } = new List<int>(); // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(65), ContainerArray]
		public List<int> DefaultCameraForStances { get; set; } = new List<int>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4192498222:
					ValidStances = (List<int>) p_Value;
					break;

				case 1972868017:
					DefaultCameraForStances = (List<int>) p_Value;
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
				case 4192498222:
					return ValidStances;

				case 1972868017:
					return DefaultCameraForStances;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4192498222:
					return typeof(StanceCameraData).GetProperty(nameof(ValidStances));

				case 1972868017:
					return typeof(StanceCameraData).GetProperty(nameof(DefaultCameraForStances));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
