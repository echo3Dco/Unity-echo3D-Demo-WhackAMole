using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Controls the hammer that smashes the moles
public class HammerHandler : MonoBehaviour
{
    public Text scoreText;
    public int score;

    private MoleHandler moleSpawner;

    void Start()
    {
        score = 0;
        
        // Reference MoleHandler script
        moleSpawner = GetComponent<MoleHandler>();
    }

    void Update()
    {
        // If mouse is over object, destroy it
        if(Input.GetButtonDown("Fire1") && moleSpawner.gameTime > 0)
        {
            // Converting z coordinate to x for 2D
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
           
            if(hit.collider != null)
            {
                Destroy(hit.transform.gameObject);
                score += 1;
                scoreText.text = score.ToString();
                moleSpawner.Spawn();
                Debug.Log("Mole hit", hit.transform.gameObject);
            }
        }
    }
}
