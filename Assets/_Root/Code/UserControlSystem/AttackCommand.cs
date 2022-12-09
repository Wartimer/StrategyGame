using _Root.Code.Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace _Root.Code.UserControlSystem
{
    public class AttackCommand: IAttackCommand
    {
        public void Execute()
        {
            Debug.Log("Attack command produced!");
        }
    }
}