using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuesterBuying : MonoBehaviour {

    public GameObject buyingLayout;
    public Text infotv;
    public Image buyingItemImage;
    public Button buyButton;
    int busterPrice,ID;
	// Use this for initialization
	void Start () {
		
	}

    public void onFasterEatersClick() {
        buyingLayout.active = true;
        buyingmanager(0);
    }
    public void onFreshFoodClick() {
        buyingLayout.active = true;
        buyingmanager(1);
    }
    public void onMarkupClick() {
        buyingLayout.active = true;
        buyingmanager(2);
    }
    public void onMorepersonClick() {
        buyingLayout.active = true;
        buyingmanager(3);
    }

    public void buyingmanager(int id) {
        ID = id;
        string info="",teraz="",potem="";
        if (id == 0) { busterPrice = 200; info = Translator.fastEating1Shop + (Variables.stufflvlShop[0] * 5) + Translator.fastEating2Shop + Translator.priceString + busterPrice;
            buyingItemImage.sprite = Resources.Load<Sprite>("Tables/fasteater");
            if (Variables.stufflvlShop[0] == 7) { info = Translator.fastEating3Shop; buyButton.interactable = false; }
        }
        if (id == 1) {
            if (Variables.stufflvlShop[1] == 0) { busterPrice = 101;teraz = "0%";potem = "25%"; }
            if (Variables.stufflvlShop[1] == 1) { busterPrice = 255; teraz = "25%"; potem = "50%"; }
            if (Variables.stufflvlShop[1] == 2) { busterPrice = 514; teraz = "50%"; potem = "75%"; }
            if (Variables.stufflvlShop[1] == 3) { busterPrice = 712; teraz = "75%"; potem = "90%"; }
            if (Variables.stufflvlShop[1] == 4) { busterPrice = 1398; teraz = "90%"; potem = "100%"; }
            info = Translator.freshFood1Shop+teraz+ Translator.freshFood2Shop + potem+Translator.freshFood3Shop + Translator.priceString + busterPrice;
            if (Variables.stufflvlShop[1] == 5) { info =Translator.freshFood4Shop ; buyButton.interactable = false; }
            buyingItemImage.sprite = Resources.Load<Sprite>("Tables/freshfood");
        }
        if (id == 2) {
            if (Variables.stufflvlShop[2] == 0) { busterPrice = 200; teraz = "50%"; potem = "100%"; }
            if (Variables.stufflvlShop[2] == 1) { busterPrice = 400; teraz = "100%"; potem = "150%"; }
            if (Variables.stufflvlShop[2] == 2) { busterPrice = 701; teraz = "150%"; potem = "200%"; }
            if (Variables.stufflvlShop[2] == 3) { busterPrice = 1100; teraz = "200%"; potem = "250%"; }
            if (Variables.stufflvlShop[2] == 4) { busterPrice = 1700; teraz = "250%"; potem = "300%"; }
            info = Translator.markup1Shop +teraz+ Translator.markup2Shop +potem+ Translator.markup3Shop + Translator.priceString + busterPrice;
            if (Variables.stufflvlShop[2] == 5) { info = Translator.markup4Shop; buyButton.interactable = false; }
            buyingItemImage.sprite = Resources.Load<Sprite>("Tables/markup");
        }
        if (id == 3) {
            if (Variables.stufflvlShop[3] == 0) { busterPrice = 400; teraz = "2"; potem = "3"; }
            if (Variables.stufflvlShop[3] == 1) { busterPrice = 500; teraz = "3"; potem = "4"; }
            if (Variables.stufflvlShop[3] == 2) { busterPrice = 600; teraz = "4"; potem = "5"; }
            if (Variables.stufflvlShop[3] == 3) { busterPrice = 700; teraz = "5"; potem = "6"; }
            info=Translator.moreperson1Shop +teraz+ Translator.moreperson2Shop +potem + Translator.priceString + busterPrice;
            if (Variables.stufflvlShop[3] == 4) { info = Translator.moreperson3Shop; buyButton.interactable = false; }
            buyingItemImage.sprite = Resources.Load<Sprite>("Tables/moreperson");
        }

        infotv.text = info;
        
    }

    public void onBuyClick() {
        if (Variables.Money >= busterPrice) {
            if (ID == 0) { Variables.stufflvlShop[0]++;Variables.eatingTimeDurration -= 5; }
            if (ID == 1) { Variables.stufflvlShop[1]++;
                if (Variables.stufflvlShop[1] == 1) { Variables.foodSurvive = 0.25f; }
                if (Variables.stufflvlShop[1] == 2) { Variables.foodSurvive = 0.50f; }
                if (Variables.stufflvlShop[1] == 3) { Variables.foodSurvive = 0.75f; }
                if (Variables.stufflvlShop[1] == 4) { Variables.foodSurvive = 0.90f; }
                if (Variables.stufflvlShop[1] == 5) { Variables.foodSurvive = 1f; }
            }
            if (ID == 2) { Variables.stufflvlShop[2]++;
                if (Variables.stufflvlShop[2] == 1) { Variables.markup = 1f; }
                if (Variables.stufflvlShop[2] == 2) { Variables.markup = 1.5f; }
                if (Variables.stufflvlShop[2] == 3) { Variables.markup = 2f; }
                if (Variables.stufflvlShop[2] == 4) { Variables.markup = 2.5f; }
                if (Variables.stufflvlShop[2] == 5) { Variables.markup = 3f; }
            }
            if (ID == 3) { Variables.stufflvlShop[3]++;Variables.maxTableFor++; }

            Variables.Money -= busterPrice;
            buyingLayout.active = false;
        }
        else { infotv.text += "\n NOT ENOUGH MONEY"; }
    }

    public void onnotbuyClick() {
        buyButton.interactable = true;
        buyingLayout.active = false;
    }


}
