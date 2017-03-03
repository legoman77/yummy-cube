using UnityEngine;
using System.Collections;
using UnityEngine.UI;  //its a must to access new UI in script
public class DispalyScore : MonoBehaviour
{
    public Text Score_UIText; // assign it from inspector
    void Start()
    {
        Score_UIText.text = health;
    }

}