using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallLoader : MonoBehaviour
{
    [SerializeField] private Sprite[] _ballVariations;

    private SpriteRenderer _renderer;

    private void Awake() {
        _renderer = GetComponent<SpriteRenderer>();
        _renderer.sprite = _ballVariations[MapsBuyHandler.SelectedBallIndex];
    }
}
