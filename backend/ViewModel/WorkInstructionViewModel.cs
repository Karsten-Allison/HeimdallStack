using backend.data;

namespace backend.ViewModel
{
    public class WorkInstructionViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public List<Instruction> InstructionSet { get; set; }
    }
}