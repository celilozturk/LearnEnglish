﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnEnglish.Models
{
    public class Instruction
    {
        public int InstructionId { get; set; }
        public string Title { get; set; }
        public sbyte Rank { get; set; }
        public DateTime CreatedDate { get; set; }
        public ContentDetail ContentDetail { get; set; }
        public List<InstructionDetail> InstructionDetails { get; set; }
        public List<InstructionSound> InstructionSounds { get; set; }
        
        


        //Todo instruction tablosu ikiye ayrilacak instruction details ile beraber
        //Listening dosyalarinin oldugu listede eklenecek.
    }
}
