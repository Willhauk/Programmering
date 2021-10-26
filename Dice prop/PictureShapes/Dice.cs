using System;

namespace PictureShapes
{


    class Dice
    {
        private Square wall;
        private Circle[] prickar;
        private static Random numberGenerator;
        private int number = 5;

        public void Roll()
        {
            numberGenerator.Next(1, 7);
            number = numberGenerator.Next(1, 7);

            wall.MakeVisible();
            prickar[1].MakeInVisible();
            prickar[2].MakeInVisible();
            prickar[3].MakeInVisible();
            prickar[4].MakeInVisible();
            prickar[5].MakeInVisible();
            prickar[6].MakeInVisible();
            prickar[0].MakeInVisible();

            if (number %2 == 1)
            {
                prickar[1].MakeVisible();
            }

            if (number >= 2)
            {
                prickar[2].MakeVisible();
                prickar[3].MakeVisible();
            }

            if (number >= 4)
            {
                prickar[4].MakeVisible();
                prickar[5].MakeVisible();
            }

            if (number == 6)
            {
                prickar[6].MakeVisible();
                prickar[0].MakeVisible();
            }
        }


        public Dice()
        {
            numberGenerator = new Random();
            prickar = new Circle[7];
            prickar[0] = new Circle();
            prickar[1] = new Circle();
            prickar[2] = new Circle();
            prickar[3] = new Circle();
            prickar[4] = new Circle();
            prickar[5] = new Circle();
            prickar[6] = new Circle();

            DrawImage();
        }
        public void DrawImage()
        {
            wall = new Square();
            wall.MakeVisible();
            wall.ChangeColor("black");
            wall.ChangeSize(400);
            wall.XPosition = 150;
            wall.YPosition = 100;
          
            prickar[1] = new Circle();
            prickar[1].MakeVisible();
            prickar[1].ChangeColor("white");
            prickar[1].ChangeSize(75);
            prickar[1].XPosition = 440;
            prickar[1].YPosition = 130;
            
            prickar[2] = new Circle();
            prickar[2].MakeVisible();
            prickar[2].ChangeColor("white");
            prickar[2].ChangeSize(75);
            prickar[2].XPosition = 440;
            prickar[2].YPosition = 255;

            prickar[3] = new Circle();
            prickar[3].MakeVisible();
            prickar[3].ChangeColor("white");
            prickar[3].ChangeSize(75);
            prickar[3].XPosition = 440;
            prickar[3].YPosition = 380;

            prickar[4] = new Circle();
            prickar[4].MakeVisible();
            prickar[4].ChangeColor("white");
            prickar[4].ChangeSize(75);
            prickar[4].XPosition = 180;
            prickar[4].YPosition = 130;

            prickar[5] = new Circle();
            prickar[5].MakeVisible();
            prickar[5].ChangeColor("white");
            prickar[5].ChangeSize(75);
            prickar[5].XPosition = 180;
            prickar[5].YPosition = 255;

            prickar[6] = new Circle();
            prickar[6].MakeVisible();
            prickar[6].ChangeColor("white");
            prickar[6].ChangeSize(75);
            prickar[6].XPosition = 180;
            prickar[6].YPosition = 380;

            prickar[0] = new Circle();
            prickar[0].MakeVisible();
            prickar[0].ChangeColor("white");
            prickar[0].ChangeSize(75);
            prickar[0].XPosition = 310;
            prickar[0].YPosition = 255;


        }


    }
}
