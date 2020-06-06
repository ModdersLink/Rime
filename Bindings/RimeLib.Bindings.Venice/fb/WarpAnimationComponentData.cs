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
	public class WarpAnimationComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform ConnectTransform { get; set; } = new LinearTransform(); // 0x60 (96)
		
		[ContainerField(160)]
		public CannedAnimationBinding CannedAnimBinding { get; set; } = new CannedAnimationBinding(); // 0xA0 (160)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; } // 0xC8 (200)
		
		[ContainerField(204)]
		public WarpAnimationBinding WarpBinding { get; set; } = new WarpAnimationBinding(); // 0xCC (204)
		
		[ContainerField(224)]
		public GameplayBones BoneToAlign { get; set; } = new GameplayBones(); // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public bool RequireAnimationWeight { get; set; } // 0xE4 (228)
		
		[ContainerField(229), LayoutImmutable, Blittable]
		public bool ForceAnimationTransform { get; set; } // 0xE5 (229)
		
		[ContainerField(230), LayoutImmutable, Blittable]
		public bool ExternalConnectTransform { get; set; } // 0xE6 (230)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1194494871:
					ConnectTransform = (LinearTransform) p_Value;
					break;

				case 3536770252:
					CannedAnimBinding = (CannedAnimationBinding) p_Value;
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

				case 1434930590:
					RequireAnimationWeight = (bool) p_Value;
					break;

				case 3539295138:
					ForceAnimationTransform = (bool) p_Value;
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

				case 3536770252:
					return CannedAnimBinding;

				case 4041607518:
					return AnimationEntitySpacePriority;

				case 2937232592:
					return WarpBinding;

				case 911082357:
					return BoneToAlign;

				case 1434930590:
					return RequireAnimationWeight;

				case 3539295138:
					return ForceAnimationTransform;

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
					return typeof(WarpAnimationComponentData).GetProperty(nameof(ConnectTransform));

				case 3536770252:
					return typeof(WarpAnimationComponentData).GetProperty(nameof(CannedAnimBinding));

				case 4041607518:
					return typeof(WarpAnimationComponentData).GetProperty(nameof(AnimationEntitySpacePriority));

				case 2937232592:
					return typeof(WarpAnimationComponentData).GetProperty(nameof(WarpBinding));

				case 911082357:
					return typeof(WarpAnimationComponentData).GetProperty(nameof(BoneToAlign));

				case 1434930590:
					return typeof(WarpAnimationComponentData).GetProperty(nameof(RequireAnimationWeight));

				case 3539295138:
					return typeof(WarpAnimationComponentData).GetProperty(nameof(ForceAnimationTransform));

				case 3883178538:
					return typeof(WarpAnimationComponentData).GetProperty(nameof(ExternalConnectTransform));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
