using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMgt : MonoBehaviour
{

    public GameObject confirmBox;

    // Start is called before the first frame update
    void Start()
    {
        confirmBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayBox()
    {
        confirmBox.SetActive(true);
    }

    public void CloseBox() 
    {
        confirmBox.SetActive(false);
    }
}
