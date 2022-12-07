using System;
using UnityEngine;
using _Root.Code.Abstractions;

namespace _Root.Code.UserControlSystem
{
    [CreateAssetMenu(fileName = nameof(SelectableValue), menuName = "Strategy Game/" + nameof(SelectableValue), order = 0)]
    public class SelectableValue : ScriptableObject
    {
        public ISelectable CurrentValue { get; private set; }
        public Action<ISelectable> OnSelected;

        public void SetValue(ISelectable value)
        {
            CurrentValue = value;
            OnSelected?.Invoke(value);
        }
    }

}