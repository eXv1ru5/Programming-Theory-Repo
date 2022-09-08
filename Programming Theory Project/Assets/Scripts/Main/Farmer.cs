using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Farmer : MonoBehaviour
{
    public TextMeshProUGUI typeText;
    public TextMeshProUGUI nameText;
    public UserControl userControl;

    private float m_Speed = 10;
    public float speed // ENCAPSULATION
    {
        get { return m_Speed; }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative speed!");
            }
            else
            {
                m_Speed = value;
            }
        }
    }

    public void Awake()
    {
        typeText = GameObject.Find("Type").GetComponent<TextMeshProUGUI>();
        nameText = GameObject.Find("Name").GetComponent<TextMeshProUGUI>();
        userControl = GameObject.Find("UserControl").GetComponent<UserControl>();
    }

    public virtual void DisplayTextFarmer() // ABSTRACTION
    {
        typeText.text = "Farmer";
        nameText.text = "name";
    }
}
