using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Reads the cookie (16-byte meta) of every mounted resource of a type the engine has a cookie struct for, and reports per type whether its sizes add up to the payload and whether it writes back unchanged.")]
    public class CheckResourceCookiesCommand : Command
    {
        private sealed class Tally
        {
            public int Resources, Empty, SizesMatch, WritesBack;
            public List<string> Mismatches { get; } = new();
        }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Game = (GameContext)p_Context;
            var s_Cookies = ResourceTypeProviders.ByType<IResourceCookies>(s_Game.GetMounter().GetEngineType(), p_P => p_P.Types);

            var s_Tallies = new SortedDictionary<string, Tally>(StringComparer.Ordinal);
            foreach (var (s_Name, s_Resource) in s_Game.GetMountedResourceVariations())
            {
                var s_Variant = s_Resource.FirstVariant;
                if (!s_Cookies.TryGetValue(s_Variant.GetResourceType(), out var s_Provider))
                    continue;

                var s_Type = s_Variant.GetResourceType().ToString();
                if (!s_Tallies.TryGetValue(s_Type, out var s_Tally))
                    s_Tallies[s_Type] = s_Tally = new Tally();
                s_Tally.Resources++;

                // Engines that keep these sizes in the payload leave the meta empty.
                if (!s_Variant.TryGetMeta(out var s_Meta) || s_Meta.All(p_B => p_B == 0))
                {
                    s_Tally.Empty++;
                    continue;
                }

                using var s_Reader = s_Variant.GetReader();
                var s_Payload = new MemoryStream();
                s_Reader.CopyTo(s_Payload);

                var s_Cookie = s_Provider.Read(s_Variant.GetResourceType(), s_Meta);
                if (s_Cookie.PayloadSize == s_Payload.Length)
                    s_Tally.SizesMatch++;
                else if (s_Tally.Mismatches.Count < 3)
                    s_Tally.Mismatches.Add($"{s_Name}: cookie says {s_Cookie.PayloadSize} bytes, payload is {s_Payload.Length}");

                if (s_Cookie.ToArray().AsSpan().SequenceEqual(s_Meta))
                    s_Tally.WritesBack++;
            }

            foreach (var (s_Type, s_Tally) in s_Tallies)
            {
                var s_WithCookie = s_Tally.Resources - s_Tally.Empty;
                p_Writer.WriteLine(s_WithCookie == 0
                    ? $"{s_Type,-26} {s_Tally.Resources,6} resource(s), all without a cookie"
                    : $"{s_Type,-26} {s_Tally.Resources,6} resource(s): sizes match {s_Tally.SizesMatch} of {s_WithCookie}, written back unchanged {s_Tally.WritesBack} of {s_WithCookie}{(s_Tally.Empty > 0 ? $", {s_Tally.Empty} without a cookie" : "")}");
                foreach (var s_Line in s_Tally.Mismatches)
                    p_Writer.WriteLine($"  {s_Line}");
            }

            return true;
        }
    }
}
