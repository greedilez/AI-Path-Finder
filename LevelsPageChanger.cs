using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelsPageChanger : MonoBehaviour
{
    [SerializeField] private GameObject[] _panels;

    private int _currentPageIndex = 0;

    [SerializeField] private TMP_Text _currentPageText;

    private void Awake() {
        UpdatePages();
    }

    public void NextPage() {
        if(_currentPageIndex < _panels.Length - 1) {
            _currentPageIndex++;
            UpdatePages();
        }
    }

    public void PreviousPage() {
        if(_currentPageIndex > 0) {
            _currentPageIndex--;
            UpdatePages();
        }
    }

    public void UpdatePages() {
        for (int i = 0; i < _panels.Length; i++) {
            _panels[i].SetActive(false);
        }
        _panels[_currentPageIndex].SetActive(true);
        _currentPageText.text = $"Page: {_currentPageIndex}";
    }
}
