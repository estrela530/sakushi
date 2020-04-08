using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnOff : MonoBehaviour
{
    [SerializeField]
    public AudioClip audioClip;
    [SerializeField]
    public AudioSource audioSource;
    [SerializeField]
    public IgnitStatus ignitStatus;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = audioClip;

    }

    // Update is called once per frame
    void Update()
    {
        ignitStatus = gameObject.GetComponent<IgnitStatus>();
        if (ignitStatus.GetIgnit() == false)
        {
            audioSource.Play();
        }
    }
}
