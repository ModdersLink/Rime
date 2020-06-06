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
	public class VeniceUICombatAreaAsset : 
		UICombatAreaAsset
	{
		[ContainerField(16)]
		public CtrRef<UIDistanceFieldAsset> DistanceField { get; set; } = new CtrRef<UIDistanceFieldAsset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<UIDistanceFieldAsset> SurroundingDistanceField { get; set; } = new CtrRef<UIDistanceFieldAsset>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 750822692:
					DistanceField = (CtrRef<UIDistanceFieldAsset>) p_Value;
					break;

				case 1134425682:
					SurroundingDistanceField = (CtrRef<UIDistanceFieldAsset>) p_Value;
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
				case 750822692:
					return DistanceField;

				case 1134425682:
					return SurroundingDistanceField;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 750822692:
					return typeof(VeniceUICombatAreaAsset).GetProperty(nameof(DistanceField));

				case 1134425682:
					return typeof(VeniceUICombatAreaAsset).GetProperty(nameof(SurroundingDistanceField));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
