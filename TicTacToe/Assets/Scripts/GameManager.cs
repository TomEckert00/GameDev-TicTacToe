using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text[] buttonList;

    void Awake()
    {
        SetGameControllerReferenceOnButtons();
    }

    public void SetGameControllerReferenceOnButtons()
    {
        //foreach(Text button in buttonList)
        for(int i = 0; i < buttonList.Length; i++)
        {
            //button.SetGameControllerReference();
            buttonList[i].GetComponentInParent<GridSpace>().SetGameControllerReference(this);
        }
    }

    public string GetPlayerSide()
    {
        return "?";
    }

    public void EndTurn()
    {
        Debug.Log("EndTurn is not implemented!");
    }
}
