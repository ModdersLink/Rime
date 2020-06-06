///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UIInteractionCompData : 
		UI3dIconCompData
	{
		[ContainerField(160), LayoutImmutable, Blittable]
		public float RepairSnapDistance { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public bool RepairSnapCircle { get; set; } // 0xA4 (164)
		
		[ContainerField(165), LayoutImmutable, Blittable]
		public bool PickupShrinkSnap { get; set; } // 0xA5 (165)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 619854519:
					RepairSnapDistance = (float) p_Value;
					break;

				case 4082184934:
					RepairSnapCircle = (bool) p_Value;
					break;

				case 1291739672:
					PickupShrinkSnap = (bool) p_Value;
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
				case 619854519:
					return RepairSnapDistance;

				case 4082184934:
					return RepairSnapCircle;

				case 1291739672:
					return PickupShrinkSnap;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 619854519:
					return typeof(UIInteractionCompData).GetProperty(nameof(RepairSnapDistance));

				case 4082184934:
					return typeof(UIInteractionCompData).GetProperty(nameof(RepairSnapCircle));

				case 1291739672:
					return typeof(UIInteractionCompData).GetProperty(nameof(PickupShrinkSnap));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
