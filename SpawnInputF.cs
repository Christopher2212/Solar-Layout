using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInputF : MonoBehaviour
{
    public GameObject button;
    public GameObject inputText;
    public GameObject canvas;

    public Vector3 buttonVect;
    public Vector3 inputVect;
    // Start is called before the first frame update
    public void AddInputObjects()
    {
        canvas = GameObject.Find("Canvas");
        buttonVect = new Vector3(-2,6,10);
        inputVect = new Vector3(-2, 8, 10);

        GameObject myButton = Instantiate(button,canvas.transform.localPosition,Quaternion.identity);
        GameObject myInputText = Instantiate(inputText, canvas.transform.localPosition, Quaternion.identity);

        myButton.transform.SetParent(canvas.transform);
        myInputText.transform.SetParent(canvas.transform);

        myButton.GetComponent<RectTransform>().localScale = new Vector2(6,3);
        myInputText.GetComponent<RectTransform>().localScale = new Vector2(6, 3);

    }
}
