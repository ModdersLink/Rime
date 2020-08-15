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
	[ContainerType(16)]
	public class WarpAnimationEntityData : 
		EntityData
	{
		protected LinearTransform m_ConnectTransform = new LinearTransform();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(1194494871)]
		public LinearTransform ConnectTransform { get { return m_ConnectTransform; } set { if (OnPropertyChanging("WarpAnimationEntityData." + nameof(ConnectTransform), this, m_ConnectTransform, value)) m_ConnectTransform = value; } } // 0x10 (16)
		
		protected int m_AnimationEntitySpacePriority = new int();
		[ContainerField(80), LayoutImmutable, Blittable, ContainerFieldNameHash(4041607518)]
		public int AnimationEntitySpacePriority { get { return m_AnimationEntitySpacePriority; } set { if (OnPropertyChanging("WarpAnimationEntityData." + nameof(AnimationEntitySpacePriority), this, m_AnimationEntitySpacePriority, value)) m_AnimationEntitySpacePriority = value; } } // 0x50 (80)
		
		protected WarpAnimationBinding m_WarpBinding = new WarpAnimationBinding();
		[ContainerField(84), ContainerFieldNameHash(2937232592)]
		public WarpAnimationBinding WarpBinding { get { return m_WarpBinding; } set { if (OnPropertyChanging("WarpAnimationEntityData." + nameof(WarpBinding), this, m_WarpBinding, value)) m_WarpBinding = value; } } // 0x54 (84)
		
		protected GameplayBones m_BoneToAlign = new GameplayBones();
		[ContainerField(104), ContainerFieldNameHash(911082357)]
		public GameplayBones BoneToAlign { get { return m_BoneToAlign; } set { if (OnPropertyChanging("WarpAnimationEntityData." + nameof(BoneToAlign), this, m_BoneToAlign, value)) m_BoneToAlign = value; } } // 0x68 (104)
		
		protected bool m_ForceAnimationTransform = new bool();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(3539295138)]
		public bool ForceAnimationTransform { get { return m_ForceAnimationTransform; } set { if (OnPropertyChanging("WarpAnimationEntityData." + nameof(ForceAnimationTransform), this, m_ForceAnimationTransform, value)) m_ForceAnimationTransform = value; } } // 0x6C (108)
		
		protected bool m_RequireAnimationWeight = new bool();
		[ContainerField(109), LayoutImmutable, Blittable, ContainerFieldNameHash(1434930590)]
		public bool RequireAnimationWeight { get { return m_RequireAnimationWeight; } set { if (OnPropertyChanging("WarpAnimationEntityData." + nameof(RequireAnimationWeight), this, m_RequireAnimationWeight, value)) m_RequireAnimationWeight = value; } } // 0x6D (109)
		
		protected bool m_ExternalConnectTransform = new bool();
		[ContainerField(110), LayoutImmutable, Blittable, ContainerFieldNameHash(3883178538)]
		public bool ExternalConnectTransform { get { return m_ExternalConnectTransform; } set { if (OnPropertyChanging("WarpAnimationEntityData." + nameof(ExternalConnectTransform), this, m_ExternalConnectTransform, value)) m_ExternalConnectTransform = value; } } // 0x6E (110)
		
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
