using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKManager : MonoBehaviour
{

    public Joint m_root;

    public Joint m_end;

    public GameObject m_target;

    float GetDistance(Vector3 p1, Vector3 p2)
    {
        return Vector3.Distance(p1, p2);
    }
}
