using _Root.Code.Abstractions.Commands.CommandsInterfaces;
using _Root.Code.Utility;
using UnityEngine;

namespace _Root.Code.UserControlSystem
{
    public class ProduceUnitCommand : IProduceUnitCommand
    {
        public GameObject UnitPrefab => _unitPrefab;
        [InjectAsset("FreeLichPBR")] protected GameObject _unitPrefab;
    }
}