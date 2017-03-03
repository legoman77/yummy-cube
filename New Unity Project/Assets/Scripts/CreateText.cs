using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateText : MonoBehaviour
{
    public static Text AddTextToCanvas(string textString, GameObject canvasGameObject)
    {
        Text text = canvasGameObject.AddComponent<Text>();
        text.text = textString;

        Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        text.font = ArialFont;
        text.material = ArialFont.material;

        return text;
    }
}
