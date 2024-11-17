using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMove : MonoBehaviour
{
    #region Field and Properties

    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _width = 6f;

    private SpriteRenderer sR;

    private Vector2 startingSize;

    #endregion

    #region

    private void Start()
    {
        sR = GetComponent<SpriteRenderer>();
        startingSize = new Vector2(sR.size.x, sR.size.y);
        
        if (sR.size.x > _width)
        {
            sR.size = startingSize;
        }
    }

    private void Update()
    {
        sR.size = new Vector2(sR.size.x + _speed * Time.deltaTime, sR.size.y);

        if (sR.size.x > _width)
        {
            sR.size = startingSize;
        }
    }

    #endregion
}
