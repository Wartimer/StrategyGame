using System;
using UnityEngine;

namespace _Root.Code.Utility
{
    public class OutlineSelector : MonoBehaviour
    {
        [SerializeField] private Outline[] _outlineComponents;

        private bool _isSelectedCache;
        
        private void Start() => DisableOutline();


        public void SetSelected(bool isSelected)
        {
            if (isSelected == _isSelectedCache) return;
            if (isSelected)
            {
                EnableOutline();
            }
            else 
                DisableOutline();

            _isSelectedCache = isSelected;
        }
        
        private void DisableOutline()
        {
            for (var i = 0; i < _outlineComponents.Length; i++)
            {
                _outlineComponents[i].enabled = false;
            }
        }
        
        private void EnableOutline()
        {
            for (var i = 0; i < _outlineComponents.Length; i++)
            {
                _outlineComponents[i].enabled = true;
            }
        }
    }
}