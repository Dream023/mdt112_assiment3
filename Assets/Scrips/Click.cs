using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public GameObject End;
    private void OnMouseDrag()
    {
        Vector3 M = Input.mousePosition;
        M.z = transform.position.z - Camera.main.transform.position.z;
        M = Camera.main.ScreenToWorldPoint(M);
        transform.position = new Vector3(M.x, M.y, transform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(End))
        {
            Debug.Log(End);
        }
    }
}
