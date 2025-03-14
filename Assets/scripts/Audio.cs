using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Audio:MonoBehaviour
    {
        [SerializeField] AudioSource audioSource;
        public AudioClip audioClip;

        private void Start()
        {
            audioSource.clip = audioClip;
            audioSource.Play();
        }
    }
    
}