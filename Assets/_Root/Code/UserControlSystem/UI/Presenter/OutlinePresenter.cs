using _Root.Code.Abstractions;
using _Root.Code.Utility;
using UnityEngine;

namespace _Root.Code.UserControlSystem
{
    public class OutlinePresenter: MonoBehaviour
    {
        
        [SerializeField] private SelectableValue _selectedValue;
        
        private OutlineSelector[] _outlineSelectors;
        private ISelectable _currentSelectable;
        
        private void Start()
        {
            _selectedValue.OnSelected += OnSelected;
        }

        private void OnSelected(ISelectable selectable)
        {
            if (selectable == _currentSelectable) return;
            
            SetSelected(_outlineSelectors, false);
            _outlineSelectors = null;
            
            if (selectable != null)
            {
                _outlineSelectors = (selectable as Component).GetComponentsInParent<OutlineSelector>();
                SetSelected(_outlineSelectors, true);
            }

            _currentSelectable = selectable;
            
            static void SetSelected(OutlineSelector[] selectors, bool value)
            {
                if (selectors != null)
                {
                    for (var i = 0; i < selectors.Length; i++)
                    {
                        selectors[i].SetSelected(value);
                    }
                }
            }
            
        }
    }
}