using _Root.Code.Abstractions;
using UnityEngine;

namespace _Root.Code.UserControlSystem
{
    public class OutlinePresenter: MonoBehaviour
    {
        
        [SerializeField] private SelectableValue _selectedValue;

        private ISelectable _currentSelected;
        
        private void Start()
        {
            _selectedValue.OnSelected += OnSelected;
        }

        private void OnSelected(ISelectable selected)
        {
            if (selected == _currentSelected) return;
            if (selected == null)
            {
                _currentSelected.ToggleOutLine();
                _currentSelected = null;
                return;
            }
            
            if (selected != _currentSelected)
            {
                _currentSelected?.ToggleOutLine();

                _currentSelected = selected;
            }

            _currentSelected.ToggleOutLine();
        }
    }
}