///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class CustomizeCharacterData : 
		Asset
	{
		[ContainerField(12)]
		public List<CustomizeVisual> VisualGroups { get; set; } = new List<CustomizeVisual>(); // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float OverrideCriticalHealthThreshold { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<UnlockAssetBase> Unlocks { get; set; } = new RefArray<UnlockAssetBase>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float OverrideMaxHealth { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool ClearVisualState { get; set; } // 0x1C (28)
		
		[ContainerField(29), LayoutImmutable, Blittable]
		public bool RestoreToOriginalVisualState { get; set; } // 0x1D (29)
		
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
