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
	public class ScoringData : 
		Asset
	{
		[ContainerField(12)]
		public RefArray<ScoringTypeData> ScoringTypes { get; set; } = new RefArray<ScoringTypeData>(); // 0xC (12)
		
		[ContainerField(16)]
		public RefArray<ScoringHandlerData> ScoringHandlers { get; set; } = new RefArray<ScoringHandlerData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public RefArray<ScoringBucketData> Buckets { get; set; } = new RefArray<ScoringBucketData>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1268919875:
					ScoringTypes = (RefArray<ScoringTypeData>) p_Value;
					break;

				case 3193568419:
					ScoringHandlers = (RefArray<ScoringHandlerData>) p_Value;
					break;

				case 2760100856:
					Buckets = (RefArray<ScoringBucketData>) p_Value;
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
				case 1268919875:
					return ScoringTypes;

				case 3193568419:
					return ScoringHandlers;

				case 2760100856:
					return Buckets;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1268919875:
					return typeof(ScoringData).GetProperty(nameof(ScoringTypes));

				case 3193568419:
					return typeof(ScoringData).GetProperty(nameof(ScoringHandlers));

				case 2760100856:
					return typeof(ScoringData).GetProperty(nameof(Buckets));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
