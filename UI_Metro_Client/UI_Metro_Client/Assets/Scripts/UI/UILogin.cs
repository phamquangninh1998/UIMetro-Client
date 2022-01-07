using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILogin : Dialog<UILogin>
{
    public static void Show()
    {
        Open();
    }

    public static void Hide()
    {
        Close();
    }

    private UILoginCanvas _uiLoginCanvas;

    public UILoginCanvas UILoginCanvas
    {
        get
        {
            if (this._uiLoginCanvas == null)
            {
                this._uiLoginCanvas = this.GetComponentInChildren<UILoginCanvas>();
            }
            return this._uiLoginCanvas;
        }
    }
}