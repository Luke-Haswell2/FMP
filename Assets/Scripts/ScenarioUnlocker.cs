using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    public TextMeshProUGUI truckText;
    public TextMeshProUGUI outsideText;
    public TextMeshProUGUI livingRoomText;
    public TextMeshProUGUI kitchenText;
    public TextMeshProUGUI bedroomText; //noel bedroom
    public TextMeshProUGUI bigBedroomText; //eric + sierra bedroom
    public TextMeshProUGUI bathroomText;
    public TextMeshProUGUI suspectsText;
    public TextMeshProUGUI weaponsText;
    public TextMeshProUGUI phonesText;
    public TextMeshProUGUI notesText;
    public TextMeshProUGUI extraText;
    public TextMeshProUGUI totalText;

    public int truck = 0;
    public int outside = 0;
    public int livingRoom = 0;
    public int kitchen = 0;
    public int bedroom = 0; //noel bedroom
    public int bigBedroom = 0; //eric + sierra bedroom
    public int bathroom = 0;
    public int suspects = 0;
    public int weapons = 0;
    public int phones = 0;
    public int notes = 0;
    public int extra = 0;
    public int total = 0;

    [HideInInspector] public bool alphaInfoCollected;
    [HideInInspector] public bool bravoInfoCollected;
    [HideInInspector] public bool charlieInfoCollected;
    [HideInInspector] public bool deltaInfoCollected;
    [HideInInspector] public bool gunCollected;
    [HideInInspector] public bool knifeCollected;
    [HideInInspector] public bool pillsCollected;
    [HideInInspector] public bool medbookCollected;
    [HideInInspector] public bool batCollected;
    [HideInInspector] public bool book1Collected;
    [HideInInspector] public bool book2Collected;
    [HideInInspector] public bool book3Collected;
    [HideInInspector] public bool phone1Collected;
    [HideInInspector] public bool phone2Collected;
    [HideInInspector] public bool phone3Collected;
    [HideInInspector] public bool phone4Collected;
    [HideInInspector] public bool moneyCollected;
    [HideInInspector] public bool bottleCollected;
    [HideInInspector] public bool laptopCollected;

    void Start()
    {
        truckText.text = "Truck: " + truck.ToString() + "/4";
        outsideText.text = "Outside: " + outside.ToString() + "/1";
        livingRoomText.text = "Living Room: " + livingRoom.ToString() + "/4";
        kitchenText.text = "Kitchen: " + kitchen.ToString() + "/2";
        bedroomText.text = "Noel's Bedroom: " + bedroom.ToString() + "/3";
        bigBedroomText.text = "Eric And Sierra's Bedroom: " + bigBedroom.ToString() + "/3";
        bathroomText.text = "Bathroom: " + bathroom.ToString() + "/2";
        suspectsText.text = suspects.ToString() + "/4";
        weaponsText.text = weapons.ToString() + "/4";
        phonesText.text = phones.ToString() + "/4";
        notesText.text = notes.ToString() + "/3";
        extraText.text = extra.ToString() + "/4";
        totalText.text = "Total Evidence: " + total.ToString() + "/19";

        alphaInfoCollected = false;
        bravoInfoCollected = false;
        charlieInfoCollected = false;
        deltaInfoCollected = false;
        gunCollected = false;
        knifeCollected = false;
        pillsCollected = false;
        medbookCollected = false;
        batCollected = false;
        book1Collected = false;
        book2Collected = false;
        book3Collected = false;
        phone1Collected = false;
        phone2Collected = false;
        phone3Collected = false;
        phone4Collected = false;
        moneyCollected = false;
        bottleCollected = false;
        laptopCollected = false;
    }

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
        if (alphaInfoCollected == false)
        {
            if(alphaInfo.activeSelf)
            {
                AddTruck();
                AddSuspects();
                AddTotal();
                alphaInfoCollected = true;
            }
        }
        if (bravoInfoCollected == false)
        {
            if (bravoInfo.activeSelf)
            {
                AddTruck();
                AddSuspects();
                AddTotal();
                bravoInfoCollected = true;
            }
        }
        if (charlieInfoCollected == false)
        {
            if (charlieInfo.activeSelf)
            {
                AddTruck();
                AddSuspects();
                AddTotal();
                charlieInfoCollected = true;
            }
        }
        if (deltaInfoCollected == false)
        {
            if (deltaInfo.activeSelf)
            {
                AddTruck();
                AddSuspects();
                AddTotal();
                deltaInfoCollected = true;
            }
        }
        if (gunCollected == false)
        {
            if (gun.activeSelf)
            {
                AddOutside();
                AddWeapons();
                AddTotal();
                gunCollected = true;
            }
        }
        if (knifeCollected == false)
        {
            if (knife.activeSelf)
            {
                AddBathroom();
                AddWeapons();
                AddTotal();
                knifeCollected = true;
            }
        }
        if (pillsCollected == false)
        {
            if (pills.activeSelf)
            {
                AddKitchen();
                AddWeapons();
                AddTotal();
                pillsCollected = true;
            }
        }
        if (medbookCollected == false)
        {
            if (medbook.activeSelf)
            {
                AddBedroom();
                AddExtra();
                AddTotal();
                medbookCollected = true;
            }
        }
        if (batCollected == false)
        {
            if (bat.activeSelf)
            {
                AddLivingRoom();
                AddWeapons();
                AddTotal();
                batCollected = true;
            }
        }
        if (book1Collected == false)
        {
            if (book1.activeSelf)
            {
                AddKitchen();
                AddNotes();
                AddTotal();
                book1Collected = true;
            }
        }
        if (book2Collected == false)
        {
            if (book2.activeSelf)
            {
                AddBigBedroom();
                AddNotes();
                AddTotal();
                book2Collected = true;
            }
        }
        if (book3Collected == false)
        {
            if (book3.activeSelf)
            {
                AddBedroom();
                AddNotes();
                AddTotal();
                book3Collected = true;
            }
        }
        if (phone1Collected == false)
        {
            if (phone1.activeSelf)
            {
                AddLivingRoom();
                AddPhones();
                AddTotal();
                phone1Collected = true;
            }
        }
        if (phone2Collected == false)
        {
            if (phone2.activeSelf)
            {
                AddLivingRoom();
                AddPhones();
                AddTotal();
                phone2Collected = true;
            }
        }
        if (phone3Collected == false)
        {
            if (phone3.activeSelf)
            {
                AddBedroom();
                AddPhones();
                AddTotal();
                phone3Collected = true;
            }
        }
        if (phone4Collected == false)
        {
            if (phone4.activeSelf)
            {
                AddBigBedroom();
                AddPhones();
                AddTotal();
                phone4Collected = true;
            }
        }
        if (moneyCollected == false)
        {
            if (money.activeSelf)
            {
                AddBathroom();
                AddExtra();
                AddTotal();
                moneyCollected = true;
            }
        }
        if (bottleCollected == false)
        {
            if (bottle.activeSelf)
            {
                AddBigBedroom();
                AddExtra();
                AddTotal();
                bottleCollected = true;
            }
        }
        if (laptopCollected == false)
        {
            if (laptop.activeSelf)
            {
                AddLivingRoom();
                AddExtra();
                AddTotal();
                laptopCollected = true;
            }
        }
    }

    public void AddTruck()
    {
        truck += 1;
        truckText.text = "Truck: " + truck.ToString() + "/4";
    }
    public void AddOutside()
    {
        outside += 1;
        outsideText.text = "Outside: " + outside.ToString() + "/1";
    }
    public void AddLivingRoom()
    {
        livingRoom += 1;
        livingRoomText.text = "Living Room: " + livingRoom.ToString() + "/4";
    }
    public void AddKitchen()
    {
        kitchen += 1;
        kitchenText.text = "Kitchen: " + kitchen.ToString() + "/2";
    }
    public void AddBedroom()
    {
        bedroom += 1;
        bedroomText.text = "Noel's Bedroom: " + bedroom.ToString() + "/3";
    }
    public void AddBigBedroom()
    {
        bigBedroom += 1;
        bigBedroomText.text = "Eric And Sierra's Bedroom: " + bigBedroom.ToString() + "/3";
    }
    public void AddBathroom()
    {
        bathroom += 1;
        bathroomText.text = "Bathroom: " + bathroom.ToString() + "/2";
    }
    public void AddSuspects()
    {
        suspects += 1;
        suspectsText.text = suspects.ToString() + "/4";
    }
    public void AddWeapons()
    {
        weapons += 1;
        weaponsText.text = weapons.ToString() + "/4";
    }
    public void AddPhones()
    {
        phones += 1;
        phonesText.text = phones.ToString() + "/4";
    }
    public void AddNotes()
    {
        notes += 1;
        notesText.text = notes.ToString() + "/3";
    }
    public void AddExtra()
    {
        extra += 1;
        extraText.text = extra.ToString() + "/4";
    }
    public void AddTotal()
    {
        total += 1;
        totalText.text = "Total Evidence: " + total.ToString() + "/19";
    }
}
