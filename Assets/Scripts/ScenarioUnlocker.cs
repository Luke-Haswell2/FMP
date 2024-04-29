using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioUnlocker : MonoBehaviour
{
    public GameObject alphaInfo;
    public GameObject bravoInfo;
    public GameObject charlieInfo;
    public GameObject deltaInfo;
    public GameObject gun;
    public GameObject knife;
    public GameObject pills;
    public GameObject medbook;
    public GameObject bat;
    public GameObject book1; //green
    public GameObject book2; //blue
    public GameObject book3; //red
    public GameObject phone1; //white
    public GameObject phone2; //green
    public GameObject phone3; //red
    public GameObject phone4; //blue
    public GameObject money;
    public GameObject bottle;
    public GameObject laptop;

    public GameObject scenarioAlpha;
    public GameObject scenarioBravo;
    public GameObject scenarioCharlie;
    public GameObject scenarioDelta;

    void Update()
    {
        //alpha needs: alpha info, gun, phone2(g), phone1(w), money
        if (alphaInfo.activeSelf && gun.activeSelf && phone2.activeSelf && phone1.activeSelf && money.activeSelf)
        {
            scenarioAlpha.SetActive(true);
        }
        //bravo needs: bravo info, pills, medbook, phone3(r), phone1(w), book3(r)
        if (bravoInfo.activeSelf && pills.activeSelf && medbook.activeSelf && phone3.activeSelf && phone1.activeSelf && book3.activeSelf)
        {
            scenarioBravo.SetActive(true);
        }
        //charlie needs: charlie info, bat, book1(g), laptop
        if (charlieInfo.activeSelf && bat.activeSelf && book1.activeSelf && laptop.activeSelf)
        {
            scenarioCharlie.SetActive(true);
        }
        //delta needs: delta info, knife, phone4(b), book2(b), bottle
        if (deltaInfo.activeSelf && knife.activeSelf && phone4.activeSelf && book2.activeSelf && bottle.activeSelf)
        {
            scenarioDelta.SetActive(true);
        }
    }
}
