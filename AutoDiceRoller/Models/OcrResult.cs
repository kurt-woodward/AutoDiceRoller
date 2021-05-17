using System;
using System.Collections.Generic;

#nullable disable

namespace AutoDiceRoller.Models
{
    public partial class OcrResult
    {
        public int RollId { get; set; }
        public double ConfidenceLvl { get; set; }
        public int FaceValue { get; set; }
    }
}
