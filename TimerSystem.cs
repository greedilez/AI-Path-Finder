using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class TimerSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text _time;

    public static TimerSystem Instance;

    private int _secondsPassed = 0;

    public int SecondsPassed{ get => _secondsPassed; }

    private void Awake() {
        Instance = this;
        StartCoroutine(SecondsCount());
    }

    private IEnumerator SecondsCount() {
        yield return new WaitForSeconds(1);
        {
            _secondsPassed++;
            StartCoroutine(SecondsCount());
        }
    }

    private void Update() {
        TimeSpan timeSpan = TimeSpan.FromSeconds(_secondsPassed);
        _time.text = timeSpan.ToString(@"hh\:mm\:ss");
    }
}
