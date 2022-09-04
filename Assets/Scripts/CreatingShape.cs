using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
public class CreatingShape : MonoBehaviour
{
    private Vector3 mouse1;
    private int gameID;
    private int GridSize;
    [SerializeField]
    private double tileSize;
    private SpriteRenderer[] sprites;
    private List<Color> _color = new List<Color>();
    void Awake()
    {
        string path = "Assets/dosya.txt";
        StreamReader reader = new StreamReader(path);
        string text = reader.ReadToEnd();
        string[] textsplit = text.Split(" ");
        gameID = Int16.Parse(textsplit[0]);
        GridSize = Int16.Parse(textsplit[1]);
        reader.Close();

        GameObject referenceTile = (GameObject)Instantiate(Resources.Load(GridSize + "x" + GridSize));
        GameObject tile = Instantiate(referenceTile, transform);
        tile.transform.position = new Vector2(0, 0);
        Destroy(referenceTile);

        double gridW = GridSize * tileSize;
        double gridH = GridSize * tileSize;
        if (GridSize == 4)
        {
            transform.position = new Vector2((float)(-gridW / 2 + tileSize / 2) + (float)(0.655 / 2), (float)(gridH / 2 - tileSize / 2) + (float)(0.655 * 3 / 2));
        }
        else
        {
            transform.position = new Vector2((float)(-gridW / 2 + tileSize / 2), (float)(gridH / 2 - tileSize / 2) + (float)1.965);
        }
        AddColor();
        switch (gameID)
        {
            case 1:
                for (int i = 0; i < textsplit.Length-3; i++)
                {
                    GameObject reference_block = (GameObject)Instantiate(Resources.Load("block" + textsplit[i+2]));
                    GameObject block= Instantiate(reference_block, transform);
                    block.transform.position = new Vector2(UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-1.5f, -4f));
                    Destroy(reference_block);
                    sprites = block.GetComponentsInChildren<SpriteRenderer>();
                    foreach (SpriteRenderer sprite in sprites)
                    {
                        sprite.color = _color[i];
                    }
                }
                break;

            case 2:
                for (int i = 0; i < textsplit.Length - 3; i++)
                {
                    GameObject reference_block = (GameObject)Instantiate(Resources.Load("block" + textsplit[i+2]));
                    GameObject block = Instantiate(reference_block, transform);
                    block.transform.position = new Vector2(UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-1.5f, -4f));
                    Destroy(reference_block);
                    sprites = block.GetComponentsInChildren<SpriteRenderer>();
                    foreach (SpriteRenderer sprite in sprites)
                    {
                        sprite.color = _color[i];
                    }
                }

                break;

