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
	public class CharacterAnimationEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform EntitySpaceTransform { get; set; } = new LinearTransform(); // 0x10 (16)
		
		[ContainerField(80)]
		public AntRef Controller { get; set; } = new AntRef(); // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float TrackLength { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float WarpAnimationBlendTime { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public bool RestoreControllerOnFinish { get; set; } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3912132918:
					EntitySpaceTransform = (LinearTransform) p_Value;
					break;

				case 1870777401:
					Controller = (AntRef) p_Value;
					break;

				case 736448950:
					TrackLength = (float) p_Value;
					break;

				case 2162678253:
					ExternalTime = (float) p_Value;
					break;

				case 1283988115:
					WarpAnimationBlendTime = (float) p_Value;
					break;

				case 2934168163:
					RestoreControllerOnFinish = (bool) p_Value;
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
				case 3912132918:
					return EntitySpaceTransform;

				case 1870777401:
					return Controller;

				case 736448950:
					return TrackLength;

				case 2162678253:
					return ExternalTime;

				case 1283988115:
					return WarpAnimationBlendTime;

				case 2934168163:
					return RestoreControllerOnFinish;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3912132918:
					return typeof(CharacterAnimationEntityData).GetProperty(nameof(EntitySpaceTransform));

				case 1870777401:
					return typeof(CharacterAnimationEntityData).GetProperty(nameof(Controller));

				case 736448950:
					return typeof(CharacterAnimationEntityData).GetProperty(nameof(TrackLength));

				case 2162678253:
					return typeof(CharacterAnimationEntityData).GetProperty(nameof(ExternalTime));

				case 1283988115:
					return typeof(CharacterAnimationEntityData).GetProperty(nameof(WarpAnimationBlendTime));

				case 2934168163:
					return typeof(CharacterAnimationEntityData).GetProperty(nameof(RestoreControllerOnFinish));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
