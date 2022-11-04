using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecretScript : MonoBehaviour
{
    public GameObject SecretObjects;
    private void OnTriggerEnter(Collider other)
    {
        SecretObjects.SetActive(true);
    }
}
