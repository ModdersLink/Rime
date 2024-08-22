using ant;
using RimeLib.Animation.EA.Compression.DCT;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace RimeLib.Animation.Frostbite2_0.EA.Compression.DCT
{
    public class Decompressor
    {
        public static float[,]  c_DctCoeffs = new float[8,8] {
            { 0.250000f, 0.490393f, 0.461940f, 0.415735f, 0.353553f, 0.277785f, 0.191342f, 0.097545f,  },
            { 0.250000f, 0.415735f, 0.191342f, -0.097545f, -0.353553f, -0.490393f, -0.461940f, -0.277785f,  },
            { 0.250000f, 0.277785f, -0.191342f, -0.490393f, -0.353553f, 0.097545f, 0.461940f, 0.415735f,  },
            { 0.250000f, 0.097545f, -0.461940f, -0.277785f, 0.353553f, 0.415735f, -0.191342f, -0.490393f,  },
            { 0.250000f, -0.097545f, -0.461940f, 0.277785f, 0.353553f, -0.415735f, -0.191342f, 0.490393f,  },
            { 0.250000f, -0.277785f, -0.191342f, 0.490393f, -0.353553f, -0.097545f, 0.461940f, -0.415735f,  },
            { 0.250000f, -0.415735f, 0.191342f, 0.097545f, -0.353553f, 0.490393f, -0.461940f, 0.277785f,  },
            { 0.250000f, -0.490393f, 0.461940f, -0.415735f, 0.353554f, -0.277785f, 0.191342f, -0.097545f,  },
        };



        public float[] GenerateCoeffs(DctAnimationAsset p_Dct, ushort p_Frame)
        {
            float[] s_Coeffs = new float[8];

            var s_CoeffIdx = p_Frame % 8;

            for (var i = 0; i < 8; i++)
            {
                var s_Coeff = c_DctCoeffs[s_CoeffIdx, i];
                var s_Multiplier = ((float)p_Dct.QuantizeMultSubblock *0.1f * (float)i + 1.0f)/ (float)p_Dct.QuantizeMultBlock;
                var s_Value  =  s_Coeff*s_Multiplier;

                s_Coeffs[i] = s_Value;
            }


            return s_Coeffs;
        }


        public Vector4 UnpackVec(DctAnimationAsset p_Dct, List<short> p_Values, ushort p_Frame)
        {
            var s_Result = new Vector4(0.0f);

            var s_Coefs = GenerateCoeffs(p_Dct, p_Frame);

            for(var i=0; i < 8; i++)
            {
                var s_Vec = new Vector4(p_Values[i*4 + 0], p_Values[i * 4 + 1], p_Values[i * 4 + 2], p_Values[i * 4 + 3]);

                s_Result += Vector4.Multiply(s_Vec, s_Coefs[i]);
            }

            return s_Result;
        }

        public Vector4 UnpackQuat(DctAnimationAsset p_Dct, List<short> p_Values, ushort p_Frame)
        {
            var s_Vec = UnpackVec(p_Dct, p_Values, p_Frame);
            return Vector4.Normalize(s_Vec);
        }

        public void Parse(DctAnimationAsset p_Dct)
        {

            var s_DofCount = p_Dct.NumVec3 + p_Dct.NumQuats + p_Dct.NumFloatVec;

            var s_DofTable = new DofTable[s_DofCount];

            var s_SubBlockTotal = 0;
            for (var i = 0; i < s_DofCount; i++)
            {
                // 4 bits is unused.
                var s_SubBlocksCount = (byte)((p_Dct.DofTableDescBytes[i] >> 4) & 0xF);

                var s_DofData = new DofTable(s_SubBlocksCount);
                s_DofData.DeltaBase = new short[4]
                {
                    p_Dct.DeltaBaseX[i],
                    p_Dct.DeltaBaseY[i],
                    p_Dct.DeltaBaseZ[i],
                    p_Dct.DeltaBaseW[i],
                };

                s_DofData.BitsPerSubBlock = new DofTable.BitsPerComponent[s_DofData.SubBlockCount];
                for (var j = 0; j < s_DofData.SubBlockCount; j++)
                    s_DofData.BitsPerSubBlock[j] = new DofTable.BitsPerComponent(p_Dct.BitsPerSubblock[s_SubBlockTotal + j]);

                s_DofTable[i] = s_DofData;

                s_SubBlockTotal += s_SubBlocksCount;

            }

   
            var s_BitReader = new BitReader(new MemoryStream(p_Dct.Data.ToArray()), 64, IO.Conversion.Endianness.BigEndian);

            List<List<short>> s_Blocks = new();

            for (var s_BlockFrame = 0; s_BlockFrame < (p_Dct.NumKeys + 7) / 8; s_BlockFrame++)
            {

                foreach (var s_AnimChannel in s_DofTable)
                {
                    List<short> s_Block = new();

                    // first block doesnt have component 0
                    // deltas not needed on first block.
                    var s_Components = s_AnimChannel.BitsPerSubBlock;
                    if (s_BlockFrame == 0)
                    {
                        s_Block.Add(0);
                        s_Block.Add(0);
                        s_Block.Add(0);
                        s_Block.Add(0);

                        s_Components = s_Components.Skip(1).ToArray();
                    }

                    foreach (var s_Component in s_Components)
                    {
                        var s_X = s_BitReader.ReadIntHigh(s_Component.SafeBitsX(p_Dct.CatchAllBitCount));
                        var s_Y = s_BitReader.ReadIntHigh(s_Component.SafeBitsY(p_Dct.CatchAllBitCount));
                        var s_Z = s_BitReader.ReadIntHigh(s_Component.SafeBitsZ(p_Dct.CatchAllBitCount));
                        var s_W = s_BitReader.ReadIntHigh(s_Component.SafeBitsW(p_Dct.CatchAllBitCount));


                        s_Block.Add((short)s_X);
                        s_Block.Add((short)s_Y);
                        s_Block.Add((short)s_Z);
                        s_Block.Add((short)s_W);
                    }


                    //block is always 32 in length, fill up rest with zeroes
                    if (s_Components.Length < 8)
                    {
                        for(var i =0; i < 8 - s_Components.Length; i++)
                        {
                            s_Block.Add(0);
                            s_Block.Add(0);
                            s_Block.Add(0);
                            s_Block.Add(0);
                        }
                    }

                    s_Block[0] += s_AnimChannel.DeltaBase[0];
                    s_Block[1] += s_AnimChannel.DeltaBase[1];
                    s_Block[2] += s_AnimChannel.DeltaBase[2];
                    s_Block[3] += s_AnimChannel.DeltaBase[3];

                    s_Blocks.Add(s_Block);
                }
            }

            for (var s_Frame = 0; s_Frame < p_Dct.NumKeys; s_Frame++)
            {
                var s_BlockIdx = s_Frame / 8;

                for (var s_DofIdx = 0; s_DofIdx < s_DofTable.Length; s_DofIdx++)
                {
                    var s_DataIdx = s_BlockIdx * s_DofTable.Length + s_DofIdx;

                    if (s_DataIdx >= s_Blocks.Count)
                        break;

                    var s_Block = s_Blocks.ElementAt(s_DataIdx);

                    if (s_DofIdx < p_Dct.NumQuats)
                        Console.WriteLine($"{s_Frame},{s_DofIdx},{0},{UnpackQuat(p_Dct, s_Block, (ushort)s_Frame).ToString().Replace(",", ".")}");
                    else if ((s_DofIdx - p_Dct.NumQuats) < p_Dct.NumVec3)
                        Console.WriteLine($"{s_Frame},{s_DofIdx},{1},{UnpackVec(p_Dct, s_Block, (ushort)s_Frame).ToString().Replace(",", ".")}");
                    else
                        Console.WriteLine($"{s_Frame},{s_DofIdx},{2},{UnpackVec(p_Dct, s_Block, (ushort)s_Frame).ToString().Replace(",", ".")}");
                }
            }
        }
    }
}
