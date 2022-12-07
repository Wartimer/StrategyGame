using UnityEngine;

namespace _Root.Code.Abstractions
{
    public interface ISelectable
    {
            float Health { get; }
            float MaxHealth { get; }
            Sprite Icon { get; }
            
            bool IsOutlined { get; }
            void ToggleOutLine();
            
    }
}