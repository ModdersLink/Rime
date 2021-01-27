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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 32)]
	public class PickupSettingsData : FrostbiteContainer
	{
		[ContainerField(Name: "MeshRenderOffset", Offset: 0, NameHash: 4077357329, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MeshRenderOffset { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "MeshRenderRotation", Offset: 16, NameHash: 2454327656, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 MeshRenderRotation { get; set; } = new Vec3(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4077357329:
					MeshRenderOffset = (Vec3) p_Value;
					break;

				case 2454327656:
					MeshRenderRotation = (Vec3) p_Value;
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
				case 4077357329:
					return MeshRenderOffset;

				case 2454327656:
					return MeshRenderRotation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4077357329:
					return typeof(PickupSettingsData).GetProperty(nameof(MeshRenderOffset));

				case 2454327656:
					return typeof(PickupSettingsData).GetProperty(nameof(MeshRenderRotation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
