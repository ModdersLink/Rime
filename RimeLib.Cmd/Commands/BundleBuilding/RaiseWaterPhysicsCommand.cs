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
    [CommandDescription("Rigidly raises/lowers a water HavokPhysicsData resource by a Y delta. Shifts the collision mesh vertices, the hkpMoppCode m_info.offset, and the shape AABB centre all by the same delta, in BOTH the 32- and 64-bit Havok instances. The MOPP tree is in relative coordinates, so it stays valid with NO recompile -- this is a pure byte transform of the existing resource (reverse-engineered Frostbite/Havok-2010 packfile layout; no Havok SDK/code). Keeps the original resource type/meta/id; use it in a same-name clone like replace_resource.")]
    internal class RaiseWaterPhysicsCommand : Command
    {
        [CommandArgument(Description = "The name of the HavokPhysicsData (.water.mesh) resource to raise (must exist in a mounted game).")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        [CommandArgument(Description = "How much to add to the water's Y (e.g. 23 to raise from 67 to 90; negative to lower).")]
        public float DeltaY { get; set; }

        [CommandArgument(Description = "Optional: publish the raised resource under a DIFFERENT name (like replace_resource_as), keeping the original's type/meta. Use this with add_raw_partition of a fresh WaterAsset + a runtime WaterEntityData.asset redirect to move the GLOBAL water (vehicle buoyancy / level reconciliation), not just the soldier swim. Omit to replace in place.", Optional = true)]
        public string? NewName { get; set; }

        [CommandArgument(Description = "Optional: on a COMBINED Havok that serves several water bodies at different Ys (e.g. one ocean + many pools share one MOPP), do NOT shift the global hkpMoppCode m_info.offset (which would orphan the other bodies' broad-phase and kill their swim). Only the targeted body's vertex run + its AABB are raised. Set true for ocean-only raises on multi-body maps; leave false for a single-body water.", Optional = true)]
        public bool KeepMoppOffset { get; set; } = false;

        // Serves the raised bytes from memory, keeping the original variant's type/meta (and an
        // optional new name for the resource id).
        private class RawResource : IResourceObject
        {
            private readonly IResourceVariant m_Original;
            private readonly byte[] m_Data;
            private readonly string? m_Name;
            public RawResource(IResourceVariant p_Original, byte[] p_Data, string? p_Name = null) { m_Original = p_Original; m_Data = p_Data; m_Name = p_Name; }
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

            // Accept any bundle-contained variant (inline or catalog) so DLC resources, which are
            // often non-cas-only, work in a cas build too.
            IResourceVariant? s_Variant = s_Resource.Variants.FirstOrDefault(p_R => p_R.GetContainedBundle() != null);
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
                               (s_OutName == Name ? "." : $" -> published as '{s_OutName}'."));
            return true;
        }

        // ---- HavokPhysicsData rigid Y translate (in-place; same size) -------------------------
        // Mirrors the validated water-RE recipe: each .hkx instance has a flat collision mesh
        // (vertices = Vec4 with w==0, all at the water Y), an hkpMoppCode whose m_info.offset is
        // the MOPP coordinate origin, and a shape AABB. Raising = add delta to the verts' Y, the
        // m_info.offset.y and the AABB centre.y. The MOPP bytecode is untouched (relative coords).

        private static int I32(byte[] d, int o) => BitConverter.ToInt32(d, o);
        private static uint U32(byte[] d, int o) => BitConverter.ToUInt32(d, o);
        private static float F32(byte[] d, int o) => BitConverter.ToSingle(d, o);
        private static void SetF(byte[] d, int o, float v) => BitConverter.GetBytes(v).CopyTo(d, o);

        private static string CString(byte[] d, int o, int max)
        {
            int e = o;
            while (e < o + max && e < d.Length && d[e] != 0) e++;
            return Encoding.ASCII.GetString(d, o, e - o);
        }

        public static void RaiseHavokY(byte[] d, float dy, bool keepMoppOffset, TextWriter log)
        {
            // Locate the two .hkx instances by the Havok packfile magic.
            var s_Instances = new List<int>();
            for (int o = 0; o + 8 <= d.Length; o += 4)
                if (U32(d, o) == 0x57e0e057 && U32(d, o + 4) == 0x10c0c010)
                    s_Instances.Add(o);
            if (s_Instances.Count == 0)
                throw new Exception("no Havok .hkx instance found (not a HavokPhysicsData?)");

            foreach (var s_Inst in s_Instances)
                RaiseInstance(d, s_Inst, dy, keepMoppOffset, log);
        }

        private static void RaiseInstance(byte[] d, int inst, float dy, bool keepMoppOffset, TextWriter log)
        {
            int s_PtrSize = d[inst + 16]; // packfile layout: byte 0 = pointer size (4 or 8)
            int s_NumSec = I32(d, inst + 20);

            int s_DataHdr = -1, s_CnHdr = -1;
            int so = inst + 64;
            for (int s = 0; s < s_NumSec; s++, so += 48)
            {
                var s_Tag = CString(d, so, 19);
                if (s_Tag == "__data__") s_DataHdr = so;
                else if (s_Tag == "__classnames__") s_CnHdr = so;
            }
            if (s_DataHdr < 0 || s_CnHdr < 0) throw new Exception("missing __data__/__classnames__ section");

            int s_DA = inst + I32(d, s_DataHdr + 20);
            int s_DataEnd = s_DA + I32(d, s_DataHdr + 44);
            int s_Virt = s_DA + I32(d, s_DataHdr + 32);
            int s_Exp = s_DA + I32(d, s_DataHdr + 36);
            int s_CnA = inst + I32(d, s_CnHdr + 20);

            // Objects: virtual fixups (dataOff -> class name).
            var s_Objs = new List<(int Off, string Name)>();
            for (int vo = s_Virt; vo + 12 <= s_Exp;)
            {
                int s_Src = I32(d, vo);
                if (s_Src < 0) break;
                s_Objs.Add((s_Src, CString(d, s_CnA + I32(d, vo + 8), 64)));
                vo += 12;
            }

            // 1) MOPP m_info.offset (origin) -- 16 bytes before the hkpMoppCode m_data hkArray size
            //    field. m_info = offset.xyz + scale.w; offset.y is the water level we anchor on.
            int s_MinfoOff = -1;
            for (int i = 0; i < s_Objs.Count; i++)
            {
                if (s_Objs[i].Name != "hkpMoppCode") continue;
                int s_Lo = s_DA + s_Objs[i].Off;
                int s_Hi = s_DA + (i + 1 < s_Objs.Count ? s_Objs[i + 1].Off : s_Objs[i].Off + 256);
                for (int r = s_Lo; r + 8 <= s_Hi && r + 8 <= d.Length; r += 4)
                {
                    uint s_Sz = U32(d, r), s_Cap = U32(d, r + 4);
                    if (s_Sz > 0 && s_Sz < 70000 && s_Cap == (0x80000000u | s_Sz))
                    { s_MinfoOff = r - s_PtrSize - 16; break; }
                }
                if (s_MinfoOff >= 0) break;
            }
            if (s_MinfoOff < 0) throw new Exception("could not locate the hkpMoppCode m_info (not a MOPP water mesh?)");
            float s_WaterY = F32(d, s_MinfoOff + 4);

            // 2) Vertex run: the longest run of consecutive 16-aligned Vec4 (w~0) whose Y is at the
            //    water level. Anchoring on s_WaterY avoids misaligned/zero false positives.
            int s_VbStart = -1, s_VbCount = 0;
            for (int r = s_DA; r + 16 <= s_DataEnd; r += 4)
            {
                if (!IsVertex(d, r, out float s_Y0) || System.Math.Abs(s_Y0 - s_WaterY) > 2f) continue;
                int s_Count = 1;
                for (int n = r + 16; n + 16 <= s_DataEnd; n += 16)
                {
                    if (!IsVertex(d, n, out float s_Yn) || System.Math.Abs(s_Yn - s_Y0) > 1e-2f) break;
                    s_Count++;
                }
                if (s_Count > s_VbCount) { s_VbCount = s_Count; s_VbStart = r; }
            }
            if (s_VbStart < 0) throw new Exception("could not locate the water vertex run at the MOPP level");

            // 3) AABB: a (halfExtents, centre) Vec4 pair where half has big X/Z (flat box) and the
            //    centre.y is at the water level.
            int s_AabbCentreY = -1;
            for (int r = s_DA + 16; r + 16 <= s_DataEnd; r += 4)
            {
                float hx = F32(d, r - 16), hy = F32(d, r - 12), hz = F32(d, r - 8);
                float cy = F32(d, r + 4);
                if (hx > 50f && hz > 50f && hy >= 0f && hy < 50f && System.Math.Abs(cy - s_WaterY) < 5f)
                { s_AabbCentreY = r + 4; break; }
            }

            // Apply the shifts (verts.y, m_info.offset.y, AABB centre.y) by the same delta.
            // On a combined multi-body Havok, KeepMoppOffset leaves the GLOBAL m_info.offset alone
            // (shifting it would orphan the other bodies' broad-phase) and raises only this body's
            // vertex run + its (body-local) AABB.
            for (int k = 0; k < s_VbCount; k++)
                SetF(d, s_VbStart + k * 16 + 4, F32(d, s_VbStart + k * 16 + 4) + dy);
            if (!keepMoppOffset)
                SetF(d, s_MinfoOff + 4, F32(d, s_MinfoOff + 4) + dy);
            if (s_AabbCentreY >= 0)
                SetF(d, s_AabbCentreY, F32(d, s_AabbCentreY) + dy);

            log.WriteLine($"  inst@{inst} (ptr{s_PtrSize}): waterY={s_WaterY:0.##} verts={s_VbCount} " +
                          $"mInfo={(keepMoppOffset ? "kept" : "ok")} aabb={(s_AabbCentreY >= 0 ? "ok" : "NOT FOUND")}");
        }

        private static bool IsVertex(byte[] d, int o, out float y)
        {
            y = 0f;
            if (o + 16 > d.Length) return false;
            float x = F32(d, o), yy = F32(d, o + 4), z = F32(d, o + 8), w = F32(d, o + 12);
            if (System.Math.Abs(w) > 1e-3f) return false;
            if (!(System.Math.Abs(x) < 1e5f && System.Math.Abs(z) < 1e5f && System.Math.Abs(yy) < 1e5f)) return false;
            // reject all-zero padding runs
            if (x == 0f && yy == 0f && z == 0f) return false;
            y = yy;
            return true;
        }
    }
}
