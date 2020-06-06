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
	public class AntAnimatableComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public Realm Realm { get; set; } = new Realm(); // 0x60 (96)
		
		[ContainerField(100)]
		public SubRealm SubRealm { get; set; } = new SubRealm(); // 0x64 (100)
		
		[ContainerField(104)]
		public AntAnimationHandlerData AnimationData { get; set; } = new AntAnimationHandlerData(); // 0x68 (104)
		
		[ContainerField(152)]
		public CtrRef<SkinnedMeshAsset> Mesh { get; set; } = new CtrRef<SkinnedMeshAsset>(); // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public bool AutoActivate { get; set; } // 0x9C (156)
		
		[ContainerField(157), LayoutImmutable, Blittable]
		public bool AnimationControlledFromStart { get; set; } // 0x9D (157)
		
		[ContainerField(158), LayoutImmutable, Blittable]
		public bool ForceDisableCulling { get; set; } // 0x9E (158)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 1747841366:
					SubRealm = (SubRealm) Enum.ToObject(typeof(SubRealm), p_Value);
					break;

				case 2826644739:
					AnimationData = (AntAnimationHandlerData) p_Value;
					break;

				case 2088783990:
					Mesh = (CtrRef<SkinnedMeshAsset>) p_Value;
					break;

				case 778899923:
					AutoActivate = (bool) p_Value;
					break;

				case 348704943:
					AnimationControlledFromStart = (bool) p_Value;
					break;

				case 1622931482:
					ForceDisableCulling = (bool) p_Value;
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
				case 229961746:
					return Realm;

				case 1747841366:
					return SubRealm;

				case 2826644739:
					return AnimationData;

				case 2088783990:
					return Mesh;

				case 778899923:
					return AutoActivate;

				case 348704943:
					return AnimationControlledFromStart;

				case 1622931482:
					return ForceDisableCulling;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 229961746:
					return typeof(AntAnimatableComponentData).GetProperty(nameof(Realm));

				case 1747841366:
					return typeof(AntAnimatableComponentData).GetProperty(nameof(SubRealm));

				case 2826644739:
					return typeof(AntAnimatableComponentData).GetProperty(nameof(AnimationData));

				case 2088783990:
					return typeof(AntAnimatableComponentData).GetProperty(nameof(Mesh));

				case 778899923:
					return typeof(AntAnimatableComponentData).GetProperty(nameof(AutoActivate));

				case 348704943:
					return typeof(AntAnimatableComponentData).GetProperty(nameof(AnimationControlledFromStart));

				case 1622931482:
					return typeof(AntAnimatableComponentData).GetProperty(nameof(ForceDisableCulling));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