            case 3:
                for (int i = 0; i < textsplit.Length - 3; i++)
                {
                    GameObject reference_block = (GameObject)Instantiate(Resources.Load("block" + textsplit[i + 2]));
                    GameObject block = Instantiate(reference_block, transform);
                    block.transform.position = new Vector2(UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-1.5f, -4f));
                    Destroy(reference_block);
                    sprites = block.GetComponentsInChildren<SpriteRenderer>();
                    foreach (SpriteRenderer sprite in sprites)
                    {
                        sprite.color = _color[i];
                    }
                }
                break;

            case 4:
                for (int i = 0; i < textsplit.Length - 3; i++)
                {
                    GameObject reference_block = (GameObject)Instantiate(Resources.Load("block" + textsplit[i + 2]));
                    GameObject block = Instantiate(reference_block, transform);
                    block.transform.position = new Vector2(UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-1.5f, -4f));
                    Destroy(reference_block);
                    sprites = block.GetComponentsInChildren<SpriteRenderer>();
                    foreach (SpriteRenderer sprite in sprites)
                    {
                        sprite.color = _color[i];
                    }
                }
                break;

            case 5:
                for (int i = 0; i < textsplit.Length - 3; i++)
                {
                    GameObject reference_block = (GameObject)Instantiate(Resources.Load("block" + textsplit[i + 2]));
                    GameObject block = Instantiate(reference_block, transform);
                    block.transform.position = new Vector2(UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-1.5f, -4f));
                    Destroy(reference_block);
                    sprites = block.GetComponentsInChildren<SpriteRenderer>();
                    foreach (SpriteRenderer sprite in sprites)
                    {
                        sprite.color = _color[i];
                    }
                }
                break;

            case 6:
                for (int i = 0; i < textsplit.Length - 3; i++)
                {
                    GameObject reference_block = (GameObject)Instantiate(Resources.Load("block" + textsplit[i + 2]));
                    GameObject block = Instantiate(reference_block, transform);
                    block.transform.position = new Vector2(UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-1.5f, -4f));
                    Destroy(reference_block);
                    sprites = block.GetComponentsInChildren<SpriteRenderer>();
                    foreach (SpriteRenderer sprite in sprites)
                    {
                        sprite.color = _color[i];
                    }
                }
                break;
            case 7:
                for (int i = 0; i < textsplit.Length - 3; i++)
                {
                    GameObject reference_block = (GameObject)Instantiate(Resources.Load("block" + textsplit[i + 2]));
                    GameObject block = Instantiate(reference_block, transform);
                    block.transform.position = new Vector2(UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-1.5f, -4f));
                    Destroy(reference_block);
                    sprites = block.GetComponentsInChildren<SpriteRenderer>();
                    foreach (SpriteRenderer sprite in sprites)
                    {
                        sprite.color = _color[i];
                    }
                }
                break;

            case 8:
                for (int i = 0; i < textsplit.Length - 3; i++)
                {
                    GameObject reference_block = (GameObject)Instantiate(Resources.Load("block" + textsplit[i + 2]));
                    GameObject block = Instantiate(reference_block, transform);
                    block.transform.position = new Vector2(UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-1.5f, -4f));
                    Destroy(reference_block);
                    sprites = block.GetComponentsInChildren<SpriteRenderer>();
                    foreach (SpriteRenderer sprite in sprites)
                    {
                        sprite.color = _color[i];
                    }
                }
                break;

            case 9:
                for (int i = 0; i < textsplit.Length - 3; i++)
                {
                    GameObject reference_block = (GameObject)Instantiate(Resources.Load("block" + textsplit[i + 2]));
                    GameObject block = Instantiate(reference_block, transform);
                    block.transform.position = new Vector2(UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-1.5f, -4f));
                    Destroy(reference_block);
                    sprites = block.GetComponentsInChildren<SpriteRenderer>();
                    foreach (SpriteRenderer sprite in sprites)
                    {
                        sprite.color = _color[i];
                    }
                }
                break;

            case 10:
                for (int i = 0; i < textsplit.Length - 3; i++)
                {
                    GameObject reference_block = (GameObject)Instantiate(Resources.Load("block" + textsplit[i + 2]));
                    GameObject block = Instantiate(reference_block, transform);
                    block.transform.position = new Vector2(UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-1.5f, -4f));
                    Destroy(reference_block);
                    sprites = block.GetComponentsInChildren<SpriteRenderer>();
                    foreach (SpriteRenderer sprite in sprites)
                    {
                        sprite.color = _color[i];
                    }
                }
                break;

            case 11:
                for (int i = 0; i < textsplit.Length - 3; i++)
                {
                    GameObject reference_block = (GameObject)Instantiate(Resources.Load("block" + textsplit[i + 2]));
                    GameObject block = Instantiate(reference_block, transform);
                    block.transform.position = new Vector2(UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-1.5f, -4f));
                    Destroy(reference_block);
                    sprites = block.GetComponentsInChildren<SpriteRenderer>();
                    foreach (SpriteRenderer sprite in sprites)
                    {
                        sprite.color = _color[i];
                    }
                }
                break;

            case 12:
                for (int i = 0; i < textsplit.Length - 3; i++)
                {
                    GameObject reference_block = (GameObject)Instantiate(Resources.Load("block" + textsplit[i + 2]));
                    GameObject block = Instantiate(reference_block, transform);
                    block.transform.position = new Vector2(UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-1.5f, -4f));
                    Destroy(reference_block);
                    sprites = block.GetComponentsInChildren<SpriteRenderer>();
                    foreach (SpriteRenderer sprite in sprites)
                    {
                        sprite.color = _color[i];
                    }
                }
                break;

            case 13:
                for (int i = 0; i < textsplit.Length - 3; i++)
                {
                    GameObject reference_block = (GameObject)Instantiate(Resources.Load("block" + textsplit[i + 2]));
                    GameObject block = Instantiate(reference_block, transform);
                    block.transform.position = new Vector2(UnityEngine.Random.Range(-2f, 2f), UnityEngine.Random.Range(-1.5f, -4f));
                    Destroy(reference_block);
                    sprites = block.GetComponentsInChildren<SpriteRenderer>();
                    foreach (SpriteRenderer sprite in sprites)
                    {
                        sprite.color = _color[i];
                    }
                }
                break;
        }
        Vector3 first_position = this.transform.position;
        first_position.y -= 0.655f*20;
        this.transform.position = first_position;
    }
    private void AddColor()
    {
        Color color1 = Color.white;
        Color color2 = Color.blue;
        Color color3 = Color.cyan;
        Color color4 = Color.yellow;
        Color color5 = Color.green;
        Color color6 = Color.grey;
        Color color7 = Color.magenta;
        Color color8 = Color.red;
        Color color9 = Color.black;
        _color.Add(color1);
        _color.Add(color2);
        _color.Add(color3);
        _color.Add(color4);
        _color.Add(color5);
        _color.Add(color6);
        _color.Add(color7);
        _color.Add(color8);
        _color.Add(color9);
    }
    private void Update()
    {
        Vector3 last_position = new Vector3(-0.655f,2.62f, 0);
        Vector3 position = new Vector3(0, 0.655f, 0);
        if(this.transform.position.y< last_position.y)
        {
            this.transform.position+= position;
        }
    }
}
