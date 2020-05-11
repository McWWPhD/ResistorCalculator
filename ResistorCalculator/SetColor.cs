using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistorCalculator
{
    class SetColor
    {
        Color color;

        public Color GetColor(int choice)
        {
            if (choice > -1)
            {
                switch (choice)
                {
                    case 0:
                        color = Color.Transparent;
                        break;

                    case 1:
                        color = Color.Gray;
                        break;

                    case 2:
                        color = Color.Gold;
                        break;

                    case 3:
                        color = Color.Black;
                        break;

                    case 4:
                        color = Color.Brown;
                        break;

                    case 5:
                        color = Color.Red;
                        break;

                    case 6:
                        color = Color.Orange;
                        break;

                    case 7:
                        color = Color.Yellow;
                        break;

                    case 8:
                        color = Color.Green;
                        break;

                    case 9:
                        color = Color.Blue;
                        break;

                    case 10:
                        color = Color.Violet;
                        break;

                    case 11:
                        color = Color.Gray;
                        break;

                    case 12:
                        color = Color.White;
                        break;
                }
            }

            return color;

        }
    }
}
