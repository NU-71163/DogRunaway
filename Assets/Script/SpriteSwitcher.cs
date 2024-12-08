using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwitcher : MonoBehaviour
{
    public SpriteRenderer targetRenderer; // �摜��؂�ւ���Ώۂ�SpriteRenderer
    public Sprite sprite1;               // �ŏ��̉摜
    public Sprite sprite2;               // �؂�ւ���̉摜
    public float switchInterval = 1.0f;  // �؂�ւ��Ԋu�i�b�j

    private bool isSprite1Active = true; // ���ݕ\�����̉摜�𔻒�

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
            // �X�v���C�g��؂�ւ�
            targetRenderer.sprite = isSprite1Active ? sprite2 : sprite1;
            isSprite1Active = !isSprite1Active;

            // �w�肳�ꂽ���ԑҋ@
            yield return new WaitForSeconds(switchInterval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
