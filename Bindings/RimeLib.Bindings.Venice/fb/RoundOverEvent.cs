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
	[ContainerType(8), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class RoundOverEvent : 
		MetricEvent
	{
		protected int m_WinningTeam = new int();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2949944838)]
		public int WinningTeam { get { return m_WinningTeam; } set { if (OnPropertyChanging("RoundOverEvent." + nameof(WinningTeam), this, m_WinningTeam, value)) m_WinningTeam = value; } } // 0x10 (16)
		
		protected int m_TicketsLeft = new int();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(715127049)]
		public int TicketsLeft { get { return m_TicketsLeft; } set { if (OnPropertyChanging("RoundOverEvent." + nameof(TicketsLeft), this, m_TicketsLeft, value)) m_TicketsLeft = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2949944838:
					WinningTeam = (int) p_Value;
					break;

				case 715127049:
					TicketsLeft = (int) p_Value;
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
				case 2949944838:
					return WinningTeam;

				case 715127049:
					return TicketsLeft;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2949944838:
					return typeof(RoundOverEvent).GetProperty(nameof(WinningTeam));

				case 715127049:
					return typeof(RoundOverEvent).GetProperty(nameof(TicketsLeft));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
