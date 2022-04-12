using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PanelType
{
    None,
    Main,
    Option,
    Credits,
}

public class MenuController : MonoBehaviour
{
    [Header("Panels")]
    [SerializeField] private List<MenuPanel> panelsList = new List<MenuPanel>();
    protected Dictionary<PanelType, MenuPanel> panelsDict = new Dictionary<PanelType, MenuPanel>();
    
    protected GameManager manager;

    protected virtual void Start()
    {
        manager = GameManager.instance;

        foreach (var _panel in panelsList)
        {
            if(_panel)
            {
                panelsDict.Add(_panel.GetPanelType(), _panel);
            }
        }

        OpenOnePanel(PanelType.Main);
    }

    private void OpenOnePanel(PanelType _type)
    {
        foreach (var _panel in panelsList)
        {
            _panel.SetState(false);
        }

        if(_type != PanelType.None) panelsDict[_type].SetState(true);
    }

    public void OpenPanel(PanelType _panel) { OpenOnePanel(_panel); }
    public virtual void ChangeScene(string _sceneName) { manager.ChangeScene(_sceneName); }
    public virtual void Quit() { Application.Quit(); }
}