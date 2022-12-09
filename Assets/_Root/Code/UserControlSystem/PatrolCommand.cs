using _Root.Code.Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace _Root.Code.UserControlSystem
{
    public class PatrolCommand: IPatrolCommand
    {
        public void Execute()
        {
            Debug.Log("Patrol command produced!");
        }
    }
}