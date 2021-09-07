namespace PictureShapes
{
    class Picture
    {
        private Square wall;
        private Square window;
        private Circle sun;
        private Triangle roof;

        public Picture()
        {
            DrawImage();
        }
        public void DrawImage()
        {
            wall = new Square();
            wall.MakeVisible();
            wall.ChangeColor("red");
            wall.ChangeSize(200);
            wall.MoveHorizontal(70);
            wall.MoveVertical(20);

            // Write your code here
            roof = new Triangle();
            roof.MakeVisible();
            roof.ChangeColor("black");
            roof.ChangeSize(275);
            roof.MoveHorizontal(-13);
            roof.MoveVertical(-15);

            window = new Square();
            window.MakeVisible();
            window.ChangeColor("black");
            window.ChangeSize(75);
            window.MoveHorizontal(100);
            window.MoveVertical(50);

            sun = new Circle();
            sun.MakeVisible();
            sun.ChangeColor("yellow");
            sun.ChangeSize(100);
            sun.MoveHorizontal(320);
            sun.MoveVertical(10);

        }
    }
}
