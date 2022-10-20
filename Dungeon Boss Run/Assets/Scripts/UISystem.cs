using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UISystem : MonoBehaviour
{
    [SerializeField] private GameObject victoryText;

    [SerializeField] private GameObject deathText;

    [SerializeField] private Animator _bossAni;

    [SerializeField] private Animator _playerAni;
    // Update is called once per frame
    void Update()
    {
        if (_bossAni.GetBool("victoryPlayer"))
        {
            victoryText.SetActive(true);
        }

        if (_playerAni.GetBool("isDead"))
        {
            deathText.SetActive(true);
        }
    }
}
