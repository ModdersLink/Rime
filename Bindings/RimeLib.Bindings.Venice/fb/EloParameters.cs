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
	public class EloParameters : FrostbiteContainer
	{
		[ContainerField(0)]
		public List<EloFunctionPoint> KWinner { get; set; } = new List<EloFunctionPoint>(); // 0x0 (0)
		
		[ContainerField(4)]
		public List<EloFunctionPoint> KLoser { get; set; } = new List<EloFunctionPoint>(); // 0x4 (4)
		
		[ContainerField(8)]
		public List<EloFunctionPoint> KNewbie { get; set; } = new List<EloFunctionPoint>(); // 0x8 (8)
		
		[ContainerField(12)]
		public List<EloFunctionPoint> KCompetitor { get; set; } = new List<EloFunctionPoint>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<EloExpectedFunctionPoint> Expected { get; set; } = new List<EloExpectedFunctionPoint>(); // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2886104327:
					KWinner = (List<EloFunctionPoint>) p_Value;
					break;

				case 3052066025:
					KLoser = (List<EloFunctionPoint>) p_Value;
					break;

				case 1701338076:
					KNewbie = (List<EloFunctionPoint>) p_Value;
					break;

				case 3661384878:
					KCompetitor = (List<EloFunctionPoint>) p_Value;
					break;

				case 4240451803:
					Expected = (List<EloExpectedFunctionPoint>) p_Value;
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
				case 2886104327:
					return KWinner;

				case 3052066025:
					return KLoser;

				case 1701338076:
					return KNewbie;

				case 3661384878:
					return KCompetitor;

				case 4240451803:
					return Expected;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2886104327:
					return typeof(EloParameters).GetProperty(nameof(KWinner));

				case 3052066025:
					return typeof(EloParameters).GetProperty(nameof(KLoser));

				case 1701338076:
					return typeof(EloParameters).GetProperty(nameof(KNewbie));

				case 3661384878:
					return typeof(EloParameters).GetProperty(nameof(KCompetitor));

				case 4240451803:
					return typeof(EloParameters).GetProperty(nameof(Expected));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
