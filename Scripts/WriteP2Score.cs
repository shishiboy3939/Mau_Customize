using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WriteP2Score : MonoBehaviour
{
    private void Start()
    {
        GetComponent<TextMeshProUGUI>().text = GlobalVariables.player2Score.ToString();
    }
}
