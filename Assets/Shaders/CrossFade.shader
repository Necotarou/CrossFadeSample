Shader "Custom/CrossFade" {

	Properties{
		_Color("Main Color", Color) = (1,1,1,1)
		_Blend("Blend", Range(0, 1)) = 0
		_Texture1("Texture 1", 2D) = ""
		_Texture2("Texture 2", 2D) = ""

	}

	SubShader{
		Pass{
			SetTexture[_Texture1]
			SetTexture[_Texture2]{
				ConstantColor(1,1,1,[_Blend])
				Combine texture Lerp(constant) previous
			}
		}
	}

}