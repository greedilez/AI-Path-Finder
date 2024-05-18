using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapsBuyHandler : MonoBehaviour
{
    public static int SelectedBallIndex = 0;

    [SerializeField] private GameObject[] _mapsButtons;

    private void Awake() {
        PlayerPrefs.SetInt($"0-Unlocked", 1);
    }

    public void ChooseOrBuyBall(int ballIndex) {
        int unlocked = PlayerPrefs.GetInt($"{ballIndex}-Unlocked", 0);
        if(unlocked == 1) {
            SelectedBallIndex = ballIndex;
        }
        else if(unlocked == 0) {
            int price = 8;
            int currentMoney = MoneySystem.Instance.GetMoney();
            if(currentMoney - price >= 0) {
                currentMoney -= price;
                MoneySystem.Instance.SetMoney(currentMoney);
                SelectedBallIndex = ballIndex;
                unlocked = 1;
                PlayerPrefs.SetInt($"{ballIndex}-Unlocked", unlocked);
            }
        }
    }

    private void Update() {
        UpdateMapButtons();
    }

    private void UpdateMapButtons() {
        for (int i = 0; i < _mapsButtons.Length; i++) {
            int unlocked = PlayerPrefs.GetInt($"{i}-Unlocked", 0);
            if(unlocked == 1 && SelectedBallIndex == i) {
                _mapsButtons[i].transform.GetChild(0).gameObject.SetActive(false);
                _mapsButtons[i].transform.GetChild(1).gameObject.SetActive(true);
            }
            else if(unlocked == 1 && SelectedBallIndex != i) {
                _mapsButtons[i].transform.GetChild(0).gameObject.SetActive(true);
                _mapsButtons[i].transform.GetChild(1).gameObject.SetActive(false);
            }
            else if(unlocked == 0) {
                _mapsButtons[i].transform.GetChild(0).gameObject.SetActive(true);
                _mapsButtons[i].transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }
}
