///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class GunMasterLevelInfo : FrostbiteContainer
	{
		[ContainerField(0)]
		public CtrRef<CustomizeSoldierData> CustomizeData { get; set; } = new CtrRef<CustomizeSoldierData>(); // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public int KillsNeeded { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1994334608:
					CustomizeData = (CtrRef<CustomizeSoldierData>) p_Value;
					break;

				case 2408595391:
					KillsNeeded = (int) p_Value;
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
				case 1994334608:
					return CustomizeData;

				case 2408595391:
					return KillsNeeded;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1994334608:
					return typeof(GunMasterLevelInfo).GetProperty(nameof(CustomizeData));

				case 2408595391:
					return typeof(GunMasterLevelInfo).GetProperty(nameof(KillsNeeded));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
