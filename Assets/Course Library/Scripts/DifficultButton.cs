using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    [SerializeField] private float difficult;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        button.onClick.AddListener(SetDifficuly);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetDifficuly(){
        // Debug.Log("hello"+gameObject.name);
        gameManager.StartGame(difficult);
    }
}
