using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwitcher : MonoBehaviour
{
    public SpriteRenderer targetRenderer; // 画像を切り替える対象のSpriteRenderer
    public Sprite sprite1;               // 最初の画像
    public Sprite sprite2;               // 切り替え後の画像
    public float switchInterval = 1.0f;  // 切り替え間隔（秒）

    private bool isSprite1Active = true; // 現在表示中の画像を判定

    // Start is called before the first frame update
    void Start()
    {
        if (targetRenderer != null && sprite1 != null && sprite2 != null)
        {
            StartCoroutine(SwitchSprites());
        }
    }

    IEnumerator SwitchSprites()
    {
        while (true)
        {
            // スプライトを切り替え
            targetRenderer.sprite = isSprite1Active ? sprite2 : sprite1;
            isSprite1Active = !isSprite1Active;

            // 指定された時間待機
            yield return new WaitForSeconds(switchInterval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
