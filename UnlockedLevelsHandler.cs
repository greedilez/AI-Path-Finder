using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UnlockedLevelsHandler : MonoBehaviour
{
    private string _unlockedLevelsPPKey = "UnlockedLevels";

    [SerializeField] private Button[] _levelButtons;

    public bool LoadButtons = true;

    private void Awake() {
        if (LoadButtons) UpdateUnlockedLevels();
    }

    public void SetUnlockedLevels(int value) => PlayerPrefs.SetInt(_unlockedLevelsPPKey, value);

    public void SetNextLevelAsUnlocked() => SetUnlockedLevels(SceneManager.GetActiveScene().buildIndex + 1);

    public void UpdateUnlockedLevels() {
        int childIndex = 1;
        int unlockedAmount = PlayerPrefs.GetInt(_unlockedLevelsPPKey, 1);
        for (int i = 0; i < _levelButtons.Length; i++) {
            _levelButtons[i].interactable = false;
            _levelButtons[i].transform.GetChild(childIndex).gameObject.SetActive(true);
        }

        for (int i = 0; i < unlockedAmount; i++) {
            _levelButtons[i].interactable = true;
            _levelButtons[i].transform.GetChild(childIndex).gameObject.SetActive(false);
        }
    }
}
