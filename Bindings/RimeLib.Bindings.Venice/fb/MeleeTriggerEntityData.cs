///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class MeleeTriggerEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform ConnectTransform { get; set; } = new LinearTransform(); // 0x10 (16)
		
		[ContainerField(80)]
		public CtrRef<AntEnumeration> MeleeType { get; set; } = new CtrRef<AntEnumeration>(); // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public bool MeleeEnabled { get; set; } // 0x54 (84)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1194494871:
					ConnectTransform = (LinearTransform) p_Value;
					break;

				case 2762192025:
					MeleeType = (CtrRef<AntEnumeration>) p_Value;
					break;

				case 1976811876:
					MeleeEnabled = (bool) p_Value;
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

				case 2762192025:
					return MeleeType;

				case 1976811876:
					return MeleeEnabled;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1194494871:
					return typeof(MeleeTriggerEntityData).GetProperty(nameof(ConnectTransform));

				case 2762192025:
					return typeof(MeleeTriggerEntityData).GetProperty(nameof(MeleeType));

				case 1976811876:
					return typeof(MeleeTriggerEntityData).GetProperty(nameof(MeleeEnabled));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
