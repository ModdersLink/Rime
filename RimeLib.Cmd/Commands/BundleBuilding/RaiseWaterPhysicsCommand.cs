using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Raises or lowers a water HavokPhysicsData by a Y delta, shifting its vertices, MOPP origin and AABB together. The MOPP tree is relative, so it needs no recompile.")]
    internal class RaiseWaterPhysicsCommand : Command
    {
        // Both the 32- and 64-bit Havok instances are shifted. The result keeps the original
        // resource's type, meta and id, so publish it in a same-name clone the way replace_resource
        // does, or under a new name with NewName.
        [CommandArgument(Description = "The HavokPhysicsData (.water.mesh) resource to move. Must exist in a mounted game.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        [CommandArgument(Description = "How much to add to the water's Y (e.g. 23 to raise from 67 to 90; negative to lower).")]
        public float DeltaY { get; set; }

        [CommandArgument(Description = "Publish under a different name, keeping the original's type and meta. Omit to replace in place.", Optional = true)]
        public string? NewName { get; set; }

        [CommandArgument(Description = "Leave the shared MOPP origin alone and move only this body. Set it when one Havok serves water bodies at different heights.", Optional = true)]
        public bool KeepMoppOffset { get; set; } = false;

        // Serves the raised bytes from memory, keeping the original variant's type and meta.
        private class RawResource : IResourceObject
        {
            private readonly IResourceVariant m_Original;
            private readonly byte[] m_Data;
            private readonly string? m_Name;

            public RawResource(IResourceVariant p_Original, byte[] p_Data, string? p_Name = null)
            {
                m_Original = p_Original;
                m_Data = p_Data;
                m_Name = p_Name;
            }

            public ResourceType GetResourceType() => m_Original.GetResourceType();

            public bool TryGetMeta([NotNullWhen(true)] out byte[]? p_Meta) => m_Original.TryGetMeta(out p_Meta);

            public ResourceRef GetId(string? p_Name = null)
            {
                try { return m_Original.GetId(p_Name ?? m_Name); }
                catch { return new ResourceRef(p_Name ?? m_Name ?? string.Empty, this); }
            }

            public RimeReader GetReader() => new RimeReader(new MemoryStream(m_Data, false));

            public long GetSize() => m_Data.Length;
        }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("The specified resource could not be found.");
                return false;
            }

            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbBuildingContext = (SbBuildingContext?)s_BundleContext.Parent;
            var s_BaseContext = s_SbBuildingContext?.Parent as BaseContext;
            if (s_SbBuildingContext == null || s_BaseContext == null)
            {
                p_Writer.WriteLine("Context is invalid.");
                return false;
            }

            if (!s_BaseContext.GetMounters().TryGetValue(Id, out var s_EngineMounter))
            {
                p_Writer.WriteLine($"Id ({Id}) is not valid, ensure you mounted a game first");
                return false;
            }

            if (!s_EngineMounter.TryGetResource(Name!, out var s_Resource))
            {
                p_Writer.WriteLine($"Could not find resource ({Name}).");
                return false;
            }

            // Accept any bundle-contained variant, inline or catalog, so the often non-cas-only DLC
            // resources work in a cas build too.
            var s_Variant = s_Resource.Variants.FirstOrDefault(p_R => p_R.GetContainedBundle() != null);
            if (s_Variant == null)
            {
                p_Writer.Write($"Could not find a valid variant of ({Name}).");
                return false;
            }

            byte[] s_Bytes;
            using (var s_Reader = s_Variant.GetReader())
                s_Bytes = s_Reader.ReadBytes((int)s_Reader.Length);

            try
            {
                RaiseHavokY(s_Bytes, DeltaY, KeepMoppOffset, p_Writer);
            }
            catch (Exception s_Ex)
            {
                p_Writer.WriteLine($"Failed to raise the Havok water: {s_Ex.Message}");
                return false;
            }

            var s_OutName = string.IsNullOrWhiteSpace(NewName) ? Name! : NewName!;
            s_BundleContext.AddResource(s_OutName, new RawResource(s_Variant, s_Bytes, s_OutName));
            p_Writer.WriteLine($"Raised '{Name}' water physics by Y {DeltaY:+0.##;-0.##}" +
                               (s_OutName == Name ? "." : $", published as '{s_OutName}'."));
            return true;
        }

        private static int I32(byte[] p_Data, int p_Offset) => BitConverter.ToInt32(p_Data, p_Offset);

        private static uint U32(byte[] p_Data, int p_Offset) => BitConverter.ToUInt32(p_Data, p_Offset);

        private static float F32(byte[] p_Data, int p_Offset) => BitConverter.ToSingle(p_Data, p_Offset);

        private static void SetF32(byte[] p_Data, int p_Offset, float p_Value) => BitConverter.GetBytes(p_Value).CopyTo(p_Data, p_Offset);

        private static string CString(byte[] p_Data, int p_Offset, int p_Max)
        {
            var s_End = p_Offset;
            while (s_End < p_Offset + p_Max && s_End < p_Data.Length && p_Data[s_End] != 0)
                s_End++;
            return Encoding.ASCII.GetString(p_Data, p_Offset, s_End - p_Offset);
        }

        public static void RaiseHavokY(byte[] p_Data, float p_DeltaY, bool p_KeepMoppOffset, TextWriter p_Writer)
        {
            // Locate the .hkx instances by the Havok packfile magic.
            var s_Instances = new List<int>();
            for (var s_Offset = 0; s_Offset + 8 <= p_Data.Length; s_Offset += 4)
                if (U32(p_Data, s_Offset) == 0x57e0e057 && U32(p_Data, s_Offset + 4) == 0x10c0c010)
                    s_Instances.Add(s_Offset);

            if (s_Instances.Count == 0)
                throw new Exception("no Havok .hkx instance found (not a HavokPhysicsData?)");

            foreach (var s_Instance in s_Instances)
                RaiseInstance(p_Data, s_Instance, p_DeltaY, p_KeepMoppOffset, p_Writer);
        }

        private static void RaiseInstance(byte[] p_Data, int p_Instance, float p_DeltaY, bool p_KeepMoppOffset, TextWriter p_Writer)
        {
            var s_PtrSize = p_Data[p_Instance + 16];
            var s_NumSections = I32(p_Data, p_Instance + 20);

            int s_DataHdr = -1, s_ClassNamesHdr = -1;
            var s_SectionOffset = p_Instance + 64;
            for (var s_Section = 0; s_Section < s_NumSections; s_Section++, s_SectionOffset += 48)
            {
                var s_Tag = CString(p_Data, s_SectionOffset, 19);
                if (s_Tag == "__data__") s_DataHdr = s_SectionOffset;
                else if (s_Tag == "__classnames__") s_ClassNamesHdr = s_SectionOffset;
            }

            if (s_DataHdr < 0 || s_ClassNamesHdr < 0)
                throw new Exception("missing __data__/__classnames__ section");

            var s_DataStart = p_Instance + I32(p_Data, s_DataHdr + 20);
            var s_DataEnd = s_DataStart + I32(p_Data, s_DataHdr + 44);
            var s_VirtualFixups = s_DataStart + I32(p_Data, s_DataHdr + 32);
            var s_ExportFixups = s_DataStart + I32(p_Data, s_DataHdr + 36);
            var s_ClassNames = p_Instance + I32(p_Data, s_ClassNamesHdr + 20);

            // The virtual fixups map each object's data offset to its class name.
            var s_Objects = new List<(int Offset, string Name)>();
            for (var s_Fixup = s_VirtualFixups; s_Fixup + 12 <= s_ExportFixups;)
            {
                var s_Src = I32(p_Data, s_Fixup);
                if (s_Src < 0) break;
                s_Objects.Add((s_Src, CString(p_Data, s_ClassNames + I32(p_Data, s_Fixup + 8), 64)));
                s_Fixup += 12;
            }

            // m_info is the MOPP coordinate origin (offset.xyz plus scale.w) and sits 16 bytes before
            // the hkpMoppCode m_data hkArray size field. Its Y is the water level we anchor everything on.
            var s_MoppInfoOffset = -1;
            for (var i = 0; i < s_Objects.Count; i++)
            {
                if (s_Objects[i].Name != "hkpMoppCode") continue;

                var s_Lo = s_DataStart + s_Objects[i].Offset;
                var s_Hi = s_DataStart + (i + 1 < s_Objects.Count ? s_Objects[i + 1].Offset : s_Objects[i].Offset + 256);
                for (var s_Cursor = s_Lo; s_Cursor + 8 <= s_Hi && s_Cursor + 8 <= p_Data.Length; s_Cursor += 4)
                {
                    uint s_Size = U32(p_Data, s_Cursor), s_Capacity = U32(p_Data, s_Cursor + 4);
                    if (s_Size > 0 && s_Size < 70000 && s_Capacity == (0x80000000u | s_Size))
                    {
                        s_MoppInfoOffset = s_Cursor - s_PtrSize - 16;
                        break;
                    }
                }

                if (s_MoppInfoOffset >= 0) break;
            }

            if (s_MoppInfoOffset < 0)
                throw new Exception("could not locate the hkpMoppCode m_info (not a MOPP water mesh?)");

            var s_WaterY = F32(p_Data, s_MoppInfoOffset + 4);

            // The vertices are the longest run of consecutive 16-aligned Vec4 with w == 0 sitting at the
            // water level. Anchoring on the water Y keeps misaligned and zeroed runs out.
            int s_VertsStart = -1, s_VertsCount = 0;
            for (var s_Cursor = s_DataStart; s_Cursor + 16 <= s_DataEnd; s_Cursor += 4)
            {
                if (!IsVertex(p_Data, s_Cursor, out var s_Y0) || System.Math.Abs(s_Y0 - s_WaterY) > 2f) continue;

                var s_Count = 1;
                for (var s_Next = s_Cursor + 16; s_Next + 16 <= s_DataEnd; s_Next += 16)
                {
                    if (!IsVertex(p_Data, s_Next, out var s_Yn) || System.Math.Abs(s_Yn - s_Y0) > 1e-2f) break;
                    s_Count++;
                }

                if (s_Count > s_VertsCount)
                {
                    s_VertsCount = s_Count;
                    s_VertsStart = s_Cursor;
                }
            }

            if (s_VertsStart < 0)
                throw new Exception("could not locate the water vertex run at the MOPP level");

            // The AABB is a (halfExtents, centre) Vec4 pair whose half extents describe a flat box and
            // whose centre sits at the water level.
            var s_AabbCentreY = -1;
            for (var s_Cursor = s_DataStart + 16; s_Cursor + 16 <= s_DataEnd; s_Cursor += 4)
            {
                float s_HalfX = F32(p_Data, s_Cursor - 16), s_HalfY = F32(p_Data, s_Cursor - 12), s_HalfZ = F32(p_Data, s_Cursor - 8);
                var s_CentreY = F32(p_Data, s_Cursor + 4);
                if (s_HalfX > 50f && s_HalfZ > 50f && s_HalfY >= 0f && s_HalfY < 50f && System.Math.Abs(s_CentreY - s_WaterY) < 5f)
                {
                    s_AabbCentreY = s_Cursor + 4;
                    break;
                }
            }

            for (var i = 0; i < s_VertsCount; i++)
                SetF32(p_Data, s_VertsStart + i * 16 + 4, F32(p_Data, s_VertsStart + i * 16 + 4) + p_DeltaY);
            if (!p_KeepMoppOffset)
                SetF32(p_Data, s_MoppInfoOffset + 4, F32(p_Data, s_MoppInfoOffset + 4) + p_DeltaY);
            if (s_AabbCentreY >= 0)
                SetF32(p_Data, s_AabbCentreY, F32(p_Data, s_AabbCentreY) + p_DeltaY);

            p_Writer.WriteLine($"  inst@{p_Instance} (ptr{s_PtrSize}): waterY={s_WaterY:0.##} verts={s_VertsCount} " +
                               $"mInfo={(p_KeepMoppOffset ? "kept" : "ok")} aabb={(s_AabbCentreY >= 0 ? "ok" : "NOT FOUND")}");
        }

        private static bool IsVertex(byte[] p_Data, int p_Offset, out float p_Y)
        {
            p_Y = 0f;
            if (p_Offset + 16 > p_Data.Length) return false;

            float s_X = F32(p_Data, p_Offset), s_Y = F32(p_Data, p_Offset + 4), s_Z = F32(p_Data, p_Offset + 8), s_W = F32(p_Data, p_Offset + 12);
            if (System.Math.Abs(s_W) > 1e-3f) return false;
            if (!(System.Math.Abs(s_X) < 1e5f && System.Math.Abs(s_Z) < 1e5f && System.Math.Abs(s_Y) < 1e5f)) return false;
            if (s_X == 0f && s_Y == 0f && s_Z == 0f) return false;

            p_Y = s_Y;
            return true;
        }
    }
}
