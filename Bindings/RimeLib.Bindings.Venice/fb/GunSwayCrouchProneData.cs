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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 152)]
	public class GunSwayCrouchProneData : FrostbiteContainer
	{
		[ContainerField(Name: "NoZoom", Offset: 0, NameHash: 2828535091, Flags: 41)]
		public GunSwayBaseMoveData NoZoom { get; set; } = new GunSwayBaseMoveData(); // 0x0 (0)
		
		[ContainerField(Name: "Zoom", Offset: 76, NameHash: 2089658322, Flags: 41)]
		public GunSwayBaseMoveData Zoom { get; set; } = new GunSwayBaseMoveData(); // 0x4C (76)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2828535091:
					NoZoom = (GunSwayBaseMoveData) p_Value;
					break;

				case 2089658322:
					Zoom = (GunSwayBaseMoveData) p_Value;
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
					return typeof(GunSwayCrouchProneData).GetProperty(nameof(NoZoom));

				case 2089658322:
					return typeof(GunSwayCrouchProneData).GetProperty(nameof(Zoom));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
