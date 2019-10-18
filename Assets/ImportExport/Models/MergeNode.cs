using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

namespace importerexporter.models
{
    [Serializable]
    public class MergeNode
    {
        [SerializeField] public string OriginalValue;
        [SerializeField] public string NameToExportTo;
        [SerializeField] public string SampleValue;
        [SerializeField] public string Type;
        [SerializeField] public string[] Options;
        
        public MergeNode()
        {
        }

        public MergeNode(string originalValue, string nameToExportTo)
        {
            OriginalValue = originalValue;
            NameToExportTo = nameToExportTo;
        }
    }
}