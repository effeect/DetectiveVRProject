using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House_background_sound : MonoBehaviour
{
    public AudioClip houseSound;
    public int houseWait = 10;
    bool keepPlaying = true;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator HouseSound()
    {

        while (keepPlaying)
        {
            audioSource.PlayOneShot(houseSound);
            yield return new WaitForSeconds(houseWait);
        }
    }
// Update is called once per frame
void Update()
    {
        audioSource = SVUtilities.SetOrAddAudioSource(gameObject);
        audioSource.clip = houseSound;
        audioSource.volume = 3f;
        audioSource.Play();
       
    }
}
