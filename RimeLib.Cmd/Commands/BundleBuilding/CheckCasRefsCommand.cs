using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Answers 'can the INLINE bloat be CAS-referenced?': for every item in this bundle whose picked variant is NOT a catalog reference (Cas=false, e.g. idata entries of cas bundles — the mounter prefers idata over the catalog), checks whether its SHA1 payload EXISTS in the game's cas.cat. INLINE-IN-CATALOG items could be written as pure SHA1 references (InlineData=null) instead of embedded bytes -> tiny bundle + byte-exact original data. Also checks whether ANY other mounted variant of the item is catalog-backed (SWAPPABLE). Run AFTER resolve. No args.")]
    internal class CheckCasRefsCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = p_Context as BundleBuildingContext;
            if (s_Ctx == null)
            {
                p_Writer.WriteLine("check_casrefs must run inside a bundle-building context.");
                return false;
            }

            var s_SbCtx = (SbBuildingContext)s_Ctx.Parent!;
            var s_BaseCtx = (BaseContext)s_SbCtx.Parent!;
            var s_Mounter = s_BaseCtx.GetMounters().Values.FirstOrDefault() as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter;
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("check_casrefs: no Frostbite2_0 mounter found.");
                return false;
            }

            long s_CasBytes = 0, s_RefBytes = 0, s_SwapBytes = 0, s_ShipBytes = 0, s_NoShaBytes = 0, s_SbLevelBytes = 0;
            int s_Cas = 0, s_Ref = 0, s_Swap = 0, s_Ship = 0, s_NoSha = 0, s_SbLevel = 0;
            var s_ShipExamples = new List<string>();
            var s_RefExamples = new List<string>();
            var s_SbLevelBySb = new Dictionary<string, (int Count, long Bytes)>();
            var s_ShipBySb = new Dictionary<string, (int Count, long Bytes)>();

            void Tally(string p_Kind, string p_Name, object p_Obj, System.Func<IEnumerable<IObjectVariant>?> p_AltVariants)
            {
                long s_Size = 0;
                if (p_Obj is IReadableObject s_RO) { try { s_Size = s_RO.GetSize(); } catch { } }

                if (p_Obj is not IObjectVariant s_V)
                {
                    // generated/file-backed (add_dds / add_json / replace_resource) -> inherently inline
                    s_NoSha++; s_NoShaBytes += s_Size;
                    return;
                }
                if (s_V.Cas)
                {
                    s_Cas++; s_CasBytes += s_Size;
                    return;
                }

                Sha1? s_Hash = null;
                try { s_Hash = s_V.GetSha1(); } catch { }
                if (s_Hash != null && s_Mounter.CatalogContainsEntry(s_Hash))
                {
                    s_Ref++; s_RefBytes += s_Size;
                    if (s_RefExamples.Count < 8) s_RefExamples.Add($"{p_Kind} {p_Name} ({s_Size / 1024} KB)");
                    return;
                }

                // picked variant not in catalog: is ANY other mounted variant catalog-backed?
                var s_Alts = p_AltVariants();
                if (s_Alts != null)
                {
                    foreach (var s_Alt in s_Alts)
                    {
                        Sha1? s_AltHash = null;
                        try { s_AltHash = s_Alt.GetSha1(); } catch { }
                        if (s_Alt.Cas || (s_AltHash != null && s_Mounter.CatalogContainsEntry(s_AltHash)))
                        {
                            s_Swap++; s_SwapBytes += s_Size;
                            return;
                        }
                    }
                }

                // SB-LEVEL chunk (contained bundle == null): it lives in a superbundle's toc chunk
                // section, fetchable by GUID at runtime WITHOUT loading any bundle — once that
                // superbundle is mounted (win32/loc/* always is; a source level sb can be
                // MountSuperBundle'd cheaply). These do NOT need shipping at all.
                var s_Sb = s_V.GetContainedSuperbundle();
                if (s_V.GetContainedBundle() == null)
                {
                    s_SbLevel++; s_SbLevelBytes += s_Size;
                    var s_T = s_SbLevelBySb.TryGetValue(s_Sb, out var s_Cur) ? s_Cur : (0, 0L);
                    s_SbLevelBySb[s_Sb] = (s_T.Item1 + 1, s_T.Item2 + s_Size);
                    return;
                }

                s_Ship++; s_ShipBytes += s_Size;
                var s_T2 = s_ShipBySb.TryGetValue(s_Sb, out var s_Cur2) ? s_Cur2 : (0, 0L);
                s_ShipBySb[s_Sb] = (s_T2.Item1 + 1, s_T2.Item2 + s_Size);
                if (s_ShipExamples.Count < 12)
                {
                    // provenance of EVERY mounted variant, so we can see WHERE this payload lives in the
                    // game (noncas DLC bundle? base sb chunk? etc.) and whether any form is referenceable.
                    var s_Prov = "";
                    var s_All = p_AltVariants();
                    if (s_All != null)
                        foreach (var s_A in s_All)
                        {
                            Sha1? s_H2 = null; try { s_H2 = s_A.GetSha1(); } catch { }
                            s_Prov += $"\n        variant sb={s_A.GetContainedSuperbundle()} bundle={s_A.GetContainedBundle() ?? "-"} cas={s_A.Cas} sha1={(s_H2 == null ? "none" : "yes" + (s_Mounter.CatalogContainsEntry(s_H2) ? "+incat" : ""))}";
                        }
                    s_ShipExamples.Add($"{p_Kind} {p_Name} ({s_Size / 1024} KB, sha1={(s_Hash == null ? "none" : s_Hash.ToString())}){s_Prov}");
                }
            }

            foreach (var s_Kv in s_Ctx.GetChunks())
            {
                var s_Id = s_Kv.Key;
                Tally("chunk", s_Id.ToString(), s_Kv.Value,
                    () => s_Mounter.TryGetChunk(s_Id, out var s_Obj) ? s_Obj!.Variants : null);
            }
            foreach (var s_Kv in s_Ctx.GetResources())
            {
                var s_Name = s_Kv.Key;
                Tally("res", s_Name, s_Kv.Value,
                    () => s_Mounter.TryGetResource(s_Name, out var s_Obj) ? s_Obj!.Variants : null);
            }
            foreach (var s_Kv in s_Ctx.GetPartitions())
            {
                var s_Name = s_Kv.Key;
                Tally("ebx", s_Name, s_Kv.Value,
                    () => s_Mounter.TryGetPartition(s_Name, out var s_Obj) ? s_Obj!.Variants : null);
            }

            p_Writer.WriteLine($"check_casrefs: CATALOG-REF(already) = {s_Cas} / {s_CasBytes / 1024 / 1024} MB");
            p_Writer.WriteLine($"  INLINE-IN-CATALOG (referenceable! InlineData=null would work) = {s_Ref} / {s_RefBytes / 1024 / 1024} MB");
            p_Writer.WriteLine($"  INLINE-SWAPPABLE  (another variant is catalog-backed)         = {s_Swap} / {s_SwapBytes / 1024 / 1024} MB");
            p_Writer.WriteLine($"  SB-LEVEL-CHUNK    (toc chunk; runtime-fetchable once its sb is mounted -> DON'T ship) = {s_SbLevel} / {s_SbLevelBytes / 1024 / 1024} MB");
            p_Writer.WriteLine($"  INLINE-MUST-SHIP  (bundle-inline payload, not in any catalog) = {s_Ship} / {s_ShipBytes / 1024 / 1024} MB");
            p_Writer.WriteLine($"  GENERATED/NO-SHA1 (add_dds/add_json/replace -> inline)        = {s_NoSha} / {s_NoShaBytes / 1024 / 1024} MB");
            foreach (var s_Kv2 in s_SbLevelBySb.OrderByDescending(p_K => p_K.Value.Bytes))
                p_Writer.WriteLine($"    SBLEVEL-BY-SB {s_Kv2.Key}: {s_Kv2.Value.Count} chunks / {s_Kv2.Value.Bytes / 1024 / 1024} MB");
            foreach (var s_Kv2 in s_ShipBySb.OrderByDescending(p_K => p_K.Value.Bytes))
                p_Writer.WriteLine($"    SHIP-BY-SB    {s_Kv2.Key}: {s_Kv2.Value.Count} items / {s_Kv2.Value.Bytes / 1024 / 1024} MB");
            foreach (var s_Ex in s_RefExamples) p_Writer.WriteLine($"    REF-EXAMPLE  {s_Ex}");
            foreach (var s_Ex in s_ShipExamples) p_Writer.WriteLine($"    SHIP-EXAMPLE {s_Ex}");
            return true;
        }
    }
}
