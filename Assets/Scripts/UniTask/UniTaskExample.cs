using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UniTaskExample : MonoBehaviour
{
    [SerializeField] private Image progressBar1;
    [SerializeField] private Image progressBar2;
    [SerializeField] private Image progressBar3;


    private void Awake()
    {
        progressBar1.fillAmount = 0;
        progressBar2.fillAmount = 0;
    }

    //private void Start()
    //{
    //    StartCoroutine(ExampleCoroutine(progressBar1));
    //}

    async void Start()
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;

        await ExampleAsync(progressBar2, cts.Token);
    }

    async Task ExampleAsync(Image image, CancellationToken token)
    {
        for (float i = 0f; i < 1f; i += 0.1f)
        {
            token.ThrowIfCancellationRequested();
            await Task.Delay(500, token);
            image.fillAmount = i;
        }
        image.fillAmount = 1f;
    }

    IEnumerator ExampleCoroutine(Image image)
    {
        for (float i = 0f; i <1f; i+= 0.1f)
        {
            image.fillAmount = i;
            yield return new WaitForSeconds(0.5f);
        }
        image.fillAmount = 1f;
    }
}
