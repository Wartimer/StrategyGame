using _Root.Code.Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace _Root.Code.UserControlSystem
{
    public class StopCommand: IStopCommand
    {
        public void Execute()
        {
            Debug.Log("Stop command produced!");
        }
    }
}