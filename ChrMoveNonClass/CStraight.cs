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
            // タイプを追加
            type = CHRTYPE.CHR_STRAIGHT;

            label.Text = "○";
        }

        protected override void Update()
        {
            float nx, ny;
            // X移動
            nx = posx + vx;
            // 跳ね返り
            if ((nx < 0f) || (nx + label.Width > Form1.ActiveForm.ClientSize.Width))
            {
                vx = -vx;
                nx = posx + vx;
            }
            // Y移動
            ny = posy + vy;
            // 跳ね返り
            if ((ny < 0f) || (ny + label.Height > Form1.ActiveForm.ClientSize.Height))
            {
                vy = -vy;
                ny = posy + vy;
            }
            // 書き戻し
            posx = nx;
            posy = ny;

            label.Left = (int)posx;
            label.Top = (int)posy;
        }

        public static void InstantiateChr()
        {
            we.Add(new CStraight());
        }

    }
}
