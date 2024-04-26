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
    public GameObject book2;
    public GameObject book3;
    public GameObject money;

    public GameObject scenarioAlpha;
    public GameObject scenarioBravo;
    public GameObject scenarioCharlie;
    public GameObject scenarioDelta;

    void Update()
    {
        //Alpha needs alpha info, knife, money, book 4, red phone, blue phone
        if (gun.activeSelf && pills.activeSelf && alphaInfo.activeSelf)
        {
            scenarioAlpha.SetActive(true);
        }
        //bravo needs: bravo info, gun, book3, blue phone
        if (knife.activeSelf && book1.activeSelf && bravoInfo.activeSelf)
        {
            scenarioBravo.SetActive(true);
        }
        //charlie needs: charlie info, pills, medbook, book 1, green phone
        if (charlieInfo.activeSelf)
        {
            scenarioCharlie.SetActive(true);
        }
        //delta needs: delta info, bat, book 2, white phone
        if (deltaInfo.activeSelf)
        {
            scenarioDelta.SetActive(true);
        }
    }
}
