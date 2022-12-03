using backend.data;

namespace backend
{ 
    public static class DataSeeder
    {
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<WorkInstructionDatabaseContext>();
            context.Database.EnsureCreated();
            AddInstructions(context);

        }

        private static void AddInstructions(WorkInstructionDatabaseContext context)
        {
            var WorkInstruction = context.WorkInstructionSets.FirstOrDefault();
            if (WorkInstruction != null) return;

            Instruction instruct1 = new Instruction();
            Instruction instruct2 = new Instruction();
            instruct1.InstructionText = "Pickup the chair.";
            instruct2.InstructionText = "Set down the chair.";

            List<Instruction> temp = new List<Instruction>();
            temp.Add(instruct1);
            temp.Add(instruct2);

            context.WorkInstructionSets.Add(new WorkInstructionSet
            {
                Title = "Moving Chair",
                Description = "Instructions for moving a wooden chair (item ID ####) to a different location.",
                InstructionSet = temp

            });

            context.SaveChanges();
        }
    }
}