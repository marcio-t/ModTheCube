using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    void Start()
    {

        transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));


        transform.localScale = Vector3.one * Random.Range(0.5f, 2f);


        transform.Rotate(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));


        float rotationSpeed = Random.Range(5f, 20f);


        Material material = Renderer.material;
        material.color = new Color(Random.value, Random.value, Random.value, Random.Range(0.5f, 1f)); // Cor aleatória


        StartCoroutine(ChangeColorOverTime(material));
    }

    void Update()
    {

        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }

    IEnumerator ChangeColorOverTime(Material material)
    {
        while (true)
        {

            yield return new WaitForSeconds(Random.Range(1f, 5f));


            material.color = new Color(Random.value, Random.value, Random.value, Random.Range(0.5f, 1f)); // Cor aleatória
        }
    }
}
