using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Handles the moles that spawn randomly, game time and text
public class MoleHandler : MonoBehaviour
{
    public GameObject molePrefab;
    public Transform[] spawnPoints;
    public float gameTime;
    public Text gameText;

    // Variable for changing the default shader to one for Sprites
    public Shader defaultSpriteShader;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        gameTime -= Time.deltaTime;
        if (gameTime < 1)
        {
            gameTime = 0;
        }
        gameText.text = gameTime.ToString();
    }

    public void Spawn()
    {
        // Spawns the mole as a game object
        GameObject mole = Instantiate(molePrefab) as GameObject;
        // Picks spawn point from list at random
        mole.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position;

        // Set renderer
        MeshRenderer myRenderer = GetComponentInChildren<MeshRenderer>();
        if (myRenderer)
        {
            myRenderer.material.shader = defaultSpriteShader;
            Debug.Log(defaultSpriteShader == null);
        }
        else
        {
            Debug.Log("No mesh renderer detected");
        }
    }
}
