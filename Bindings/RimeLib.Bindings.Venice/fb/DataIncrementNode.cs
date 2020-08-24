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
	public class DataIncrementNode : 
		UINodeData
	{
		protected CtrRef<UINodePort> m_In = new CtrRef<UINodePort>();
		[ContainerField(20), MemberInfoFlag(53), ContainerFieldNameHash(5862146), ContainerCtrRef]
		public CtrRef<UINodePort> In { get { return m_In; } set { if (OnPropertyChanging("DataIncrementNode." + nameof(In), this, m_In, value)) m_In = value; } } // 0x14 (20)
		
		protected CtrRef<UINodePort> m_Out = new CtrRef<UINodePort>();
		[ContainerField(24), MemberInfoFlag(53), ContainerFieldNameHash(193453899), ContainerCtrRef]
		public CtrRef<UINodePort> Out { get { return m_Out; } set { if (OnPropertyChanging("DataIncrementNode." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x18 (24)
		
		protected float m_Max = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(193446865)]
		public float Max { get { return m_Max; } set { if (OnPropertyChanging("DataIncrementNode." + nameof(Max), this, m_Max, value)) m_Max = value; } } // 0x1C (28)
		
		protected float m_Min = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(193446607)]
		public float Min { get { return m_Min; } set { if (OnPropertyChanging("DataIncrementNode." + nameof(Min), this, m_Min, value)) m_Min = value; } } // 0x20 (32)
		
		protected float m_IncrementSize = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(834119169)]
		public float IncrementSize { get { return m_IncrementSize; } set { if (OnPropertyChanging("DataIncrementNode." + nameof(IncrementSize), this, m_IncrementSize, value)) m_IncrementSize = value; } } // 0x24 (36)
		
		protected UIDataSourceInfo m_DataSource = new UIDataSourceInfo();
		[ContainerField(40), MemberInfoFlag(41), ContainerFieldNameHash(3810860200)]
		public UIDataSourceInfo DataSource { get { return m_DataSource; } set { if (OnPropertyChanging("DataIncrementNode." + nameof(DataSource), this, m_DataSource, value)) m_DataSource = value; } } // 0x28 (40)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862146:
					In = (CtrRef<UINodePort>) p_Value;
					break;

				case 193453899:
					Out = (CtrRef<UINodePort>) p_Value;
					break;

				case 193446865:
					Max = (float) p_Value;
					break;

				case 193446607:
					Min = (float) p_Value;
					break;

				case 834119169:
					IncrementSize = (float) p_Value;
					break;

				case 3810860200:
					DataSource = (UIDataSourceInfo) p_Value;
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
				case 5862146:
					return In;

				case 193453899:
					return Out;

				case 193446865:
					return Max;

				case 193446607:
					return Min;

				case 834119169:
					return IncrementSize;

				case 3810860200:
					return DataSource;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862146:
					return typeof(DataIncrementNode).GetProperty(nameof(In));

				case 193453899:
					return typeof(DataIncrementNode).GetProperty(nameof(Out));

				case 193446865:
					return typeof(DataIncrementNode).GetProperty(nameof(Max));

				case 193446607:
					return typeof(DataIncrementNode).GetProperty(nameof(Min));

				case 834119169:
					return typeof(DataIncrementNode).GetProperty(nameof(IncrementSize));

				case 3810860200:
					return typeof(DataIncrementNode).GetProperty(nameof(DataSource));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
