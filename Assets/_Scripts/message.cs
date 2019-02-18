using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class message : MonoBehaviour
{
    [SerializeField] private InputField inputText;
    [SerializeField] private Text displayText;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            postText();
        }
    }

    public void postText()
    {
        displayText.text = displayText.text + "\n <color=#ff0000ff>yo: </color><color=#000000ff>" + inputText.text + "</color>";
        inputText.text = "";
    }

}
