using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Resource : MonoBehaviour
{
    public TextMeshProUGUI typeText;
    public TextMeshProUGUI nameText;
    public UserControl userControl;

    public void Awake()
    {
        typeText = GameObject.Find("Type").GetComponent<TextMeshProUGUI>();
        nameText = GameObject.Find("Name").GetComponent<TextMeshProUGUI>();
        userControl = GameObject.Find("UserControl").GetComponent<UserControl>();
    }

    public virtual void DisplayTextResource()
    {
        typeText.text = "Resource";
        nameText.text = "name";
    }
}