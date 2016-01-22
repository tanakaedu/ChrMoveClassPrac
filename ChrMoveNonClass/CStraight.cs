using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class CStraight : CChr
    {
        public CStraight() : base()
        {
            type = CHRTYPE.CHR_STRAIGHT;
            label.Text = "○";
        }

        protected override void Update()
        {
            float ny;
            // X移動
            moveX();

            // Y移動
            ny = posy + vy;
            // 跳ね返り
            if ((ny < 0f) || (ny + label.Height > Form1.ActiveForm.ClientSize.Height))
            {
                vy = -vy;
                ny = posy + vy;
            }

            // 書き戻し
            posy = ny;
            label.Top = (int)posy;
        }

        public static void InstantiateChr()
        {
            we.Add(new CStraight());
        }
    }
}
