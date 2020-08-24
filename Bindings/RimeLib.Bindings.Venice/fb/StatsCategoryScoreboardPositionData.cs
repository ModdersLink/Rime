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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class StatsCategoryScoreboardPositionData : 
		StatsCategoryBaseData
	{
		protected List<ScoreboardPosition> m_Positions = new List<ScoreboardPosition>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(616073487), ContainerArray]
		public List<ScoreboardPosition> Positions { get { return m_Positions; } set { if (OnPropertyChanging("StatsCategoryScoreboardPositionData." + nameof(Positions), this, m_Positions, value)) m_Positions = value; } } // 0x14 (20)
		
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
