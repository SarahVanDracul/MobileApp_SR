using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private void OnMouseDown()
    {
        //Color change red; 
        GetComponent<MeshRenderer>().material.color = Color.red; 
    }

    public void ButtonChangeColor()
    {
        //Color change to green, if green to white

         
        if (GetComponent<MeshRenderer>().material.color == Color.green)
        {
            GetComponent<MeshRenderer>().material.color = Color.white; 
        }

        else
        {
            GetComponent<MeshRenderer>().material.color = Color.green; 
        }
    }
}
