using System.Linq;
using _Root.Code.Abstractions;
using UnityEngine;
using UnityEngine.EventSystems;

namespace _Root.Code.UserControlSystem
{
    public class MouseInteractionsPresenter: MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private SelectableValue _selectedObject;
        [SerializeField] private EventSystem _eventSystem;
        
        private void Update()
        {
            if (!Input.GetMouseButtonUp(0))
            {
                return;
            }

            if (_eventSystem.IsPointerOverGameObject()) return;


                var hits = Physics.RaycastAll(_camera.ScreenPointToRay(Input.mousePosition));

            if (hits.Length == 0)
            {
                return;
            }

            var selectable = hits
                .Select(hit => hit.collider.GetComponentInParent<ISelectable>())
                .FirstOrDefault(c => c != null);

            if (selectable == null)
            {
                _selectedObject.SetValue(null);
                return;
            }
            
            _selectedObject.SetValue(selectable);
        }
    }
}