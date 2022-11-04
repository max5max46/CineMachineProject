using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerScary : MonoBehaviour
{
    public PlayableDirector timeline;
    public GameObject Secret;

    public bool OneTimeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();
        Secret.SetActive(true);
        Destroy(this.gameObject);
    }
}
