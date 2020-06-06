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
	public class MixerAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<MixerGraphData> Graph { get; set; } = new CtrRef<MixerGraphData>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<MixerPreset> Presets { get; set; } = new RefArray<MixerPreset>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<MixerPreset> DefaultPreset { get; set; } = new CtrRef<MixerPreset>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 208111145:
					Graph = (CtrRef<MixerGraphData>) p_Value;
					break;

				case 3463460435:
					Presets = (RefArray<MixerPreset>) p_Value;
					break;

				case 4117030027:
					DefaultPreset = (CtrRef<MixerPreset>) p_Value;
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
				case 208111145:
					return Graph;

				case 3463460435:
					return Presets;

				case 4117030027:
					return DefaultPreset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 208111145:
					return typeof(MixerAsset).GetProperty(nameof(Graph));

				case 3463460435:
					return typeof(MixerAsset).GetProperty(nameof(Presets));

				case 4117030027:
					return typeof(MixerAsset).GetProperty(nameof(DefaultPreset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
