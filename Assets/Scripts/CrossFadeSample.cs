﻿using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class CrossFadeSample : MonoBehaviour
{
	// クロスフェードに使用するImageオブジェクト
	[SerializeField]
	private Image ImageUI;

	// テクスチャ1枚目
	[SerializeField]
	private Texture Texture1;

	// テクスチャ2枚目
	[SerializeField]
	private Texture Texture2;

	// 変化の速度 (秒)
	[SerializeField]
	private float Speed = 2.0f;


	void Start()
	{
		// Imageのマテリアルを取得
		Material material = ImageUI.GetComponent<Image>().material;

		// ブレンド率を0.0に設定
		material.SetFloat("_Blend", 0.0f);

		// テクスチャを設定する
		material.SetTexture("_Texture1", Texture1);
		material.SetTexture("_Texture2", Texture2);

		// ブレンド率を操作する (DoTweenを使用しています)
		material.DOFloat(1.0f, "_Blend", Speed).SetLoops(-1, LoopType.Yoyo);
	}
}