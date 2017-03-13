﻿using OMF.Base;
using System.Collections.Generic;
using System.IO;

namespace OMF
{
    public class ScalarData : ProjectElementData, IObject
    {
        public string array { get; set; }

        public void Deserialize(Dictionary<string, object> json, BinaryReader br)
        {

        }

        public void Serialize(Dictionary<string, object> json, BinaryWriter bw, string guid)
        {
            ObjectFactory.GetObjectToData(json, this, guid);
        }
    }
}
