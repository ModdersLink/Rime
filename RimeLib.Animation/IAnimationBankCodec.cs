using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Animation
{
    /// <summary>What an animation bank tool found: a JSON-ready report, the line to print and whether it passed.</summary>
    public sealed class AnimationBankReport
    {
        public bool Succeeded { get; init; }

        public string Message { get; init; } = string.Empty;

        /// <summary>The report to write as JSON, or null when there is none.</summary>
        public object? Report { get; init; }

        /// <summary>An edit file for <see cref="IAnimationBankCodec.Patch"/>, when one was asked for.</summary>
        public object? EditProbe { get; init; }

        /// <summary>The patched bank, for <see cref="IAnimationBankCodec.Patch"/>.</summary>
        public byte[]? Bank { get; init; }
    }

    /// <summary>
    /// Reads, checks and patches the animation banks the game streams for its animation package
    /// partitions.
    /// </summary>
    public interface IAnimationBankCodec : IEngineInterface
    {
        /// <summary>The partitions animation packages live under.</summary>
        string PackagePrefix { get; }

        /// <summary>
        /// The bank of an animation package partition: every object with its type, the numbers a
        /// keyframe exporter needs, the rig and the sets that bind it, and up to
        /// <paramref name="p_Samples"/> decoded frames per clip.
        /// </summary>
        AnimationBankReport DumpBank(IEngineMounter p_Mounter, string p_Partition, int p_Samples);

        /// <summary>
        /// Re-encodes every clip of the banks and compares them with the shipped bytes. With
        /// <paramref name="p_Sweep"/> the report keeps only the clips that fail and a bank that does
        /// not load is counted rather than fatal.
        /// </summary>
        AnimationBankReport CheckCodecs(IEngineMounter p_Mounter, IReadOnlyList<string> p_Partitions, bool p_Sweep, bool p_WithEditProbe);

        /// <summary>Writes the edited clips of an edit file into the bank, in place, and checks it reloads with them.</summary>
        AnimationBankReport Patch(IEngineMounter p_Mounter, string p_Partition, string p_EditsJson, TextWriter p_Log);

        /// <summary>
        /// Hands each bank's undecoded clips, header fields and payload, to <paramref name="p_Bank"/>
        /// with the partition name.
        /// </summary>
        AnimationBankReport DumpCodecClips(IEngineMounter p_Mounter, IReadOnlyList<string> p_Partitions, Action<string, object> p_Bank);

        /// <summary>The names a bank holds (objects, layout slots, joints), or null with the reason when it does not load.</summary>
        IReadOnlyCollection<string>? ReadNames(IEngineMounter p_Mounter, string p_Partition, out long p_Objects, out string? p_Error);
    }
}
