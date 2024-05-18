using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSetter : MonoBehaviour
{
    [SerializeField] private AudioMixer _mixer;

    public void SetVolume(float value) => _mixer.SetFloat("Volume", value);
}
