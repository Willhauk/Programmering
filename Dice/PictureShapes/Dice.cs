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
            wall.MoveHorizontal(100);
            wall.MoveVertical(-100);
          
            prickar[1] = new Circle();
            prickar[1].MakeVisible();
            prickar[1].ChangeColor("red");
            prickar[1].ChangeSize(75);
            prickar[1].MoveHorizontal(340);
            prickar[1].MoveVertical(100);
            
            prickar[2] = new Circle();
            prickar[2].MakeVisible();
            prickar[2].ChangeColor("red");
            prickar[2].ChangeSize(75);
            prickar[2].MoveHorizontal(340);
            prickar[2].MoveVertical(225);

            prickar[3] = new Circle();
            prickar[3].MakeVisible();
            prickar[3].ChangeColor("red");
            prickar[3].ChangeSize(75);
            prickar[3].MoveHorizontal(340);
            prickar[3].MoveVertical(350);

            prickar[4] = new Circle();
            prickar[4].MakeVisible();
            prickar[4].ChangeColor("red");
            prickar[4].ChangeSize(75);
            prickar[4].MoveHorizontal(80);
            prickar[4].MoveVertical(100);

            prickar[5] = new Circle();
            prickar[5].MakeVisible();
            prickar[5].ChangeColor("red");
            prickar[5].ChangeSize(75);
            prickar[5].MoveHorizontal(80);
            prickar[5].MoveVertical(225);

            prickar[6] = new Circle();
            prickar[6].MakeVisible();
            prickar[6].ChangeColor("red");
            prickar[6].ChangeSize(75);
            prickar[6].MoveHorizontal(80);
            prickar[6].MoveVertical(350);

            prickar[0] = new Circle();
            prickar[0].MakeVisible();
            prickar[0].ChangeColor("red");
            prickar[0].ChangeSize(75);
            prickar[0].MoveHorizontal(210);
            prickar[0].MoveVertical(225);


        }


    }
}
