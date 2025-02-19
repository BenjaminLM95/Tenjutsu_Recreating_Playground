using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, GameInput.IPlayerMovementsActions
{
    private GameInput gameInput;

    public void OnMovements(InputAction.CallbackContext context)
    {
        //Debug.Log("moving"); 
        Actions.MoveEvent?.Invoke(context.ReadValue<Vector2>());
    }

    // Start is called before the first frame update
    void Awake()
    {
        gameInput = new GameInput();
        gameInput.PlayerMovements.Enable();
        gameInput.PlayerMovements.SetCallbacks(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
