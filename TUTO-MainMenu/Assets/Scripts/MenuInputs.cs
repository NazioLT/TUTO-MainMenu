using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class MenuInputs : MonoBehaviour
{
    public enum Side { Left, Right, }

    private PlayerInput inputs;

    private UnityEvent backEvent;
    private UnityEvent rightTriggerEvent, leftTriggerEvent;

    private void Awake()
    {
        inputs = GetComponent<PlayerInput>();
        backEvent = new UnityEvent();
        rightTriggerEvent = new UnityEvent();
        leftTriggerEvent = new UnityEvent();
    }

    #region Inputs

    private void OnBack() { backEvent.Invoke(); }
    private void OnRightShoulder() { rightTriggerEvent.Invoke(); }
    private void OnLeftShoulder() { leftTriggerEvent.Invoke(); }

    #endregion

    #region Listener Setter

    public void SetBackListener(UnityAction _call)
    {
        backEvent.RemoveAllListeners();
        backEvent.AddListener(_call);
    }
    public void SetBackListener() { rightTriggerEvent.RemoveAllListeners(); }

    public void SetShoulderListener(Side _side, UnityAction _call, UnityAction _selection)
    {
        UnityEvent _event = _side == Side.Left ? leftTriggerEvent : rightTriggerEvent;

        _event.RemoveAllListeners();
        _event.AddListener(_selection);
        _event.AddListener(_call);
    }
    public void SetShoulderListener(Side _side)
    {
        UnityEvent _event = _side == Side.Left ? leftTriggerEvent : rightTriggerEvent;
        _event.RemoveAllListeners();
    }

    #endregion
}