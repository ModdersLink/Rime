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
	public class ActionNode : 
		UINodeData
	{
		[ContainerField(20), LayoutImmutable, Blittable]
		public int ActionKey { get; set; } // 0x14 (20)
		
		[ContainerField(24)]
		public List<string> Params { get; set; } = new List<string>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<Asset> ActionAsset { get; set; } = new CtrRef<Asset>(); // 0x1C (28)
		
		[ContainerField(32)]
		public CtrRef<UINodePort> In { get; set; } = new CtrRef<UINodePort>(); // 0x20 (32)
		
		[ContainerField(36)]
		public CtrRef<UINodePort> Out { get; set; } = new CtrRef<UINodePort>(); // 0x24 (36)
		
		[ContainerField(40)]
		public RefArray<UINodePort> DataInputs { get; set; } = new RefArray<UINodePort>(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool AppendIncomingParams { get; set; } // 0x2C (44)
		
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
