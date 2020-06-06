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
	public class SubWorldInclusionSetting : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SubWorldInclusionCriterion> Criterion { get; set; } = new CtrRef<SubWorldInclusionCriterion>(); // 0x8 (8)
		
		[ContainerField(12)]
		public List<string> EnabledOptions { get; set; } = new List<string>(); // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2480005462:
					Criterion = (CtrRef<SubWorldInclusionCriterion>) p_Value;
					break;

				case 2588709552:
					EnabledOptions = (List<string>) p_Value;
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
				case 2480005462:
					return Criterion;

				case 2588709552:
					return EnabledOptions;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2480005462:
					return typeof(SubWorldInclusionSetting).GetProperty(nameof(Criterion));

				case 2588709552:
					return typeof(SubWorldInclusionSetting).GetProperty(nameof(EnabledOptions));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
