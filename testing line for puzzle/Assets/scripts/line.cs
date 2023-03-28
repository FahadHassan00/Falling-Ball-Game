using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line : MonoBehaviour
{
    public LineRenderer _renderer;
    public EdgeCollider2D _collider;
    private List<Vector2> points = new List<Vector2>();
    // Start is called before the first frame update
    void Start()
    {
        _collider.transform.position -= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void setposition(Vector2 pos)
    {
        if (!CanAppend(pos)) return;

        points.Add(pos);
        _renderer.positionCount++;
        _renderer.SetPosition(_renderer.positionCount - 1, pos);
        _collider.points = points.ToArray();
    }

    private bool CanAppend(Vector2 pos)
    {
        if (_renderer.positionCount == 0) return true;

        return Vector2.Distance(_renderer.GetPosition(_renderer.positionCount - 1), pos) > line_drawer.resolution;
    }
}




