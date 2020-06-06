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
	public class StateNode : 
		UINodeData
	{
		[ContainerField(20)]
		public CtrRef<UIScreenAsset> Screen { get; set; } = new CtrRef<UIScreenAsset>(); // 0x14 (20)
		
		[ContainerField(24)]
		public CtrRef<UINodePort> In { get; set; } = new CtrRef<UINodePort>(); // 0x18 (24)
		
		[ContainerField(28)]
		public CtrRef<UINodePort> Show { get; set; } = new CtrRef<UINodePort>(); // 0x1C (28)
		
		[ContainerField(32)]
		public CtrRef<UINodePort> Hide { get; set; } = new CtrRef<UINodePort>(); // 0x20 (32)
		
		[ContainerField(36)]
		public RefArray<UINodePort> Inputs { get; set; } = new RefArray<UINodePort>(); // 0x24 (36)
		
		[ContainerField(40)]
		public RefArray<UINodePort> Outputs { get; set; } = new RefArray<UINodePort>(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public bool RenderToTexture { get; set; } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3334722793:
					Screen = (CtrRef<UIScreenAsset>) p_Value;
					break;

				case 5862146:
					In = (CtrRef<UINodePort>) p_Value;
					break;

				case 2089430886:
					Show = (CtrRef<UINodePort>) p_Value;
					break;

				case 2089152613:
					Hide = (CtrRef<UINodePort>) p_Value;
					break;

				case 2784267136:
					Inputs = (RefArray<UINodePort>) p_Value;
					break;

				case 1070022089:
					Outputs = (RefArray<UINodePort>) p_Value;
					break;

				case 627956363:
					RenderToTexture = (bool) p_Value;
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
				case 3334722793:
					return Screen;

				case 5862146:
					return In;

				case 2089430886:
					return Show;

				case 2089152613:
					return Hide;

				case 2784267136:
					return Inputs;

				case 1070022089:
					return Outputs;

				case 627956363:
					return RenderToTexture;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3334722793:
					return typeof(StateNode).GetProperty(nameof(Screen));

				case 5862146:
					return typeof(StateNode).GetProperty(nameof(In));

				case 2089430886:
					return typeof(StateNode).GetProperty(nameof(Show));

				case 2089152613:
					return typeof(StateNode).GetProperty(nameof(Hide));

				case 2784267136:
					return typeof(StateNode).GetProperty(nameof(Inputs));

				case 1070022089:
					return typeof(StateNode).GetProperty(nameof(Outputs));

				case 627956363:
					return typeof(StateNode).GetProperty(nameof(RenderToTexture));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
