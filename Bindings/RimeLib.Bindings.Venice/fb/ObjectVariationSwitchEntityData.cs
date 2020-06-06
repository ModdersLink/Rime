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
	public class ObjectVariationSwitchEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public CtrRef<ObjectVariation> Variation1 { get; set; } = new CtrRef<ObjectVariation>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<ObjectVariation> Variation2 { get; set; } = new CtrRef<ObjectVariation>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2728063333:
					Variation1 = (CtrRef<ObjectVariation>) p_Value;
					break;

				case 2728063334:
					Variation2 = (CtrRef<ObjectVariation>) p_Value;
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
				case 2728063333:
					return Variation1;

				case 2728063334:
					return Variation2;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2728063333:
					return typeof(ObjectVariationSwitchEntityData).GetProperty(nameof(Variation1));

				case 2728063334:
					return typeof(ObjectVariationSwitchEntityData).GetProperty(nameof(Variation2));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
