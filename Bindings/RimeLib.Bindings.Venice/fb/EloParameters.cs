///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 20)]
	public class EloParameters : FrostbiteContainer
	{
		[ContainerField(Name: "KWinner", Offset: 0, NameHash: 2886104327, Flags: 65)]
		public List<EloFunctionPoint> KWinner { get; set; } = new List<EloFunctionPoint>(); // 0x0 (0)
		
		[ContainerField(Name: "KLoser", Offset: 4, NameHash: 3052066025, Flags: 65)]
		public List<EloFunctionPoint> KLoser { get; set; } = new List<EloFunctionPoint>(); // 0x4 (4)
		
		[ContainerField(Name: "KNewbie", Offset: 8, NameHash: 1701338076, Flags: 65)]
		public List<EloFunctionPoint> KNewbie { get; set; } = new List<EloFunctionPoint>(); // 0x8 (8)
		
		[ContainerField(Name: "KCompetitor", Offset: 12, NameHash: 3661384878, Flags: 65)]
		public List<EloFunctionPoint> KCompetitor { get; set; } = new List<EloFunctionPoint>(); // 0xC (12)
		
		[ContainerField(Name: "Expected", Offset: 16, NameHash: 4240451803, Flags: 65)]
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
