using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject Box,Red;
    public void Start()
    {
        Red.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(Box))
        Red.SetActive(false);
    }
}
