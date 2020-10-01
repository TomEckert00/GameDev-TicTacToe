using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSpace : MonoBehaviour
{
    public Button button;
    public Text buttonText;

    private GameManager gameManager;
    public void SetGameControllerReference(GameManager manager)
    {
        gameManager = manager;
    }

    public void SetSpace()
    {
        buttonText.text = gameManager.GetPlayerSide();
        button.interactable = false;
        gameManager.EndTurn();
    }

}
