using _Root.Code.Abstractions.Commands;
using _Root.Code.Abstractions.Commands.CommandsInterfaces;

namespace _Root.Code.Core
{
    public class PatrolCommandExecutor: CommandExecutorBase<IPatrolCommand>
    {
        public override void ExecuteSpecificCommand(IPatrolCommand command)
        {
            command.Execute();
        }
    }
}