using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend;

namespace backend.data
{
    public class WorkInstructionSet
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public List<Instruction> InstructionSet { get; set; }
    }

    public class Instruction
    {
        public int ID { get; set; }
        [Required]
        public string InstructionText { get; set; }

        //public (custom data object) Data { get; set; }
    }
}
