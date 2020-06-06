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
	public class SpawnDirectionData : 
		ProcessorData
	{
		[ContainerField(48), LayoutImmutable, Blittable]
		public float DirectionFromEmitterOrigin { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public bool InheritSpeedAndDirectionFromEmitter { get; set; } // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 657561364:
					DirectionFromEmitterOrigin = (float) p_Value;
					break;

				case 1871208809:
					InheritSpeedAndDirectionFromEmitter = (bool) p_Value;
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
				case 657561364:
					return DirectionFromEmitterOrigin;

				case 1871208809:
					return InheritSpeedAndDirectionFromEmitter;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 657561364:
					return typeof(SpawnDirectionData).GetProperty(nameof(DirectionFromEmitterOrigin));

				case 1871208809:
					return typeof(SpawnDirectionData).GetProperty(nameof(InheritSpeedAndDirectionFromEmitter));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
