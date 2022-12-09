namespace _Root.Code.Abstractions.Commands
{
    public interface ICommandExecutor
    {
        void ExecuteCommand(object command);
    }
}