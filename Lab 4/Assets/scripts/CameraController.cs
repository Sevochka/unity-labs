using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float mouseSensetivity;

    private Transform parent;

    public GameObject canvas;
    // Start is called before the first frame update
    private void Start()
    {
        parent = transform.parent;
        canvas = GameObject.FindGameObjectWithTag("Canvas");
        ReturnToGame();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            canvas.gameObject.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        Rotate();
    }

    private void Rotate()
    {
        if (Cursor.lockState == CursorLockMode.None)
        {
            return;
        }
        
        float mouseX = Input.GetAxis("Mouse X") * mouseSensetivity * Time.deltaTime;
        
        parent.Rotate(Vector3.up, mouseX);   
    }

    public void ReturnToGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        canvas.gameObject.SetActive(false);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
