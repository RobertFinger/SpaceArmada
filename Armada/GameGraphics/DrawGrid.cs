using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Armada.GameGraphics
{ 
    class DrawGrid
    {

        private readonly int[] _boardX = { 0, 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600 };
        private readonly int[] _boardY = { 0, 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600 };
        private readonly Pen _lines = new Pen(Color.Black, 3);

        public void DrawBoardLines(Graphics gObject)
        {
            for (var x = 0; x <= 600; x += 50)
            {
                gObject.DrawLine(_lines, 0, x, 600, x);
                for (var y = 0; y <= 600; y += 50)
                {
                    gObject.DrawLine(_lines, y, 0, y, 600);
                }
            }
        }

       


    }
}
