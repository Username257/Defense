using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PopUpUI : BaseUI
{
    private EventSystem eventSystem;
    private Canvas popUpCanvas;
    private void Awake()
    {
        eventSystem = GameManager.Resource.Instantiate<EventSystem>("UI/EventSystem");
        eventSystem.transform.parent = transform;

        popUpCanvas = GameManager.Resource.Instantiate<Canvas>("UI/Canvas");
        popUpCanvas.gameObject.name = "PopUpCanvas";
    }

    public void ShowPopUpUI(PopUpUI popUpUi)
    {
        PopUpUI ui = GameManager.Pool.GetUI(popUpUi);
        ui.transform.SetParent(popUpCanvas.transform.transform, false);
    }

    public void ClosePopUpUI()
    {

    }
}
