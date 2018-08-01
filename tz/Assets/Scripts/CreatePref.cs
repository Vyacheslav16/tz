using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePref : MonoBehaviour {
    public GameObject CrBut;
    public GameObject DelBut;
    public GameObject MovBut;
    public GameObject RotBut;
    public GameObject caps;
    public GameObject gamePadRot;
    public GameObject gamePadRot2;
    public GameObject RotButRed;
    public GameObject MovButRed;
    public GameObject Textm;
    public GameObject text;
    public GameObject Textexam;
    public GameObject leftwhite;
    public GameObject rightwhite;
    public GameObject downwhite;
    public GameObject upwhite;
    public GameObject leftgreen;
    public GameObject rightgreen;
    public GameObject downgreen;
    public GameObject upgreen;
    public GameObject Textm2;
    public GameObject Textm3;
    public bool downRot = false;
    public bool rightRot = false;
    public bool leftRot = false;
    public bool upRot = false;
    public bool d = false;
    public bool left = false;
    public bool up = false;
    public bool down = false;
    public bool right = false;
    public bool z = false;
    public bool k = false;
    public bool e = false;
    public bool s = false;
    public bool sc = false;
    public bool plus = false;
    public bool minus = false;
  //  public GameObject Capsule;
    public Transform bullet;
    public int point;
   // public int size;
   // float leght = 10f;
    public GameObject ScalButNorm;
    public GameObject ScalButRed;
    public GameObject MinBut;
    public GameObject PlusBut;
    private RectTransform rectTransform;

    //public GameObject TestButton;
    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    //GameObject.Find("build").transform.position
    void Update()
    {

        if (z == true) //добавление объектов
            {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bullet, Input.mousePosition, Quaternion.identity);
                point++;//счетчик объектов
            }
            if (point >= 10)
            {
                text.SetActive(true);
            }
            if (point < 10)
            {
                text.SetActive(false);
                
            }
            //if (z == true)
            //{
            //    text.SetActive(true);
            //}
        }
        if (s == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    BoxCollider bc = hit.collider as BoxCollider;
                    if (bc != null)
                    {
                        Textm.SetActive(false);
                        gamePadRot.SetActive(true);

                        if (leftRot == true)
                        {

                            bc.GetComponent<rotate>().MyCap.transform.Rotate(0f, 8f, 0f);
                        }
                        if (rightRot == true)
                        {

                            bc.GetComponent<rotate>().MyCap.transform.Rotate(0f, -8f, 0f);
                        }
                        if (upRot == true)
                        {

                            bc.GetComponent<rotate>().MyCap.transform.Rotate(8f, 0f, 0f);
                        }
                        if (downRot == true)
                        {

                            bc.GetComponent<rotate>().MyCap.transform.Rotate(-8f, 0f, 0f);
                        }

                        //e = true;
                        //if(Input.GetKey(KeyCode.A))
                        //{
                        //    transform.rotation *= Quaternion.Euler(0f, 50f * Time.deltaTime, 0f);
                        //}
                    }
                }
            }
        }
        if (sc == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    BoxCollider bc = hit.collider as BoxCollider;
                    if (bc != null)
                    {
                        Textm3.SetActive(false);
                        MinBut.SetActive(true);
                        PlusBut.SetActive(true);
                        //rectTransform = bc.GetComponent<RectTransform>();
                        //Debug.Log(rectTransform.sizeDelta);
                        //rectTransform.sizeDelta = new Vector3(40f, 40f, 40f);
                        // bc.GetComponent<rotate>().MyCap.transform.localScale = new Vector3(20f, 20f,20f);
                        if (plus == true)
                        {
                            bc.GetComponent<rotate>().x = bc.GetComponent<rotate>().x + 5;
                            bc.GetComponent<rotate>().y = bc.GetComponent<rotate>().y + 5;
                            bc.GetComponent<rotate>().z = bc.GetComponent<rotate>().z + 5;
                        }
                        if (minus == true)
                        {
                            bc.GetComponent<rotate>().x = bc.GetComponent<rotate>().x - 5;
                            bc.GetComponent<rotate>().y = bc.GetComponent<rotate>().y - 5;
                            bc.GetComponent<rotate>().z = bc.GetComponent<rotate>().z - 5;
                        }
                        

                    }
                }
            }
        }
        if (d == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    BoxCollider bc = hit.collider as BoxCollider;
                    if (bc != null)
                    {
                       
                        Textm2.SetActive(false);
                        gamePadRot2.SetActive(true);
                        if (left == true)
                        {
                            
                            bc.GetComponent<rotate>().MyCap.transform.Translate(-5f, 0f, 0f);
                        }
                        if (right == true)
                        {
                            
                            bc.GetComponent<rotate>().MyCap.transform.Translate(5f, 0f, 0f);
                        }
                        if (up == true)
                        {
                           
                            bc.GetComponent<rotate>().MyCap.transform.Translate(0f, 5f, 0f);
                        }
                        if (down == true)
                        {
                         
                            bc.GetComponent<rotate>().MyCap.transform.Translate(0f, -5f, 0f);
                        }


                    }
                }
            }
        }
        if (k == true)//удаление объектов со сцены

            {
                if (Input.GetMouseButtonDown(0))
                {
                    //Vector3 lineOrigins = Input.mousePosition;
                    //Vector3 endline = Input.mousePosition * leght;
                    //Debug.DrawLine(lineOrigins, endline, Color.red);
                    //Ray r = new Ray(lineOrigins,endline);
                    //RaycastHit hit = new RaycastHit();
                    //if (Physics.Raycast(r, out hit, leght))
                    //{

                    //    OnSelect MyObject = hit.collider.GetComponent<OnSelect>();
                    //    if(MyObject != null)
                    //    {
                    //        Debug.Log(MyObject.name);
                    //    }
                    //}

                    //RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                    //if (hit.collider.gameObject == gameObject) Destroy(gameObject);
                    RaycastHit hit;
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit))
                    {
                        BoxCollider bc = hit.collider as BoxCollider;
                        if (bc != null)
                        {
                            Destroy(bc.gameObject);
                            point--;
                            if (point >= 10)
                            {
                                text.SetActive(true);
                            }
                            if (point < 10)
                            {
                                text.SetActive(false);
                            }
                        }
                    }
                }
            }
        }
    public void Creatinvis()
    {
        Textexam.SetActive(false);
        CrBut.SetActive(false);
        DelBut.SetActive(true);
        MovBut.SetActive(true);
        RotBut.SetActive(true);
        gamePadRot.SetActive(false);
        RotButRed.SetActive(false);
        MovButRed.SetActive(false);
        rightgreen.SetActive(false);
        upgreen.SetActive(false);
        downgreen.SetActive(false);
        leftgreen.SetActive(false);
        ScalButNorm.SetActive(true);
        ScalButRed.SetActive(false);
        Textm2.SetActive(false);
        MinBut.SetActive(false);
        PlusBut.SetActive(false);
        z = true;
        sc = false;
        k = false;
        s = false;
        plus = false;
        minus = false;
        d = false;
    }
    public void Creatvis()
    {
        CrBut.SetActive(true);
        z = false;
    }
    public void DelInvis()
    {
        Textexam.SetActive(false);
        DelBut.SetActive(false);
        CrBut.SetActive(true);
        MovBut.SetActive(true);
        RotBut.SetActive(true);
        gamePadRot.SetActive(false);
        RotButRed.SetActive(false);
        MovButRed.SetActive(false);
        rightgreen.SetActive(false);
        upgreen.SetActive(false);
        downgreen.SetActive(false);
        leftgreen.SetActive(false);
        ScalButNorm.SetActive(true);
        ScalButRed.SetActive(false);
        Textm2.SetActive(false);
        MinBut.SetActive(false);
        PlusBut.SetActive(false);
        z = false;
        k = true;
        s = false;
        plus = false;
        minus = false;
        sc = false;
        d = false;
    }
    public void DelVis()
    {
        DelBut.SetActive(true);
        k = false;
        
    }
    public void MovInvis()
    {
        Textexam.SetActive(false);
        MovBut.SetActive(false);
        CrBut.SetActive(true);
        DelBut.SetActive(true);
        RotBut.SetActive(true);
        gamePadRot.SetActive(false);
        RotButRed.SetActive(false);
        MovButRed.SetActive(true);
        Textm2.SetActive(true);
        gamePadRot2.SetActive(false);
        rightgreen.SetActive(false);
        upgreen.SetActive(false);
        downgreen.SetActive(false);
        leftgreen.SetActive(false);
        ScalButNorm.SetActive(true);
        ScalButRed.SetActive(false);
        MinBut.SetActive(false);
        PlusBut.SetActive(false);
        z = false;
        k = false;
        d = true;
        sc = false;
        s = false;
        plus = false;
        minus = false;
    }
    public void MovVis()
    {
        MovBut.SetActive(true);
        MovButRed.SetActive(false);
        Textm2.SetActive(false);
        rightgreen.SetActive(false);
        upgreen.SetActive(false);
        downgreen.SetActive(false);
        leftgreen.SetActive(false);
        d = false;
    }
    public void RotInvis()
    {
        Textexam.SetActive(false);
        RotBut.SetActive(false);
        CrBut.SetActive(true);
        DelBut.SetActive(true);
        MovBut.SetActive(true);
        gamePadRot.SetActive(false);
        RotButRed.SetActive(true);
        MovButRed.SetActive(false);
        rightgreen.SetActive(false);
        upgreen.SetActive(false);
        downgreen.SetActive(false);
        leftgreen.SetActive(false);
        Textm.SetActive(true);
        Textm2.SetActive(false);
        ScalButNorm.SetActive(true);
        ScalButRed.SetActive(false);
        MinBut.SetActive(false);
        PlusBut.SetActive(false);
        z = false;
        k = false;
        s = true;
        d = false;
        plus = false;
        minus = false;
        sc = false;
    }
    public void RotVis()
    {
        Textexam.SetActive(false);
        RotBut.SetActive(true);
        gamePadRot.SetActive(false);
        RotButRed.SetActive(false);
        s = false;
    }
    public void Down()
    {
        Textexam.SetActive(true);
        down = true;
        right = false;
        left = false;
        up = false;
        downgreen.SetActive(true);
        upgreen.SetActive(false);
        upwhite.SetActive(true);
        rightgreen.SetActive(false);
        rightwhite.SetActive(true);
        leftgreen.SetActive(false);
        leftwhite.SetActive(true);
        downwhite.SetActive(false);
    }
    public void Up()
    {
        Textexam.SetActive(true);
        up = true;
        right = false;
        left = false;
        down = false;
        upgreen.SetActive(true);
        downgreen.SetActive(false);
        downwhite.SetActive(true);
        rightgreen.SetActive(false);
        rightwhite.SetActive(true);
        leftgreen.SetActive(false);
        leftwhite.SetActive(true);
        upwhite.SetActive(false);
    }
    public void Right()
    {
        Textexam.SetActive(true);
        right = true;
        left = false;
        up = false;
        down = false;
        rightgreen.SetActive(true);
        upgreen.SetActive(false);
        upwhite.SetActive(true);
        downgreen.SetActive(false);
        downwhite.SetActive(true);
        leftgreen.SetActive(false);
        leftwhite.SetActive(true);
        rightwhite.SetActive(false);
    }
    public void Left()
    {
        Textexam.SetActive(true);
        left = true;
        right = false;
        up = false;
        down = false;
        leftwhite.SetActive(false); 
        leftgreen.SetActive(true);
        upgreen.SetActive(false);
        upwhite.SetActive(true);
        downgreen.SetActive(false);
        downwhite.SetActive(true);
        rightgreen.SetActive(false);
        rightwhite.SetActive(true);
    }

    public void DownRotate()
    {
        Textexam.SetActive(true);
        downRot = true;
        rightRot = false;
        leftRot = false;
        upRot = false;
        //    downgreen.SetActive(true);
        //    upgreen.SetActive(false);
        //    upwhite.SetActive(true);
        //    rightgreen.SetActive(false);
        //    rightwhite.SetActive(true);
        //    leftgreen.SetActive(false);
        //    leftwhite.SetActive(true);
        //    downwhite.SetActive(false);
    }
    public void UpRotate()
    {
        Textexam.SetActive(true);
        upRot = true;
        rightRot = false;
        leftRot = false;
        downRot = false;
        //    upgreen.SetActive(true);
        //    downgreen.SetActive(false);
        //    downwhite.SetActive(true);
        //    rightgreen.SetActive(false);
        //    rightwhite.SetActive(true);
        //    leftgreen.SetActive(false);
        //    leftwhite.SetActive(true);
        //    upwhite.SetActive(false);
    }
    public void RightRotate()
    {
        Textexam.SetActive(true);
        rightRot = true;
        leftRot = false;
        upRot = false;
        downRot = false;
        //    rightgreen.SetActive(true);
        //    upgreen.SetActive(false);
        //    upwhite.SetActive(true);
        //    downgreen.SetActive(false);
        //    downwhite.SetActive(true);
        //    leftgreen.SetActive(false);
        //    leftwhite.SetActive(true);
        //    rightwhite.SetActive(false);
    }
    public void LeftRotate()
    {
        Textexam.SetActive(true);
        leftRot = true;
        rightRot = false;
        upRot = false;
        downRot = false;

        //    leftwhite.SetActive(false);
        //    leftgreen.SetActive(true);
        //    upgreen.SetActive(false);
        //    upwhite.SetActive(true);
        //    downgreen.SetActive(false);
        //    downwhite.SetActive(true);
        //    rightgreen.SetActive(false);
        //    rightwhite.SetActive(true);
    }
    public void Dob()
    {
        Instantiate(caps);
    }
    public void ScalNorm()
    {
        Textexam.SetActive(false);
        Textm3.SetActive(true);
        ScalButNorm.SetActive(false);
        ScalButRed.SetActive(true);
        DelBut.SetActive(true);
        CrBut.SetActive(true);
        MovBut.SetActive(true);
        RotBut.SetActive(true);
        gamePadRot.SetActive(false);
        RotButRed.SetActive(false);
        MovButRed.SetActive(false);
        rightgreen.SetActive(false);
        upgreen.SetActive(false);
        downgreen.SetActive(false);
        leftgreen.SetActive(false);
        sc = true;
        z = false;
        k = false;
        s = false;
        d = false;
        leftRot = false;
        rightRot = false;
        upRot = false;
        downRot = false;
        plus = false;
        minus = false;
    }
    public void Plus()
    {
        down = false;
        right = false;
        left = false;
        up = false;
        Textexam.SetActive(true);
        plus = true;
        minus = false;
    }
    public void Minus()
    {
        down = false;
        right = false;
        left = false;
        up = false;
        minus = true;
        plus = false;
        Textexam.SetActive(true);
        //Renderer rend = TestButton.GetComponent<Renderer>();
        //Color col = Color.red;
        //rend.material.color = col;

    }
    public void ScalRed()
    {
        Textexam.SetActive(false);

        sc = false;
        ScalButNorm.SetActive(true);
        ScalButRed.SetActive(false);
        MinBut.SetActive(false);
        PlusBut.SetActive(false);
            }
}
