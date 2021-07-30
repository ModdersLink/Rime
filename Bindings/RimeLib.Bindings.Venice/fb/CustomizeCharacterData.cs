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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 32)]
	public class CustomizeCharacterData : 
		Asset
	{
		protected List<CustomizeVisual> m_VisualGroups = new List<CustomizeVisual>();
		[ContainerField(Name: "VisualGroups", Offset: 12, NameHash: 1154342877, Flags: 65)]
		public List<CustomizeVisual> VisualGroups { get { return m_VisualGroups; } set { if (OnPropertyChanging("CustomizeCharacterData." + nameof(VisualGroups), this, m_VisualGroups, value)) m_VisualGroups = value; } } // 0xC (12)
		
		protected float m_OverrideCriticalHealthThreshold = new float();
		[ContainerField(Name: "OverrideCriticalHealthThreshold", Offset: 16, NameHash: 2799968817, Flags: 49469), LayoutImmutable, Blittable]
		public float OverrideCriticalHealthThreshold { get { return m_OverrideCriticalHealthThreshold; } set { if (OnPropertyChanging("CustomizeCharacterData." + nameof(OverrideCriticalHealthThreshold), this, m_OverrideCriticalHealthThreshold, value)) m_OverrideCriticalHealthThreshold = value; } } // 0x10 (16)
		
		protected RefArray<UnlockAssetBase> m_Unlocks = new RefArray<UnlockAssetBase>();
		[ContainerField(Name: "Unlocks", Offset: 20, NameHash: 3464375270, Flags: 65)]
		public RefArray<UnlockAssetBase> Unlocks { get { return m_Unlocks; } set { if (OnPropertyChanging("CustomizeCharacterData." + nameof(Unlocks), this, m_Unlocks, value)) m_Unlocks = value; } } // 0x14 (20)
		
		protected float m_OverrideMaxHealth = new float();
		[ContainerField(Name: "OverrideMaxHealth", Offset: 24, NameHash: 3943553849, Flags: 49469), LayoutImmutable, Blittable]
		public float OverrideMaxHealth { get { return m_OverrideMaxHealth; } set { if (OnPropertyChanging("CustomizeCharacterData." + nameof(OverrideMaxHealth), this, m_OverrideMaxHealth, value)) m_OverrideMaxHealth = value; } } // 0x18 (24)
		
		protected bool m_ClearVisualState = new bool();
		[ContainerField(Name: "ClearVisualState", Offset: 28, NameHash: 443106111, Flags: 49325), LayoutImmutable, Blittable]
		public bool ClearVisualState { get { return m_ClearVisualState; } set { if (OnPropertyChanging("CustomizeCharacterData." + nameof(ClearVisualState), this, m_ClearVisualState, value)) m_ClearVisualState = value; } } // 0x1C (28)
		
		protected bool m_RestoreToOriginalVisualState = new bool();
		[ContainerField(Name: "RestoreToOriginalVisualState", Offset: 29, NameHash: 1970657676, Flags: 49325), LayoutImmutable, Blittable]
		public bool RestoreToOriginalVisualState { get { return m_RestoreToOriginalVisualState; } set { if (OnPropertyChanging("CustomizeCharacterData." + nameof(RestoreToOriginalVisualState), this, m_RestoreToOriginalVisualState, value)) m_RestoreToOriginalVisualState = value; } } // 0x1D (29)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1154342877:
					VisualGroups = (List<CustomizeVisual>) p_Value;
					break;

				case 2799968817:
					OverrideCriticalHealthThreshold = (float) p_Value;
					break;

				case 3464375270:
					Unlocks = (RefArray<UnlockAssetBase>) p_Value;
					break;

				case 3943553849:
					OverrideMaxHealth = (float) p_Value;
					break;

				case 443106111:
					ClearVisualState = (bool) p_Value;
					break;

				case 1970657676:
					RestoreToOriginalVisualState = (bool) p_Value;
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
				case 1154342877:
					return VisualGroups;

				case 2799968817:
					return OverrideCriticalHealthThreshold;

				case 3464375270:
					return Unlocks;

				case 3943553849:
					return OverrideMaxHealth;

				case 443106111:
					return ClearVisualState;

				case 1970657676:
					return RestoreToOriginalVisualState;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1154342877:
					return typeof(CustomizeCharacterData).GetProperty(nameof(VisualGroups));

				case 2799968817:
					return typeof(CustomizeCharacterData).GetProperty(nameof(OverrideCriticalHealthThreshold));

				case 3464375270:
					return typeof(CustomizeCharacterData).GetProperty(nameof(Unlocks));

				case 3943553849:
					return typeof(CustomizeCharacterData).GetProperty(nameof(OverrideMaxHealth));

				case 443106111:
					return typeof(CustomizeCharacterData).GetProperty(nameof(ClearVisualState));

				case 1970657676:
					return typeof(CustomizeCharacterData).GetProperty(nameof(RestoreToOriginalVisualState));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
