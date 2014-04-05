using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour 
{
    private const float SPEED = 5f;

    public KeyCode _forwardKey = KeyCode.W;
    public KeyCode _backwardsKey = KeyCode.S;
    public KeyCode _rightKey = KeyCode.D;
    public KeyCode _leftKey = KeyCode.A;
    private KeyCode _currentDirection;

	// Use this for initialization
	void Start ()
    {
        _currentDirection = _forwardKey;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(_forwardKey) && _currentDirection != _backwardsKey)
        {
            _currentDirection = _forwardKey;
        }
        else if (Input.GetKey(_backwardsKey) && _currentDirection != _forwardKey)
        {
            _currentDirection = _backwardsKey;
        }
        else if (Input.GetKey(_rightKey) && _currentDirection != _leftKey)
        {
            _currentDirection = _rightKey;
        }
        else if (Input.GetKey(_leftKey) && _currentDirection != _rightKey)
        {
            _currentDirection = _leftKey;
        }

        if (_currentDirection == _forwardKey)
        {
            rigidbody.velocity = new Vector3(0f, SPEED);
        }
        else if (_currentDirection == _backwardsKey)
        {
            rigidbody.velocity = new Vector3(0f, -SPEED);
        }
        else if (_currentDirection == _rightKey)
        {
            rigidbody.velocity = new Vector3(SPEED, 0f);
        }
        else if (_currentDirection == _leftKey)
        {
            rigidbody.velocity = new Vector3(-SPEED, 0f);
        }
	}

    void OnTriggerEnter(Collider collider)
    {
        Destroy(gameObject);
    }
}
