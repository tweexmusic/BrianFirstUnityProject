using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// GameManager class is resposible for automatically instantiating certain objects in the scene that are always required.
/// </summary>

public class GameManager : MonoBehaviour
{
    public EnemyManager enemyManagerPrefab;
    public Player playerPrefab;
    public WwiseEventPlayer wwiseOneShotPlayerPrefab;


    private void Awake()
    {
        if (Player.instance == null)
        {
            Instantiate(playerPrefab);
        }

        if (EnemyManager.instance == null)
        {
            Instantiate(enemyManagerPrefab);
        }

        if (WwiseEventPlayer.instance == null)
        {
            Instantiate(wwiseOneShotPlayerPrefab);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("PRESS 'A' TO ATTACK WITH PLAYER!");
        Debug.LogWarning("PRESS SPACEBAR TO JUMP WITH PLAYER");
        Debug.LogWarning("PRESS 'B' TO ATTACK WITH BOBOMB!");
        Debug.LogWarning("PRESS 'K' TO ATTACK WITH KOOPA!");
        Debug.LogWarning("PRESS 'G' TO ATTACK WITH GOOMBA!");
        Debug.LogWarning("PRESS 'H' TO ATTACK WITH HAMMER BRO!");
        Debug.LogWarning("PRESS 'S' TO STOP MUSIC!");

    }
}
