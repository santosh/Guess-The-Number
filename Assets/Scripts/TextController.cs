using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    private enum States {
        cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1,
        corridor_0, stairs_0, stairs_1, stairs_2, courtyard, floor,
        corridor_1, corridor_2, corridor_3, closet_door, in_closet
        };
    private States myState;

    // Use this for initialization
    void Start () {
        myState = States.cell;
    }
    
    // Update is called once per frame
    void Update () {
        print(myState);
        if      (myState == States.cell)            {cell();}
        else if (myState == States.sheets_0)        {sheet_0();}
        else if (myState == States.sheets_1)        {sheet_1();}
        else if (myState == States.mirror)          {mirror();}
        else if (myState == States.lock_0)          {lock_0();}
        else if (myState == States.cell_mirror)     {cell_mirror();}
        else if (myState == States.lock_1)          {lock_1();}
        else if (myState == States.corridor_0)      {corridor_0();}
        else if (myState == States.stairs_0)        {stairs_0();}
        else if (myState == States.stairs_1)        {stairs_1();}
        else if (myState == States.stairs_2)        {stairs_2();}
        else if (myState == States.courtyard)       {courtyard();}
        else if (myState == States.floor)           {floor();}
        else if (myState == States.corridor_1)      {corridor_1();}
        else if (myState == States.corridor_2)      {corridor_2();}
        else if (myState == States.corridor_3)      {corridor_3();}
        else if (myState == States.closet_door)     {closet_door();}
        else if (myState == States.in_closet)       {in_closet();}
    }

    void in_closet() {
        text.text = "Almari me ta aego dress baa, safai kare wala ke lagat baa, ekdum tohar size ke! " +
            "Laga ta kismat khule ke ba.\n\n" +
            "Press D to Dress up, or R to Return to the corridor";
        if      (Input.GetKeyDown(KeyCode.R))       {myState = States.corridor_2;}
        else if (Input.GetKeyDown(KeyCode.D))       {myState = States.corridor_3;}
    }

    void closet_door() {
        text.text = "Tu ab almaari ke kewadi pe dekhat h, badkismati se uu band ba. " +
            "Kuch khojal jaa sakela ka, khole khati?\n\n" +
            "Press R to Return to the corridor"; 
        if      (Input.GetKeyDown(KeyCode.R))       {myState = States.corridor_0;}
    }

    void corridor_3() { 
        text.text = "Galiyara me aa gela, safai wala karamchari ban gela ekdum. " + 
            "Laga ta ki nikle me jada dikkat na hoi ab.\n\n" + 
            "Press S to take the Stairs, or U to Undress"; 
        if      (Input.GetKeyDown(KeyCode.S))       {myState = States.courtyard;} 
        else if (Input.GetKeyDown(KeyCode.U))       {myState = States.in_closet;}
    }

    void corridor_2() {
        text.text = "Wapas galiyara me aa gela, Koi dusra idea soche ke padi.\n\n" + 
            "Press C to revisit the Closet, and S to climb the stairs"; 
        if      (Input.GetKeyDown(KeyCode.C))       {myState = States.in_closet;} 
        else if (Input.GetKeyDown(KeyCode.S))       {myState = States.stairs_2;}
    }

    void corridor_1() { 
        text.text = "Fir se galiyara me. Jameen pe gandagi. Hath me hairclip. " + 
            "Ab kaa? Tu sochat hauua ki hairclip se talwa kholal jaa sakela ka?\n\n" + 
            "P to Pick the lock, and S to climb the stairs"; 
        if      (Input.GetKeyDown(KeyCode.P))       {myState = States.in_closet;} 
        else if (Input.GetKeyDown(KeyCode.S))       {myState = States.stairs_1;}
    }
   
    void floor () {
        text.text = "Bada dhyaan se khojla ke baad khali aego hairclip milal, baaki to kachra lagat baa.\n\n" + 
            "Press R to Return to the standing, or H to take the Hairclip." ; 
        if      (Input.GetKeyDown(KeyCode.R))       {myState = States.corridor_0;} 
        else if (Input.GetKeyDown(KeyCode.H))       {myState = States.corridor_1;}
    }

    void courtyard () {
        text.text = "Safai karmchari ban ke angan se bahar jait h. " + 
            "Guard san bhi sab tohar kaam se khush badan sa. " + 
            "Tohar dil jor jor se dhadkat ba.\n\n" + 
            "Press P to Play again." ; 
        if      (Input.GetKeyDown(KeyCode.P))        {myState = States.cell;}
    }

    void stairs_1 () {
        text.text = "Badkismati se tanni chuke hairclip hath me lela se aetna bhi " + 
           "confidence na aa gail ki banduk se laes guard se bharal angan se nikal gaiba!\n\n" + 
           "Press R to Retreat down the stairs" ; 
        if      (Input.GetKeyDown(KeyCode.R))        {myState = States.corridor_1;}
    }

    void stairs_2() {
        text.text = "Tohke to naaz baa ki hairclip abhi bhi tora pass ba. Lekin almari khole " + 
            "ke baad thoda tedha ho gail baa. Etna kare ka baad bhi aetna confidence na baa " + 
            "sidhi se upar jaa ke aapan maut se mil jaain!\n\n" + 
            "Press R to Return to the corridor"; 
        if      (Input.GetKeyDown(KeyCode.R))        {myState = States.corridor_2;}
    }

    void stairs_0() {
        text.text = "Aangna me jaat bada. " +
            "Tohke jaldiye samajh me aa gail ki tu pakdael ja sake la. " +
            "Fatak ne niche jaa ke soche ke padi.\n\n" +
            "Press R to Return to the corridor.";
        if      (Input.GetKeyDown(KeyCode.R))        {myState = States.corridor_0;}
    }

    void cell() {
        text.text = "Tu jail me bada a tora ke nikle ke ba. Bichhauna " + 
            "pe kuch purana kagaj baa, diwall pe aego ainak, aau " + 
            "kenwadi bahre se tala lagal baa.\n\n" + 
            "Press S to view Sheets, M to view Mirror and L to view Lock" ;
        if      (Input.GetKeyDown(KeyCode.S))       {myState = States.sheets_0;}
        else if (Input.GetKeyDown(KeyCode.M))       {myState = States.mirror;}
        else if (Input.GetKeyDown(KeyCode.L))       {myState = States.lock_0;}
    }

    void mirror() {
        text.text = "Lagata ainakwa dhila ba. Kaahe ho?\n\n" + 
            "Press T to Take the mirror, or R to Return to cell.";
        if      (Input.GetKeyDown(KeyCode.T))        {myState = States.cell_mirror;}
        else if (Input.GetKeyDown(KeyCode.R))        {myState = States.cell;}
    }

    void sheet_0() {
        text.text = "Ee kagajwa pe bharosa na karal jaa sakela. Ee kauno " + 
            "maza leve khatir likhle badan sab jail ke logan.\n\n" + 
            "Press R to Return to roaming your cell.";
        if      (Input.GetKeyDown(KeyCode.R))       {myState = States.cell;}
    }

    void sheet_1() {
        text.text = "Hath me ainak leve se kagajwa badhiya na dikhi\n\n" +
            "Press R to Return to roaming your cell.";
        if      (Input.GetKeyDown(KeyCode.R))       {myState = States.cell_mirror;}
    }

    void lock_0() {
        text.text = "Battam wala tala ba ho! Tora ke kuchho pata naikhe " +
            "key combination ke baare me. Kaisahu agar fingerprint dekhal jaa " +
            "sake ta baat ban jaai. Laga ta gandagi ke nisan baa keypad par.\n\n" +
            "Press R to Return to roaming your cell.";
        if      (Input.GetKeyDown(KeyCode.R))       {myState = States.cell;}
    }

    void lock_1() {
        text.text = "Ekdum savdhani se ainakwa ke jailwa ke dandiya ke paar kar dehla, " + 
            "ainakwa ke ghumaila se tohra ke tala lauke lagal. Ganda fingerprint wala " + 
            "button lauke lagal. Tu ganda button dabaite jaat hauaa, click ke awaaz aael.\n\n" + 
            "Press O to Open, or R to Return to your cell.";
        if      (Input.GetKeyDown(KeyCode.O))       {myState = States.corridor_0;}
        else if (Input.GetKeyDown(KeyCode.R))       {myState = States.cell_mirror;}
    }

    void cell_mirror() {
        text.text = "Ainakwa le ke ka sawarba ab? Tohke bahar nikle ke baa " +
            "bed pa aego purana kagaj baa, aego nisaan jahan ainak rahal, " +
            "aego harami darwaza, jo ki khulat naikhe!\n\n" +
            "Press S to view Sheets, or L to view Lock" ;
        if      (Input.GetKeyDown(KeyCode.S))       {myState = States.sheets_1;}
        else if (Input.GetKeyDown(KeyCode.L))       {myState = States.lock_1;}
    }

    void corridor_0() {
        text.text = "Tu jail ke room se bahare nikal gaila, lekin musibat abhi talal na." +
            "Tu galiyare me haaua, aego almari ba aa sidhi ba, jauna ki angna me le jaai " +
            "Floor bhi achha halat me naikhe, ganda ba.\n\n" +
            "C to view the Closet, F to inspect the Floor, and S to climb the stairs";
        if      (Input.GetKeyDown(KeyCode.S))       {myState = States.stairs_0;} 
        else if (Input.GetKeyDown(KeyCode.F))       {myState = States.floor;} 
        else if (Input.GetKeyDown(KeyCode.C))       {myState = States.closet_door;}
    }

}
// TODO: put the texts in another base and call, to make script more clear.
// TODO: Do a time travel paradox.