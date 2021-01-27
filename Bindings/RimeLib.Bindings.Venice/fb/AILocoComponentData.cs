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
	public class AILocoComponentData : 
		ComponentData
	{
		protected AILocoBinding m_Binding = new AILocoBinding();
		[ContainerField(Name: "Binding", Offset: 96, NameHash: 2590060228, Flags: 41)]
		public AILocoBinding Binding { get { return m_Binding; } set { if (OnPropertyChanging("AILocoComponentData." + nameof(Binding), this, m_Binding, value)) m_Binding = value; } } // 0x60 (96)
		
		protected AILocoVaultBinding m_VaultBinding = new AILocoVaultBinding();
		[ContainerField(Name: "VaultBinding", Offset: 132, NameHash: 736566942, Flags: 41)]
		public AILocoVaultBinding VaultBinding { get { return m_VaultBinding; } set { if (OnPropertyChanging("AILocoComponentData." + nameof(VaultBinding), this, m_VaultBinding, value)) m_VaultBinding = value; } } // 0x84 (132)
		
		protected AILocoCoverBinding m_CoverBinding = new AILocoCoverBinding();
		[ContainerField(Name: "CoverBinding", Offset: 160, NameHash: 3534640393, Flags: 41)]
		public AILocoCoverBinding CoverBinding { get { return m_CoverBinding; } set { if (OnPropertyChanging("AILocoComponentData." + nameof(CoverBinding), this, m_CoverBinding, value)) m_CoverBinding = value; } } // 0xA0 (160)
		
		protected float m_WantedYaw = new float();
		[ContainerField(Name: "WantedYaw", Offset: 232, NameHash: 82142727, Flags: 49469), LayoutImmutable, Blittable]
		public float WantedYaw { get { return m_WantedYaw; } set { if (OnPropertyChanging("AILocoComponentData." + nameof(WantedYaw), this, m_WantedYaw, value)) m_WantedYaw = value; } } // 0xE8 (232)
		
		protected int m_AnimationEntitySpacePriority = new int();
		[ContainerField(Name: "AnimationEntitySpacePriority", Offset: 236, NameHash: 4041607518, Flags: 49405), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get { return m_AnimationEntitySpacePriority; } set { if (OnPropertyChanging("AILocoComponentData." + nameof(AnimationEntitySpacePriority), this, m_AnimationEntitySpacePriority, value)) m_AnimationEntitySpacePriority = value; } } // 0xEC (236)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2590060228:
					Binding = (AILocoBinding) p_Value;
					break;

				case 736566942:
					VaultBinding = (AILocoVaultBinding) p_Value;
					break;

				case 3534640393:
					CoverBinding = (AILocoCoverBinding) p_Value;
					break;

				case 82142727:
					WantedYaw = (float) p_Value;
					break;

				case 4041607518:
					AnimationEntitySpacePriority = (int) p_Value;
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
				case 2590060228:
					return Binding;

				case 736566942:
					return VaultBinding;

				case 3534640393:
					return CoverBinding;

				case 82142727:
					return WantedYaw;

				case 4041607518:
					return AnimationEntitySpacePriority;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2590060228:
					return typeof(AILocoComponentData).GetProperty(nameof(Binding));

				case 736566942:
					return typeof(AILocoComponentData).GetProperty(nameof(VaultBinding));

				case 3534640393:
					return typeof(AILocoComponentData).GetProperty(nameof(CoverBinding));

				case 82142727:
					return typeof(AILocoComponentData).GetProperty(nameof(WantedYaw));

				case 4041607518:
					return typeof(AILocoComponentData).GetProperty(nameof(AnimationEntitySpacePriority));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
