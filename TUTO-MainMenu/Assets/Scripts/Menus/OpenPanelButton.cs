using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPanelButton : MonoBehaviour
{
    [SerializeField] private PanelType type;

    private MenuController menu;

    private void Start()
    {
        menu = FindObjectOfType<MenuController>();
    }

    public void OnClick()
    {
        menu.OpenPanel(type);
    }
}
