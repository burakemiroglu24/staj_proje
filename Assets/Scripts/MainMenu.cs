using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MainMenu : MonoBehaviour
{
    public GameObject main_Canvas;
    public GameObject button_Canvas;
    string path = "Assets/dosya.txt";
    public void OnClick1()
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("1 3 1 5 8 120");
        writer.Close();
        main_Canvas.SetActive(true);
        button_Canvas.SetActive(false);
    }
    public void OnClick2()
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("2 3 1 6 8 120");
        writer.Close();
        main_Canvas.SetActive(true);
        button_Canvas.SetActive(false);
    }
    public void OnClick3()
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("3 3 1 2 3 4 120");
        writer.Close();
        main_Canvas.SetActive(true);
        button_Canvas.SetActive(false);
    }
    public void OnClick4()
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("4 4 2 4 4 5 8 150");
        writer.Close();
        main_Canvas.SetActive(true);
        button_Canvas.SetActive(false);
    }
    public void OnClick5()
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("5 4 1 3 7 9 12 150");
        writer.Close();
        main_Canvas.SetActive(true);
        button_Canvas.SetActive(false);
    }
    public void OnClick6()
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("6 4 1 4 4 8 11 150");
        writer.Close();
        main_Canvas.SetActive(true);
        button_Canvas.SetActive(false);
    }
    public void OnClick7()
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("7 4 9 9 9 9 150");
        writer.Close();
        main_Canvas.SetActive(true);
        button_Canvas.SetActive(false);
    }
    public void OnClick8()
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("8 4 1 1 4 4 6 7 150");
        writer.Close();
        main_Canvas.SetActive(true);
        button_Canvas.SetActive(false);
    }
    public void OnClick9()
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("9 5 1 4 5 9 10 11 12 180");
        writer.Close();
        main_Canvas.SetActive(true);
        button_Canvas.SetActive(false);
    }
    public void OnClick10()
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("10 5 1 5 8 8 9 9 10 180");
        writer.Close();
        main_Canvas.SetActive(true);
        button_Canvas.SetActive(false);
    }
    public void OnClick11()
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("11 5 1 3 5 8 9 10 11 180");
        writer.Close();
        main_Canvas.SetActive(true);
        button_Canvas.SetActive(false);
    }
    public void OnClick12()
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("12 5 1 4 4 4 4 10 10 12 180");
        writer.Close();
        main_Canvas.SetActive(true);
        button_Canvas.SetActive(false);
    }
    public void OnClick13()
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("13 5 1 1 1 2 4 6 7 8 11 180");
        writer.Close();
        main_Canvas.SetActive(true);
        button_Canvas.SetActive(false);
    }
    public void onClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
