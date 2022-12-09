using _Root.Code.Abstractions.Commands;
using _Root.Code.Abstractions.Commands.CommandsInterfaces;

namespace _Root.Code.Core
{
    public class StopCommandExecutor : CommandExecutorBase<IStopCommand>
    {
        public override void ExecuteSpecificCommand(IStopCommand command)
        {
            command.Execute();
        }
    }
}