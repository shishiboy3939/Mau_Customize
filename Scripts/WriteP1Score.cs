using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WriteP1Score : MonoBehaviour
{
    private void Start()
    {
        GetComponent<TextMeshProUGUI>().text = GlobalVariables.player1Score.ToString();
    }
}
