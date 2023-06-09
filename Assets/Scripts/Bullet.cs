using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_moveDistance = m_moveDirection * m_speed * Time.deltaTime;

        this.transform.position += m_moveDistance;
    }

    public void Targeting(GameObject target)
    {
        m_targetObject = target;

        m_moveDirection = target.transform.position - this.transform.position;
        m_moveDirection = m_moveDirection.normalized;
    }

    public float m_speed;
    GameObject m_targetObject;
    [SerializeField]
    Vector3 m_moveDirection;
    [SerializeField]
    Vector3 m_moveDistance;
}
