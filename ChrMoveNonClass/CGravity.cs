using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class CGravity : CChr
    {
        /** 重力加速度*/
        const float GRAVITY = 5f;

        /** コンストラクタ*/
        public CGravity() : base()
        {
            type = CHRTYPE.CHR_GRAVITY;
            label.Text = "◆";
            vy = 0f;
        }

        protected override void Update()
        {
            float ny;
            // X移動
            moveX();

            // Y移動
            vy += GRAVITY;
            ny = posy + vy;
            if (ny + label.Height > Form1.ActiveForm.ClientSize.Height)
            {
                // 速度反転
                vy = -vy;
                ny = Form1.ActiveForm.ClientSize.Height - label.Height;
            }
            posy = ny;

            label.Top = (int)posy;
        }

        public static void InstantiateChr()
        {
            we.Add(new CGravity());
        }
    }
}
