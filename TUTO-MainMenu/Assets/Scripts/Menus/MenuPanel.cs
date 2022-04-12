using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Canvas))]
public class MenuPanel : MonoBehaviour
{
    [SerializeField] protected PanelType type;
    protected bool state;

    private Canvas canvas;

    private void Awake()
    {
        canvas = GetComponent<Canvas>();
    }

    protected void UpdateState()
    {
        canvas.enabled = state;
    }

    public void ChangeState()
    {
        state = !state;
        UpdateState();
    }

    public void SetState(bool _state)
    {
        state = _state;
        UpdateState();
    }

    public PanelType GetPanelType() { return type; }
}
