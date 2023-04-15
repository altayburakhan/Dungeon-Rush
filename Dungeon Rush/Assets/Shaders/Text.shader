Shader "Custom/CurvedText" {
    Properties {
        _MainTex ("Font Texture", 2D) = "white" {}
        _CurveIntensity ("Curve Intensity", Range(0, 1)) = 0.1
        _CurveRadius ("Curve Radius", Range(0, 1)) = 0.5
    }

    SubShader {
        Tags {"Queue"="Transparent" "RenderType"="Transparent"}
        LOD 100

        Pass {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float _CurveIntensity;
            float _CurveRadius;

            v2f vert (appdata v) {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target {
                // Apply curve to UV coordinates
                float2 uv = i.uv * 2 - 1; // Convert UV from [0,1] to [-1,1]
                uv.y *= _CurveRadius; // Apply vertical radius to curve
                uv.y += _CurveIntensity * (uv.x * uv.x); // Apply horizontal curve using parabolic function
                uv = uv * 0.5 + 0.5; // Convert UV back from [-1,1] to [0,1]

                // Sample texture using curved UV coordinates
                fixed4 col = tex2D(_MainTex, uv);
                return col;
            }
            ENDCG
        }
    }
}
