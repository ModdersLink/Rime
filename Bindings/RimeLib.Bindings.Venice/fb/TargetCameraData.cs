///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class TargetCameraData : 
		CameraData
	{
		[ContainerField(80)]
		public HudData Hud { get; set; } = new HudData(); // 0x50 (80)
		
		[ContainerField(148)]
		public RefArray<UIPartData> UIParts { get; set; } = new RefArray<UIPartData>(); // 0x94 (148)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193458844:
					Hud = (HudData) p_Value;
					break;

				case 187481405:
					UIParts = (RefArray<UIPartData>) p_Value;
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
				case 193458844:
					return Hud;

				case 187481405:
					return UIParts;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193458844:
					return typeof(TargetCameraData).GetProperty(nameof(Hud));

				case 187481405:
					return typeof(TargetCameraData).GetProperty(nameof(UIParts));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
