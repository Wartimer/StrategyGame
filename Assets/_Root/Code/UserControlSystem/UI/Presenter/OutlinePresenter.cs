using _Root.Code.Abstractions;
using UnityEngine;

namespace _Root.Code.UserControlSystem
{
    public class OutlinePresenter: MonoBehaviour
    {
        [SerializeField] private SelectableValue _selectedValue;
        
        private void Start()
        {
            _selectedValue.OnSelected += OnSelected;
            
        }

        private void OnSelected(ISelectable selected)
        {
            if (selected.IsOutlined) return;
            if (selected != _selectedValue.CurrentValue)
            {
                _selectedValue.CurrentValue.ToggleOutLine();
                return;
            }
            selected.ToggleOutLine();
        }
    }
}