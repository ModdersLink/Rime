///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class DestructionCommandEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public uint InstanceCountDestroyedPerFrame { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public uint InstanceCountDestroyedPerType { get; set; } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 961630582:
					InstanceCountDestroyedPerFrame = (uint) p_Value;
					break;

				case 1461542483:
					InstanceCountDestroyedPerType = (uint) p_Value;
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
				case 961630582:
					return InstanceCountDestroyedPerFrame;

				case 1461542483:
					return InstanceCountDestroyedPerType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 961630582:
					return typeof(DestructionCommandEntityData).GetProperty(nameof(InstanceCountDestroyedPerFrame));

				case 1461542483:
					return typeof(DestructionCommandEntityData).GetProperty(nameof(InstanceCountDestroyedPerType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
