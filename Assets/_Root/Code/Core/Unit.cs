using _Root.Code.Abstractions;
using UnityEngine;

namespace _Root.Code.Core
{
    public class Unit: MonoBehaviour, ISelectable
    {
        [SerializeField] private Sprite _icon;
        [SerializeField] private Outline _outline;
        
        [SerializeField] private float _health;
        [SerializeField] private float _maxHealth = 100;
        
        private bool _isOutlined;

        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Sprite Icon => _icon;
        
        public bool IsOutlined { get; }
        
        public void ToggleOutLine()
        {
            _isOutlined = !_outline.enabled;
            _outline.enabled = _isOutlined;
        }
    }
}