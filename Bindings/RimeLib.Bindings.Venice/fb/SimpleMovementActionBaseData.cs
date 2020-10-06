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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class SimpleMovementActionBaseData : 
		MovementActionData
	{
		protected SimpleMovementActionTimeData m_StartTimeInfo = new SimpleMovementActionTimeData();
		[ContainerField(8), MemberInfoFlag(41), ContainerFieldNameHash(2015117886)]
		public SimpleMovementActionTimeData StartTimeInfo { get { return m_StartTimeInfo; } set { if (OnPropertyChanging("SimpleMovementActionBaseData." + nameof(StartTimeInfo), this, m_StartTimeInfo, value)) m_StartTimeInfo = value; } } // 0x8 (8)
		
		protected SimpleMovementActionTimeData m_RunTimeInfo = new SimpleMovementActionTimeData();
		[ContainerField(16), MemberInfoFlag(41), ContainerFieldNameHash(3849518743)]
		public SimpleMovementActionTimeData RunTimeInfo { get { return m_RunTimeInfo; } set { if (OnPropertyChanging("SimpleMovementActionBaseData." + nameof(RunTimeInfo), this, m_RunTimeInfo, value)) m_RunTimeInfo = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2015117886:
					StartTimeInfo = (SimpleMovementActionTimeData) p_Value;
					break;

				case 3849518743:
					RunTimeInfo = (SimpleMovementActionTimeData) p_Value;
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
				case 2015117886:
					return StartTimeInfo;

				case 3849518743:
					return RunTimeInfo;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2015117886:
					return typeof(SimpleMovementActionBaseData).GetProperty(nameof(StartTimeInfo));

				case 3849518743:
					return typeof(SimpleMovementActionBaseData).GetProperty(nameof(RunTimeInfo));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
