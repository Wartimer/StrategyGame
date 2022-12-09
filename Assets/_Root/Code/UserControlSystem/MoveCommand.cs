using _Root.Code.Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace _Root.Code.UserControlSystem
{
    public class MoveCommand : IMoveCommand
    {
        public void Execute()
        {
            Debug.Log("Move command produced!");
        }
    }
}