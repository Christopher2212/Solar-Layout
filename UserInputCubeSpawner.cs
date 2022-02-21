using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInputCubeSpawner : MonoBehaviour
{
    public Button btnClick;
    public InputField inputUser;

    private void Start()
    {
        btnClick.onClick.AddListener(GetInputOnClickHandeler);
    }

    public void GetInputOnClickHandeler(){
        Debug.Log("Hello" + inputUser.text);
    }
}
