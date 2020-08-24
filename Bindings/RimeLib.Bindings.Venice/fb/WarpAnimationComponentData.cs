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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class WarpAnimationComponentData : 
		ComponentData
	{
		protected LinearTransform m_ConnectTransform = new LinearTransform();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1194494871)]
		public LinearTransform ConnectTransform { get { return m_ConnectTransform; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(ConnectTransform), this, m_ConnectTransform, value)) m_ConnectTransform = value; } } // 0x60 (96)
		
		protected CannedAnimationBinding m_CannedAnimBinding = new CannedAnimationBinding();
		[ContainerField(160), MemberInfoFlag(41), ContainerFieldNameHash(3536770252)]
		public CannedAnimationBinding CannedAnimBinding { get { return m_CannedAnimBinding; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(CannedAnimBinding), this, m_CannedAnimBinding, value)) m_CannedAnimBinding = value; } } // 0xA0 (160)
		
		protected int m_AnimationEntitySpacePriority = new int();
		[ContainerField(200), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(4041607518)]
		public int AnimationEntitySpacePriority { get { return m_AnimationEntitySpacePriority; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(AnimationEntitySpacePriority), this, m_AnimationEntitySpacePriority, value)) m_AnimationEntitySpacePriority = value; } } // 0xC8 (200)
		
		protected WarpAnimationBinding m_WarpBinding = new WarpAnimationBinding();
		[ContainerField(204), MemberInfoFlag(41), ContainerFieldNameHash(2937232592)]
		public WarpAnimationBinding WarpBinding { get { return m_WarpBinding; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(WarpBinding), this, m_WarpBinding, value)) m_WarpBinding = value; } } // 0xCC (204)
		
		protected GameplayBones m_BoneToAlign = new GameplayBones();
		[ContainerField(224), MemberInfoFlag(137), ContainerFieldNameHash(911082357)]
		public GameplayBones BoneToAlign { get { return m_BoneToAlign; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(BoneToAlign), this, m_BoneToAlign, value)) m_BoneToAlign = value; } } // 0xE0 (224)
		
		protected bool m_RequireAnimationWeight = new bool();
		[ContainerField(228), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1434930590)]
		public bool RequireAnimationWeight { get { return m_RequireAnimationWeight; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(RequireAnimationWeight), this, m_RequireAnimationWeight, value)) m_RequireAnimationWeight = value; } } // 0xE4 (228)
		
		protected bool m_ForceAnimationTransform = new bool();
		[ContainerField(229), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3539295138)]
		public bool ForceAnimationTransform { get { return m_ForceAnimationTransform; } set { if (OnPropertyChanging("WarpAnimationComponentData." + nameof(ForceAnimationTransform), this, m_ForceAnimationTransform, value)) m_ForceAnimationTransform = value; } } // 0xE5 (229)
		
		protected bool m_ExternalConnectTransform = new bool();
		[ContainerField(230), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3883178538)]
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
