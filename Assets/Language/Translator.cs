using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translator : MonoBehaviour {

    public static string buyString, backString, priceString;
    //MAINMENU
    public static string dayMenu, playMenu, shopMenu, quitMenu, resetallgameMenu;
    public static string infoMenu, yesButtonMenu, noButtonMenu;
    //SHOP
    public static string backtoMenuShop;
    public static string fastEating1Shop, fastEating2Shop,fastEating3Shop;
    public static string freshFood1Shop, freshFood2Shop, freshFood3Shop, freshFood4Shop;
    public static string markup1Shop, markup2Shop, markup3Shop, markup4Shop;
    public static string moreperson1Shop, moreperson2Shop, moreperson3Shop;
    public static string tablebuying1Shop, tablebuying2Shop, tablebuying3Shop, morespaceShop;
    //BEFORE START GAME
    public static string infoBeforeStartGame;
    //GAMEPLAY
    public static string resetGameplay, doneGameplay, tableTopGameplay, tableBottomGameplay, noTableForYouGameplay, byebyeGameplay;

    public static string twoG, threeG, fourG, fiveG, sixG, sevenG, eightG, nineG;
    public static string pleaseG, andG;
    public static string orderG1, orderG2, orderG3, orderG4;

    public static string d1NameG, d2NameG, m1NameG, m2NameG, s1NameG, s2NameG;
    public static string glassG, glassesG, servingG, servingsG, pieceG, piecesG;
    public static string d1BillG, d2BillG, m1BillG, m2BillG, s1BillG, s2BillG;
    public static string notmyOrderG, myOrder, notenoughforOrderG;

    static public void setEnglish() {
        buyString = "Buy";backString = "Back";priceString = "\nPrice: ";
        //MAIN MENU
        dayMenu = "Day "; playMenu = "Play"; shopMenu = "Shop"; quitMenu = "Quit"; resetallgameMenu = "Reset all Game";
        infoMenu = "Are you shure you want to restart all game and all your progress?";
        yesButtonMenu = "Yes"; noButtonMenu = "No, Never!";
        //SHOP
        backtoMenuShop = "Back to menu";

        fastEating1Shop = "Cliensts will eat more quickly \n Already they are eating: "; fastEating2Shop = " secounds faster"; fastEating3Shop = "They can not eat faster!";

        freshFood1Shop = "Less food will be off in the end of the day!\n Naw ";freshFood2Shop = " of your food will survive\nWhen you buy you save ";
        freshFood3Shop = " of them!"; freshFood4Shop= "You are saving 100% of you food I can not give you more";

        markup1Shop= "Make your restaurant more expensive!\n Naw markup: "; markup2Shop= "\n Buying: "; 
        markup3Shop= " markup"; markup4Shop= "It is the highest lvl your markup is 300%";

        moreperson1Shop = "To your restaurant will come bigger grup of client\nNaw: "; moreperson2Shop = "\nBuying: "; moreperson3Shop= "It is the highest lvl your grup: 6";

        tablebuying1Shop = "Better Table for:\n "; tablebuying2Shop = " person"; tablebuying3Shop= "it is the highest lvl of this table!";
        morespaceShop = "Buy more space for your restaurant!";
        //BEFORE START GAME
        infoBeforeStartGame= "Buy Food to your Restaurant!";
        //GAMEPLAY
        resetGameplay = "RESET"; doneGameplay = "DONE";
        tableTopGameplay = "Restaurant Top"; tableBottomGameplay = "Restaurant Bottom";
        noTableForYouGameplay = "No Table for You, Sorry"; byebyeGameplay = "Bye, Bye.";
        //INTERPRETER
        twoG = " two "; threeG = " three "; fourG = " four "; fiveG = " five "; sixG = " six "; sevenG = " seven "; eightG = " eight "; nineG=" nine ";
        pleaseG = " Please."; andG=" and";
        orderG1 = "Can I get"; orderG2 = "May I have"; orderG3 = "Do you have"; orderG4 = "Can I order";

        d1NameG = "juice"; d2NameG = "beer"; m1NameG = "dumplings"; m2NameG = "chicken with chips"; s1NameG = "ice fruit"; s2NameG = "cake";
        glassG = " a glass of "; glassesG = " glasses of "; servingG = " a serving of "; servingsG = " servings of "; pieceG = " piece of "; piecesG = " pieces of ";
        //BILL
        d1BillG = "Juice"; d2BillG = "Beer"; m1BillG = "Dumplings"; m2BillG = "Chicken"; s1BillG = "Ice-Cream"; s2BillG="Cake";

        notmyOrderG = "Ii wasn't my order!!!"; myOrder = "Thanks!"; notenoughforOrderG= "There is nothing for me";



    }
static public void setPolish() {
        buyString = "Kup"; backString = "Powtót"; priceString = "\nCena to: ";
         //MAIN MENU
         dayMenu = "Dzień "; playMenu = "Graj"; shopMenu = "Sklep"; quitMenu = "Wyjście"; resetallgameMenu = "Zresetuj gre";
        infoMenu = "Czy napewno chcesz utracić cały progres i rozpocząć gre na nowo?";
        yesButtonMenu = "Tak"; noButtonMenu = "Nie, Nigdy!";
        //SHOP
        backtoMenuShop = "Powrót do menu";

        fastEating1Shop = "Klienci będą jeść o wiele szybciej (całe 5 sekund krócej!!!)\n Aktualnie Twoi klienci jedzą o całe: "; fastEating2Shop=" sekund krócej!\nMaksymalny bonus to 50 sekund"; fastEating3Shop = "Nie można już jeść szybciej!";

        freshFood1Shop = "Kup super lodówkę, która pozwoli Ci przechowac więcej jedzenia \nTeraz: "; freshFood2Shop = " twojego jedzenia zostaje przechowane na drugi dzień\nPo zakupie :";
        freshFood3Shop = "produktów nie zepsuje się"; freshFood4Shop = "Masz najlepszą lodówke na świecie! Żaden produkt się w niej nigdy nie zepsuje!";

        markup1Shop="Podnieś ceny w restauracji by zarobić więcej!\nTeraźniejsza marża: "; markup2Shop="\nKupując nałożysz ";
        markup3Shop=" marżę"; markup4Shop="No bez przesady ty chciwy człowieku! 300% marża napewno wystarczy ";

        moreperson1Shop = "Do twojej restauracji będą przychodzić większe grupy klientów!\nMaksymalna grupa teraz: "; moreperson2Shop = "\nPo zakupie największa grupa to: "; moreperson3Shop = "It is the highest lvl your grup: 6";

        tablebuying1Shop = "Lepszy stolik dla :\n"; tablebuying2Shop =" osób" ; tablebuying3Shop ="Niestety u nas się nie da kupić 7 osobowego stolika ";
        morespaceShop = "Kup więcej przestrzeni dla twojego lokalu!";
        //BEFORE START GAME
        infoBeforeStartGame="Kup jedzenie do swojej restauracji!";
        //GAMEPLAY
        resetGameplay = "pomyłka"; doneGameplay = "Gotowe!";
        tableTopGameplay = "Restauracja góra"; tableBottomGameplay = "Restauracja dół";
        noTableForYouGameplay = "O nie! Wszystkie stoliki są zajęte"; byebyeGameplay = "Pa, pa.";
        //INTERPRETER
        twoG = " dwie "; threeG = " trzy "; fourG = " cztery "; fiveG = " pięć "; sixG = " sześć "; sevenG = " siedem "; eightG = " osiem "; nineG = " dziewięć ";
        pleaseG = ""; andG = " i";
        orderG1 = "Chciałbym zamówić:"; orderG2 = "Dla mnie:"; orderG3 = "Poprosze:"; orderG4 = "Macie może:";

        d1NameG = "soku pomarańczowego"; d2NameG = "piwa"; m1NameG = "pierogów"; m2NameG = "kurczaka z frytkami"; s1NameG = "lodów owocowych"; s2NameG = "ciasta";
        glassG = " szklanke "; glassesG = " szklanki "; servingG = " porcje "; servingsG = " porcje "; pieceG = " kawałek "; piecesG = " kawałki ";
        //BILL
        d1BillG = "Sok"; d2BillG = "Piwo"; m1BillG = "Pierogi"; m2BillG = "Kurczak"; s1BillG = "Lody"; s2BillG = "Ciasto";

        notmyOrderG = "To nie jest moje zamówienie, Wychodzę!"; myOrder = "Dzięki wielkie!"; notenoughforOrderG = "Nic tu po mnie widzę, że nie masz tego co chce zjeść";


    }
}
