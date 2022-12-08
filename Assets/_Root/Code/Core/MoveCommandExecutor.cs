using _Root.Code.Abstractions.Commands;
using _Root.Code.Abstractions.Commands.CommandsInterfaces;

namespace _Root.Code.Core
{
    public class MoveCommandExecutor: CommandExecutorBase<IMoveCommand>
    {
        public override void ExecuteSpecificCommand(IMoveCommand command)
        {
            command.Execute();
        }
    }
}