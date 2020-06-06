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
	public class MatchmakingUserExtendedDataRule : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable]
		public string Rule { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable]
		public string MinFitThresHold { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089359915:
					Rule = (string) p_Value;
					break;

				case 3351757955:
					MinFitThresHold = (string) p_Value;
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
				case 2089359915:
					return Rule;

				case 3351757955:
					return MinFitThresHold;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089359915:
					return typeof(MatchmakingUserExtendedDataRule).GetProperty(nameof(Rule));

				case 3351757955:
					return typeof(MatchmakingUserExtendedDataRule).GetProperty(nameof(MinFitThresHold));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
