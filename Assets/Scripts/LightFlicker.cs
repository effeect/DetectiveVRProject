using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{

    Light lighting;
    [SerializeField] public float minWaitTime = 0.5f;
    [SerializeField] public float maxWaitTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        lighting = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));
            lighting.enabled = !lighting.enabled;
        }
    }

}
