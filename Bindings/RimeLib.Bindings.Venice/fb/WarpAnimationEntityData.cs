///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class WarpAnimationEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform ConnectTransform { get; set; } = new LinearTransform(); // 0x10 (16)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; } // 0x50 (80)
		
		[ContainerField(84)]
		public WarpAnimationBinding WarpBinding { get; set; } = new WarpAnimationBinding(); // 0x54 (84)
		
		[ContainerField(104)]
		public GameplayBones BoneToAlign { get; set; } = new GameplayBones(); // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public bool ForceAnimationTransform { get; set; } // 0x6C (108)
		
		[ContainerField(109), LayoutImmutable, Blittable]
		public bool RequireAnimationWeight { get; set; } // 0x6D (109)
		
		[ContainerField(110), LayoutImmutable, Blittable]
		public bool ExternalConnectTransform { get; set; } // 0x6E (110)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1194494871:
					ConnectTransform = (LinearTransform) p_Value;
					break;

				case 4041607518:
					AnimationEntitySpacePriority = (int) p_Value;
					break;

				case 2937232592:
					WarpBinding = (WarpAnimationBinding) p_Value;
					break;

				case 911082357:
					BoneToAlign = (GameplayBones) Enum.ToObject(typeof(GameplayBones), p_Value);
					break;

				case 3539295138:
					ForceAnimationTransform = (bool) p_Value;
					break;

				case 1434930590:
					RequireAnimationWeight = (bool) p_Value;
					break;

				case 3883178538:
					ExternalConnectTransform = (bool) p_Value;
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
				case 1194494871:
					return ConnectTransform;

				case 4041607518:
					return AnimationEntitySpacePriority;

				case 2937232592:
					return WarpBinding;

				case 911082357:
					return BoneToAlign;

				case 3539295138:
					return ForceAnimationTransform;

				case 1434930590:
					return RequireAnimationWeight;

				case 3883178538:
					return ExternalConnectTransform;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1194494871:
					return typeof(WarpAnimationEntityData).GetProperty(nameof(ConnectTransform));

				case 4041607518:
					return typeof(WarpAnimationEntityData).GetProperty(nameof(AnimationEntitySpacePriority));

				case 2937232592:
					return typeof(WarpAnimationEntityData).GetProperty(nameof(WarpBinding));

				case 911082357:
					return typeof(WarpAnimationEntityData).GetProperty(nameof(BoneToAlign));

				case 3539295138:
					return typeof(WarpAnimationEntityData).GetProperty(nameof(ForceAnimationTransform));

				case 1434930590:
					return typeof(WarpAnimationEntityData).GetProperty(nameof(RequireAnimationWeight));

				case 3883178538:
					return typeof(WarpAnimationEntityData).GetProperty(nameof(ExternalConnectTransform));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
