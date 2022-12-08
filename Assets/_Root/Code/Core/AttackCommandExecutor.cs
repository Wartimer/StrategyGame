using _Root.Code.Abstractions.Commands;
using _Root.Code.Abstractions.Commands.CommandsInterfaces;

namespace _Root.Code.Core
{
    public class AttackCommandExecutor : CommandExecutorBase<IAttackCommand>
    {
        public override void ExecuteSpecificCommand(IAttackCommand command)
        {
            command.Execute();
        }
    }
}