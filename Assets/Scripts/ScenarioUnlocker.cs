using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioUnlocker : MonoBehaviour
{
    public GameObject gun;
    public GameObject knife;
    public GameObject alphaInfo;
    public GameObject bravoInfo;
    public GameObject charlieInfo;
    public GameObject deltaInfo;
    public GameObject pills;
    public GameObject medBook;
    public GameObject book1;

    public GameObject scenarioAlpha;
    public GameObject scenarioBravo;
    public GameObject scenarioCharlie;
    public GameObject scenarioDelta;

    void Update()
    {
        if (gun.activeSelf && pills.activeSelf && alphaInfo.activeSelf)
        {
            scenarioAlpha.SetActive(true);
        }

        if (knife.activeSelf && book1.activeSelf && bravoInfo.activeSelf)
        {
            scenarioBravo.SetActive(true);
        }
    }
}
