using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullScript : MonoBehaviour
{
    public SkullPillarScript skullPillarScript;
    public ParticleSystem _skullTrail;

    public Vector3 StartPosition;
    public Quaternion StartRotation; 
    // Start is called before the first frame update

    private void Awake()
    {
        skullPillarScript.allSkulls.Add(this);
        _skullTrail = GetComponentInChildren<ParticleSystem>();
        StartPosition = gameObject.GetComponent<Transform>().position;
    }
    void Start()
    {
        StartPosition = gameObject.transform.position;
        StartRotation = gameObject.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
