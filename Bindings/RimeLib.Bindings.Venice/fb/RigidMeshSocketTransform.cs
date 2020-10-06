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
	[ContainerType(16), MemberInfoFlag(41), ContainerSize(80), ContainerStruct]
	public class RigidMeshSocketTransform : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289)]
		public LinearTransform Transform { get; set; } = new LinearTransform(); // 0x0 (0)
		
		[ContainerField(64), MemberInfoFlag(53), ContainerCtrRef]
		public CtrRef<WeaponRegularSocketObjectData> SocketObject { get; set; } = new CtrRef<WeaponRegularSocketObjectData>(); // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2270319721:
					Transform = (LinearTransform) p_Value;
					break;

				case 1217427573:
					SocketObject = (CtrRef<WeaponRegularSocketObjectData>) p_Value;
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
				case 2270319721:
					return Transform;

				case 1217427573:
					return SocketObject;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2270319721:
					return typeof(RigidMeshSocketTransform).GetProperty(nameof(Transform));

				case 1217427573:
					return typeof(RigidMeshSocketTransform).GetProperty(nameof(SocketObject));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
