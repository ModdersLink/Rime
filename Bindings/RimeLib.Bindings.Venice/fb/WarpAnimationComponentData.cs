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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 240)]
	public class WarpAnimationComponentData : 
		ComponentData
	{
		protected LinearTransform m_ConnectTransform = new LinearTransform();
		[ContainerField(Name: "ConnectTransform", Offset: 96, NameHash: 1194494871, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform ConnectTransform { get { return m_ConnectTransform; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(ConnectTransform), this, m_ConnectTransform, value)) m_ConnectTransform = value; } } // 0x60 (96)
		
		protected CannedAnimationBinding m_CannedAnimBinding = new CannedAnimationBinding();
		[ContainerField(Name: "CannedAnimBinding", Offset: 160, NameHash: 3536770252, Flags: 41)]
		public CannedAnimationBinding CannedAnimBinding { get { return m_CannedAnimBinding; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(CannedAnimBinding), this, m_CannedAnimBinding, value)) m_CannedAnimBinding = value; } } // 0xA0 (160)
		
		protected int m_AnimationEntitySpacePriority = new int();
		[ContainerField(Name: "AnimationEntitySpacePriority", Offset: 200, NameHash: 4041607518, Flags: 49405), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get { return m_AnimationEntitySpacePriority; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(AnimationEntitySpacePriority), this, m_AnimationEntitySpacePriority, value)) m_AnimationEntitySpacePriority = value; } } // 0xC8 (200)
		
		protected WarpAnimationBinding m_WarpBinding = new WarpAnimationBinding();
		[ContainerField(Name: "WarpBinding", Offset: 204, NameHash: 2937232592, Flags: 41)]
		public WarpAnimationBinding WarpBinding { get { return m_WarpBinding; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(WarpBinding), this, m_WarpBinding, value)) m_WarpBinding = value; } } // 0xCC (204)
		
		protected GameplayBones m_BoneToAlign = new GameplayBones();
		[ContainerField(Name: "BoneToAlign", Offset: 224, NameHash: 911082357, Flags: 137)]
		public GameplayBones BoneToAlign { get { return m_BoneToAlign; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(BoneToAlign), this, m_BoneToAlign, value)) m_BoneToAlign = value; } } // 0xE0 (224)
		
		protected bool m_RequireAnimationWeight = new bool();
		[ContainerField(Name: "RequireAnimationWeight", Offset: 228, NameHash: 1434930590, Flags: 49325), LayoutImmutable, Blittable]
		public bool RequireAnimationWeight { get { return m_RequireAnimationWeight; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(RequireAnimationWeight), this, m_RequireAnimationWeight, value)) m_RequireAnimationWeight = value; } } // 0xE4 (228)
		
		protected bool m_ForceAnimationTransform = new bool();
		[ContainerField(Name: "ForceAnimationTransform", Offset: 229, NameHash: 3539295138, Flags: 49325), LayoutImmutable, Blittable]
		public bool ForceAnimationTransform { get { return m_ForceAnimationTransform; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(ForceAnimationTransform), this, m_ForceAnimationTransform, value)) m_ForceAnimationTransform = value; } } // 0xE5 (229)
		
		protected bool m_ExternalConnectTransform = new bool();
		[ContainerField(Name: "ExternalConnectTransform", Offset: 230, NameHash: 3883178538, Flags: 49325), LayoutImmutable, Blittable]
		public bool ExternalConnectTransform { get { return m_ExternalConnectTransform; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(ExternalConnectTransform), this, m_ExternalConnectTransform, value)) m_ExternalConnectTransform = value; } } // 0xE6 (230)
		
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
