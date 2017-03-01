﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMF.OMFClasses
{
    public class Int3Array : DateBase, IClass
    {
        public string __class__ { get; set; }
        public ScalarArray array { get; set; }

        public List<int[]> Data { get; set; }

        public void Deserialize(Dictionary<string, object> json, BinaryReader br)
        {
            Data = new List<int[]>();
            br.BaseStream.Seek(array.start, System.IO.SeekOrigin.Begin);
            byte[] data = br.ReadBytes((int)array.length);

            byte[] newdata = Ionic.Zlib.ZlibStream.UncompressBuffer(data);

            for (int i = 0; i < newdata.Length; i = i + 12)
            {
                int[] toadd = new int[3];
                toadd[0] = BitConverter.ToInt32(newdata, i);
                toadd[1] = BitConverter.ToInt32(newdata, i + 4);
                toadd[2] = BitConverter.ToInt32(newdata, i + 8);
                Data.Add(toadd);
            }
        }
    }
}