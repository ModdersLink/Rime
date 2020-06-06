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
	public class UINodeConnection : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<UINodeData> SourceNode { get; set; } = new CtrRef<UINodeData>(); // 0x8 (8)
		
		[ContainerField(12)]
		public CtrRef<UINodeData> TargetNode { get; set; } = new CtrRef<UINodeData>(); // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<UINodePort> SourcePort { get; set; } = new CtrRef<UINodePort>(); // 0x10 (16)
		
		[ContainerField(20)]
		public CtrRef<UINodePort> TargetPort { get; set; } = new CtrRef<UINodePort>(); // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public int NumScreensToPop { get; set; } // 0x18 (24)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1522571896:
					SourceNode = (CtrRef<UINodeData>) p_Value;
					break;

				case 328873140:
					TargetNode = (CtrRef<UINodeData>) p_Value;
					break;

				case 1521925345:
					SourcePort = (CtrRef<UINodePort>) p_Value;
					break;

				case 328235565:
					TargetPort = (CtrRef<UINodePort>) p_Value;
					break;

				case 1254751512:
					NumScreensToPop = (int) p_Value;
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
				case 1522571896:
					return SourceNode;

				case 328873140:
					return TargetNode;

				case 1521925345:
					return SourcePort;

				case 328235565:
					return TargetPort;

				case 1254751512:
					return NumScreensToPop;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1522571896:
					return typeof(UINodeConnection).GetProperty(nameof(SourceNode));

				case 328873140:
					return typeof(UINodeConnection).GetProperty(nameof(TargetNode));

				case 1521925345:
					return typeof(UINodeConnection).GetProperty(nameof(SourcePort));

				case 328235565:
					return typeof(UINodeConnection).GetProperty(nameof(TargetPort));

				case 1254751512:
					return typeof(UINodeConnection).GetProperty(nameof(NumScreensToPop));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
