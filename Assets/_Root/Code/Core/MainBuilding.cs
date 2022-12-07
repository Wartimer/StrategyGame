using _Root.Code.Abstractions;
using UnityEngine;

public class MainBuilding : MonoBehaviour, IUnitProducer, ISelectable
{
    [SerializeField] private GameObject _unitPrefab;
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
        var enabled1 = _outline.enabled;
        enabled1 = !enabled1;
        _outline.enabled = enabled1;
        _isOutlined = enabled1;
    }

    public void ProduceUnit()
    {
        Instantiate(_unitPrefab, transform.position + _offset + new Vector3(Random.Range(-3, 3), 
                    0, Random.Range(-3, 3)), Quaternion.identity, 
                    _unitsParent);
    }

}
