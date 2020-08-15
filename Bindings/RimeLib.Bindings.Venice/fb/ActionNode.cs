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
	[ContainerType(4)]
	public class ActionNode : 
		UINodeData
	{
		protected int m_ActionKey = new int();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(3027240492)]
		public int ActionKey { get { return m_ActionKey; } set { if (OnPropertyChanging("ActionNode." + nameof(ActionKey), this, m_ActionKey, value)) m_ActionKey = value; } } // 0x14 (20)
		
		protected List<string> m_Params = new List<string>();
		[ContainerField(24), ContainerFieldNameHash(3371566681)]
		public List<string> Params { get { return m_Params; } set { if (OnPropertyChanging("ActionNode." + nameof(Params), this, m_Params, value)) m_Params = value; } } // 0x18 (24)
		
		protected CtrRef<Asset> m_ActionAsset = new CtrRef<Asset>();
		[ContainerField(28), ContainerFieldNameHash(2440817227)]
		public CtrRef<Asset> ActionAsset { get { return m_ActionAsset; } set { if (OnPropertyChanging("ActionNode." + nameof(ActionAsset), this, m_ActionAsset, value)) m_ActionAsset = value; } } // 0x1C (28)
		
		protected CtrRef<UINodePort> m_In = new CtrRef<UINodePort>();
		[ContainerField(32), ContainerFieldNameHash(5862146)]
		public CtrRef<UINodePort> In { get { return m_In; } set { if (OnPropertyChanging("ActionNode." + nameof(In), this, m_In, value)) m_In = value; } } // 0x20 (32)
		
		protected CtrRef<UINodePort> m_Out = new CtrRef<UINodePort>();
		[ContainerField(36), ContainerFieldNameHash(193453899)]
		public CtrRef<UINodePort> Out { get { return m_Out; } set { if (OnPropertyChanging("ActionNode." + nameof(Out), this, m_Out, value)) m_Out = value; } } // 0x24 (36)
		
		protected RefArray<UINodePort> m_DataInputs = new RefArray<UINodePort>();
		[ContainerField(40), ContainerFieldNameHash(201610416)]
		public RefArray<UINodePort> DataInputs { get { return m_DataInputs; } set { if (OnPropertyChanging("ActionNode." + nameof(DataInputs), this, m_DataInputs, value)) m_DataInputs = value; } } // 0x28 (40)
		
		protected bool m_AppendIncomingParams = new bool();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(2745114833)]
		public bool AppendIncomingParams { get { return m_AppendIncomingParams; } set { if (OnPropertyChanging("ActionNode." + nameof(AppendIncomingParams), this, m_AppendIncomingParams, value)) m_AppendIncomingParams = value; } } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3027240492:
					ActionKey = (int) p_Value;
					break;

				case 3371566681:
					Params = (List<string>) p_Value;
					break;

				case 2440817227:
					ActionAsset = (CtrRef<Asset>) p_Value;
					break;

				case 5862146:
					In = (CtrRef<UINodePort>) p_Value;
					break;

				case 193453899:
					Out = (CtrRef<UINodePort>) p_Value;
					break;

				case 201610416:
					DataInputs = (RefArray<UINodePort>) p_Value;
					break;

				case 2745114833:
					AppendIncomingParams = (bool) p_Value;
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
				case 3027240492:
					return ActionKey;

				case 3371566681:
					return Params;

				case 2440817227:
					return ActionAsset;

				case 5862146:
					return In;

				case 193453899:
					return Out;

				case 201610416:
					return DataInputs;

				case 2745114833:
					return AppendIncomingParams;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3027240492:
					return typeof(ActionNode).GetProperty(nameof(ActionKey));

				case 3371566681:
					return typeof(ActionNode).GetProperty(nameof(Params));

				case 2440817227:
					return typeof(ActionNode).GetProperty(nameof(ActionAsset));

				case 5862146:
					return typeof(ActionNode).GetProperty(nameof(In));

				case 193453899:
					return typeof(ActionNode).GetProperty(nameof(Out));

				case 201610416:
					return typeof(ActionNode).GetProperty(nameof(DataInputs));

				case 2745114833:
					return typeof(ActionNode).GetProperty(nameof(AppendIncomingParams));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
