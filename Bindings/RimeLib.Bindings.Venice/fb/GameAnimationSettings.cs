///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 72)]
	public class GameAnimationSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float TemporalLoddingFourthDeltaTime { get; set; }

		[ContainerField(16)]
		public List<string> AntOnClientOnlyGamemodes { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float TemporalLoddingFarDistance { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float TemporalLoddingSixthDeltaTime { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float TemporalLoddingFifthDeltaTime { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float TemporalLoddingFirstDeltaTime { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float TemporalLoddingSecondDeltaTime { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float TemporalLoddingThirdDeltaTime { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float TemporalLoddingSixthDistance { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float TemporalLoddingSecondDistance { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float TemporalLoddingFifthDistance { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float TemporalLoddingFirstDistance { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float TemporalLoddingThirdDistance { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float TemporalLoddingFourthDistance { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public bool ServerEnable { get; set; }

		[ContainerField(69), LayoutImmutable, Blittable]
		public bool UseRawGamepadInput { get; set; }

		[ContainerField(70), LayoutImmutable, Blittable]
		public bool ClientEnable { get; set; }

		[ContainerField(71), LayoutImmutable, Blittable]
		public bool UseAnimationDrivenCharacter { get; set; }

		public static void Deserialize(GameAnimationSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TemporalLoddingFourthDeltaTime = p_Reader.ReadSingle();
			p_Instance.AntOnClientOnlyGamemodes.Clear();
			(RimeReader Reader, uint Count) s_AntOnClientOnlyGamemodes = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_AntOnClientOnlyGamemodes.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_AntOnClientOnlyGamemodes.Reader.ReadUInt32());
				p_Instance.AntOnClientOnlyGamemodes.Add(s_Value);
			}
			
			s_AntOnClientOnlyGamemodes.Reader.Dispose();
			p_Instance.TemporalLoddingFarDistance = p_Reader.ReadSingle();
			p_Instance.TemporalLoddingSixthDeltaTime = p_Reader.ReadSingle();
			p_Instance.TemporalLoddingFifthDeltaTime = p_Reader.ReadSingle();
			p_Instance.TemporalLoddingFirstDeltaTime = p_Reader.ReadSingle();
			p_Instance.TemporalLoddingSecondDeltaTime = p_Reader.ReadSingle();
			p_Instance.TemporalLoddingThirdDeltaTime = p_Reader.ReadSingle();
			p_Instance.TemporalLoddingSixthDistance = p_Reader.ReadSingle();
			p_Instance.TemporalLoddingSecondDistance = p_Reader.ReadSingle();
			p_Instance.TemporalLoddingFifthDistance = p_Reader.ReadSingle();
			p_Instance.TemporalLoddingFirstDistance = p_Reader.ReadSingle();
			p_Instance.TemporalLoddingThirdDistance = p_Reader.ReadSingle();
			p_Instance.TemporalLoddingFourthDistance = p_Reader.ReadSingle();
			p_Instance.ServerEnable = p_Reader.ReadBool();
			p_Instance.UseRawGamepadInput = p_Reader.ReadBool();
			p_Instance.ClientEnable = p_Reader.ReadBool();
			p_Instance.UseAnimationDrivenCharacter = p_Reader.ReadBool();
		}

	}
}
