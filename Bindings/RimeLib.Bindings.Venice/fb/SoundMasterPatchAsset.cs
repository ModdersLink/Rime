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
	public class SoundMasterPatchAsset : 
		SoundGraphAsset
	{
		[ContainerField(24)]
		public RefArray<SoundBusData> Busses { get; set; } = new RefArray<SoundBusData>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<SoundBusData> RwMovieBus { get; set; } = new CtrRef<SoundBusData>(); // 0x1C (28)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2686083620:
					Busses = (RefArray<SoundBusData>) p_Value;
					break;

				case 2351289820:
					RwMovieBus = (CtrRef<SoundBusData>) p_Value;
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
				case 2686083620:
					return Busses;

				case 2351289820:
					return RwMovieBus;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2686083620:
					return typeof(SoundMasterPatchAsset).GetProperty(nameof(Busses));

				case 2351289820:
					return typeof(SoundMasterPatchAsset).GetProperty(nameof(RwMovieBus));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
