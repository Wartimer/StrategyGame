using System;
using System.Collections.Generic;
using _Root.Code.Abstractions;
using _Root.Code.Abstractions.Commands;
using _Root.Code.Abstractions.Commands.CommandsInterfaces;
using _Root.Code.UserControlSystem.UI.View;
using _Root.Code.Utility;
using UnityEngine;


namespace _Root.Code.UserControlSystem
{
    public class CommandButtonsPresenter : MonoBehaviour
    {
        [SerializeField] private SelectableValue _selectable;
        [SerializeField] private CommandButtonsView _view;
        [SerializeField] private AssetsContext _context;
        private ISelectable _currentSelectable;
        private void Start()
        {
            _selectable.OnSelected += onSelected;
            onSelected(_selectable.CurrentValue);
            _view.OnClick += OnButtonClick;
        }
        private void onSelected(ISelectable selectable)
        {
            if (_currentSelectable == selectable)
            {
                return;
            }
            _currentSelectable = selectable;
            _view.Clear();
            if (selectable != null)
            {
                var commandExecutors = new List<ICommandExecutor>();
                commandExecutors.AddRange((selectable as
                    Component).GetComponentsInParent<ICommandExecutor>());
                _view.MakeLayout(commandExecutors);
            }
        }
        
        private void OnButtonClick(ICommandExecutor commandExecutor)
        {
            switch (commandExecutor)
            {
                case CommandExecutorBase<IProduceUnitCommand> unitProducer:
                    unitProducer.ExecuteSpecificCommand(_context.Inject(new ProduceUnitCommandHeir()));
                    return;
                case CommandExecutorBase<IAttackCommand> attackExecutor:
                    attackExecutor.ExecuteSpecificCommand(new AttackCommand());
                    return;
                case CommandExecutorBase<IMoveCommand> moveExecutor:
                    moveExecutor.ExecuteSpecificCommand(new MoveCommand());
                    return;
                case CommandExecutorBase<IPatrolCommand> patrolExecutor:
                    patrolExecutor.ExecuteSpecificCommand(new PatrolCommand());
                    return;
                case CommandExecutorBase<IStopCommand> stopExecutor:
                    stopExecutor.ExecuteSpecificCommand(new StopCommand());
                    return;
                default:
                    throw new
                        ApplicationException($"{nameof(CommandButtonsPresenter)}.{nameof(OnButtonClick)}:" +
                                             $"Unknown type of commands executor: {commandExecutor.GetType().FullName}!");
            }
        }
    }
    
    
}

