using UnityEngine;

namespace _Root.Code.Abstractions.Commands.CommandsInterfaces
{
    public interface IProduceUnitCommand: ICommand
    {
        GameObject UnitPrefab { get; }
    }
}