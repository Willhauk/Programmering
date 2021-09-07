namespace PictureShapes
{
    class Dice
    {
        private Square wall;
        private Circle prick;
        private Circle prick2;
        private Circle prick3;
        private Circle prick4;
        private Circle prick5;
        private Circle prick6;
        private Circle prick7;

        public void Roll()
        {

        }


        public Dice()
        {
            DrawImage();
        }
        public void DrawImage()
        {
            wall = new Square();
            wall.MakeVisible();
            wall.ChangeColor("white");
            wall.ChangeSize(400);
            wall.MoveHorizontal(100);
            wall.MoveVertical(-100);
          
            prick = new Circle();
            prick.MakeVisible();
            prick.ChangeColor("red");
            prick.ChangeSize(75);
            prick.MoveHorizontal(340);
            prick.MoveVertical(100);
            
            prick2 = new Circle();
            prick2.MakeVisible();
            prick2.ChangeColor("red");
            prick2.ChangeSize(75);
            prick2.MoveHorizontal(340);
            prick2.MoveVertical(225);

            prick3 = new Circle();
            prick3.MakeVisible();
            prick3.ChangeColor("red");
            prick3.ChangeSize(75);
            prick3.MoveHorizontal(340);
            prick3.MoveVertical(350);

            prick4 = new Circle();
            prick4.MakeVisible();
            prick4.ChangeColor("red");
            prick4.ChangeSize(75);
            prick4.MoveHorizontal(80);
            prick4.MoveVertical(100);

            prick5 = new Circle();
            prick5.MakeVisible();
            prick5.ChangeColor("red");
            prick5.ChangeSize(75);
            prick5.MoveHorizontal(80);
            prick5.MoveVertical(225);

            prick6 = new Circle();
            prick6.MakeVisible();
            prick6.ChangeColor("red");
            prick6.ChangeSize(75);
            prick6.MoveHorizontal(80);
            prick6.MoveVertical(350);

            prick7 = new Circle();
            prick7.MakeVisible();
            prick7.ChangeColor("red");
            prick7.ChangeSize(75);
            prick7.MoveHorizontal(210);
            prick7.MoveVertical(225);


        }
    }
}
