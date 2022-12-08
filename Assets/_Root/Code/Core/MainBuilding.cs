using _Root.Code.Abstractions;
using _Root.Code.Abstractions.Commands;
using _Root.Code.Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

public sealed class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelectable
{
    [SerializeField] private Transform _unitsParent;
    [SerializeField] private Sprite _icon;
    [SerializeField] private Outline _outline;
    [Space]
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _health;
    [SerializeField] private float _maxHealth = 1000;
    
    private bool _isOutlined;
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;
    public bool IsOutlined => _isOutlined;

    public void ToggleOutLine()
    {
        _isOutlined = !_outline.enabled;
        _outline.enabled = _isOutlined;
    }

    public override void ExecuteSpecificCommand(IProduceUnitCommand command)
    {
        Instantiate(command.UnitPrefab, transform.position + _offset + new Vector3(Random.Range(-3, 3), 
                    0, Random.Range(-3, 3)), Quaternion.identity, 
                    _unitsParent);
    }

}
