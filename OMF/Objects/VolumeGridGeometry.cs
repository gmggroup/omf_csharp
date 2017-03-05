﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace OMF.Objects
{
    public class VolumeGridGeometry : DateBase, IObject
    {
        public VolumeGridGeometry()
        {

        }

        public double[] origin { get; set; }
        public double[] axis_u { get; set; }
        public double[] axis_v { get; set; }
        public double[] axis_w { get; set; }
        public double[] tensor_v { get; set; }
        public double[] tensor_w { get; set; }
        public double[] tensor_u { get; set; }

        public void Deserialize(Dictionary<string, object> json, System.IO.BinaryReader br)
        {

        }

        public void Serialize(Dictionary<string, object> json, BinaryWriter bw, string guid)
        {

            ObjectFactory.GetObjectToData(json, this, guid);
        }
    }
}