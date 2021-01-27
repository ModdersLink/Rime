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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 160)]
	public class AntAnimatableComponentData : 
		ComponentData
	{
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 96, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("AntAnimatableComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x60 (96)
		
		protected SubRealm m_SubRealm = new SubRealm();
		[ContainerField(Name: "SubRealm", Offset: 100, NameHash: 1747841366, Flags: 137)]
		public SubRealm SubRealm { get { return m_SubRealm; } set { if (OnPropertyChanging("AntAnimatableComponentData." + nameof(SubRealm), this, m_SubRealm, value)) m_SubRealm = value; } } // 0x64 (100)
		
		protected AntAnimationHandlerData m_AnimationData = new AntAnimationHandlerData();
		[ContainerField(Name: "AnimationData", Offset: 104, NameHash: 2826644739, Flags: 41)]
		public AntAnimationHandlerData AnimationData { get { return m_AnimationData; } set { if (OnPropertyChanging("AntAnimatableComponentData." + nameof(AnimationData), this, m_AnimationData, value)) m_AnimationData = value; } } // 0x68 (104)
		
		protected CtrRef<SkinnedMeshAsset> m_Mesh = new CtrRef<SkinnedMeshAsset>();
		[ContainerField(Name: "Mesh", Offset: 152, NameHash: 2088783990, Flags: 53)]
		public CtrRef<SkinnedMeshAsset> Mesh { get { return m_Mesh; } set { if (OnPropertyChanging("AntAnimatableComponentData." + nameof(Mesh), this, m_Mesh, value)) m_Mesh = value; } } // 0x98 (152)
		
		protected bool m_AutoActivate = new bool();
		[ContainerField(Name: "AutoActivate", Offset: 156, NameHash: 778899923, Flags: 49325), LayoutImmutable, Blittable]
		public bool AutoActivate { get { return m_AutoActivate; } set { if (OnPropertyChanging("AntAnimatableComponentData." + nameof(AutoActivate), this, m_AutoActivate, value)) m_AutoActivate = value; } } // 0x9C (156)
		
		protected bool m_AnimationControlledFromStart = new bool();
		[ContainerField(Name: "AnimationControlledFromStart", Offset: 157, NameHash: 348704943, Flags: 49325), LayoutImmutable, Blittable]
		public bool AnimationControlledFromStart { get { return m_AnimationControlledFromStart; } set { if (OnPropertyChanging("AntAnimatableComponentData." + nameof(AnimationControlledFromStart), this, m_AnimationControlledFromStart, value)) m_AnimationControlledFromStart = value; } } // 0x9D (157)
		
		protected bool m_ForceDisableCulling = new bool();
		[ContainerField(Name: "ForceDisableCulling", Offset: 158, NameHash: 1622931482, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForceDisableCulling { get { return m_ForceDisableCulling; } set { if (OnPropertyChanging("AntAnimatableComponentData." + nameof(ForceDisableCulling), this, m_ForceDisableCulling, value)) m_ForceDisableCulling = value; } } // 0x9E (158)
		
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
