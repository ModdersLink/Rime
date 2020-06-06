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
	public class DestroyLevelCommandEntityData : 
		GameEntityData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public uint InstanceCountDestroyedPerFrame { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public uint DestroyDelay { get; set; } // 0x64 (100)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 961630582:
					InstanceCountDestroyedPerFrame = (uint) p_Value;
					break;

				case 3844272786:
					DestroyDelay = (uint) p_Value;
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

				case 3844272786:
					return DestroyDelay;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 961630582:
					return typeof(DestroyLevelCommandEntityData).GetProperty(nameof(InstanceCountDestroyedPerFrame));

				case 3844272786:
					return typeof(DestroyLevelCommandEntityData).GetProperty(nameof(DestroyDelay));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
