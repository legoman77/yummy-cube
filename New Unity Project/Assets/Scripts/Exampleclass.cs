using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Exampleclass : MonoBehaviour
{
    public int health = 100;
    public string stringToEdit = "";
    public Text Score_UIText; // assign it from inspector
    void OnGUI()
    {
        stringToEdit = GUI.TextField(new Rect(10, 10, 200, 20), stringToEdit, 25);
    }

    void Update()
    {
        EnterText("According");
    }

    void EnterText(string answer)
    {
        if (stringToEdit != answer)
        {
            health -= 1;
        }
    }
}