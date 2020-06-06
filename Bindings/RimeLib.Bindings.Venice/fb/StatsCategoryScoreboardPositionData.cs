///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class StatsCategoryScoreboardPositionData : 
		StatsCategoryBaseData
	{
		[ContainerField(20)]
		public List<ScoreboardPosition> Positions { get; set; } = new List<ScoreboardPosition>(); // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 616073487:
					if (p_Value.GetType() == typeof (List<uint>))
						Positions = ((List<uint>) p_Value).Select(x => (ScoreboardPosition) Enum.ToObject(typeof(ScoreboardPosition), x)).ToList();
					else
						Positions = (List<ScoreboardPosition>) p_Value;
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
				case 616073487:
					return Positions;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 616073487:
					return typeof(StatsCategoryScoreboardPositionData).GetProperty(nameof(Positions));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
