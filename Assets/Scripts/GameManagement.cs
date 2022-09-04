using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
public class GameManagement : MonoBehaviour
{
    private GameObject textDisplay;
    private int secondLeft;
    private bool takingAway = false;

    private Vector3 mousePositionOffset;
    private Vector3 mouse;
    private Vector3 first_position;
    private List<Transform> transforms;
    private int gameID;
    private int GridSize;
    private static int sorting_layer = 5;
    string[] textsplit;
    private IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondLeft -= 1;
        textDisplay.GetComponent<Text>().text = "seviye: " + gameID + " süre: " + secondLeft;
        takingAway = false;
    }
    private Vector3 MouseWorldPosition => Camera.main.ScreenToWorldPoint(Input.mousePosition);
    private void OnMouseDown()
    {
        first_position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        Renderer[] myRenderer = GetComponentsInChildren<Renderer>();
        foreach (Renderer renderer in myRenderer)
        {
            renderer.sortingOrder = sorting_layer;
        }
        sorting_layer++;
        mousePositionOffset = gameObject.transform.position - MouseWorldPosition;
        mouse = Input.mousePosition;
    }
    private int NumberOfFullBoxes()
    {
       int FullBox = 0;
       GameObject block = GameObject.Find("main_canvas/block");
       for(int k=0;k<block.transform.GetChild(0).gameObject.transform.childCount;k++)
        {
            for (int i = 1; i < block.transform.childCount; i++)
            {
                for (int j = 0; j < block.transform.GetChild(i).gameObject.transform.childCount; j++)
                {
                    if (Rounding(block.transform.GetChild(0).gameObject.transform.GetChild(k).transform.position.x) == Rounding(block.transform.GetChild(i).gameObject.transform.GetChild(j).position.x) && Rounding(block.transform.GetChild(0).gameObject.transform.GetChild(k).transform.position.y) == Rounding(block.transform.GetChild(i).gameObject.transform.GetChild(j).position.y))
                    {
                        FullBox++;
                    }
                }

            }
        }
    return FullBox;
    }
    private void OnMouseUp()
    {
        if (IsOverleap())
        {
            this.transform.position = first_position;
        }
        else if (NumberOfFullBoxes()== (GridSize * GridSize))
        {
            GameObject tablo=GameObject.Find("main_canvas/tablo");
            GameObject block = GameObject.Find("main_canvas/block");
            tablo.GetComponent<Text>().text = "Tebrikler. Ana Menüye Dönmek için sað üstteki butona týklayýnýz.  Skorunuz: 150. ";
            block.SetActive(false);
            GameObject text=GameObject.Find("main_canvas/TimeText");
            text.SetActive(false);
        }
        else if (Input.mousePosition == mouse)
        {
            transform.Rotate(0, 0, 90);
            if (IsOverleap())
            {
                transform.Rotate(0, 0, -90);
            }
        }
    }
    public double Rounding(float x)
    {
        double a = Math.Round(x, 3);
        return a;
    }
    public bool IsOverleap()
    {
        List<GameObject> blocks = new List<GameObject>();
        GameObject block = GameObject.Find("main_canvas/block");
        for(int i=1;i< block.transform.childCount;i++)
        {
           blocks.Add(block.transform.GetChild(i).gameObject);
        }
        for(int i=0;i<blocks.Count;i++)
        {
           if (this.gameObject== blocks[i]) blocks.Remove(blocks[i]);
        }
        for (int i = 0; i < this.transform.childCount; i++)
        {
            for (int j = 0; j < blocks.Count; j++)
            {
                for (int a = 0; a < blocks[j].transform.childCount; a++)
                {

                    if (Rounding(this.transform.GetChild(i).gameObject.transform.position.x) == Rounding(blocks[j].transform.GetChild(a).transform.position.x) && Rounding(this.transform.GetChild(i).gameObject.transform.position.y) == Rounding(blocks[j].transform.GetChild(a).transform.position.y) && Rounding(this.transform.GetChild(i).gameObject.transform.position.z) == Rounding(blocks[j].transform.GetChild(a).transform.position.z))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    private void OnMouseDrag()
    {
       transform.position = MouseWorldPosition + mousePositionOffset;
    }
    private void Awake()
    {
        string path = "Assets/dosya.txt";
        StreamReader reader = new StreamReader(path);
        string text = reader.ReadToEnd();
        textsplit = text.Split(" ");
        gameID = Int16.Parse(textsplit[0]);
        GridSize = Int16.Parse(textsplit[1]);
        reader.Close();
    }
    private void Start()
    {
        secondLeft = Int16.Parse(textsplit[textsplit.Length- 1]);
        textDisplay = GameObject.Find("main_canvas/TimeText");
        textDisplay.GetComponent<Text>().text = "seviye: "+gameID+" süre: "+secondLeft;
        string path = "Assets/dosya.txt";
        File.Delete(path);
    }
    private void Update()
    {
        if(takingAway==false && secondLeft>0)
        {
            StartCoroutine(TimerTake());
        }
        if(secondLeft==0)
        {
            GameObject tablo = GameObject.Find("main_canvas/tablo");
            GameObject block = GameObject.Find("main_canvas/block");
            float score = (float)NumberOfFullBoxes() / (float)(GridSize * GridSize)*100;
            double final_score = Math.Round(score, 0); ;
            tablo.GetComponent<Text>().text = "Süren bitti :(( Ana Menüye Dönmek için sað üstteki butona týklayýnýz. Skorunuz: " + final_score + ".";
            block.SetActive(false);
            GameObject text = GameObject.Find("main_canvas/TimeText");
            text.SetActive(false);
        }
    }
}