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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(280), ContainerStruct]
	public class GunSwayStandData : FrostbiteContainer
	{
		[ContainerField(0), MemberInfoFlag(41)]
		public GunSwayBaseMoveJumpData NoZoom { get; set; } = new GunSwayBaseMoveJumpData(); // 0x0 (0)
		
		[ContainerField(140), MemberInfoFlag(41)]
		public GunSwayBaseMoveJumpData Zoom { get; set; } = new GunSwayBaseMoveJumpData(); // 0x8C (140)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2828535091:
					NoZoom = (GunSwayBaseMoveJumpData) p_Value;
					break;

				case 2089658322:
					Zoom = (GunSwayBaseMoveJumpData) p_Value;
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
				case 2828535091:
					return NoZoom;

				case 2089658322:
					return Zoom;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2828535091:
					return typeof(GunSwayStandData).GetProperty(nameof(NoZoom));

				case 2089658322:
					return typeof(GunSwayStandData).GetProperty(nameof(Zoom));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
