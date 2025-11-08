internal class PaintController
{
    Color c1 = Color.White;
    Color c2 = Color.Red;
    Color c3 = Color.Black;

    public PaintController()
    {
    }

    public void ClearAll(Graphics g)
    {
        g.Clear(Color.LightGray);
    }

    public void DrawBar(Graphics g, float x, float y, float width, float height, Color color)
    {
        using (Brush brush = new SolidBrush(color))
        {
            g.FillRectangle(brush, x, y, width, height);
        }
    }

    public void DrawBarWithOutline(Graphics g, float x, float y, float width, float height, Color fillColor, Color outlineColor)
    {
        using (Brush brush = new SolidBrush(fillColor))
        {
            g.FillRectangle(brush, x, y, width, height);
        }
        using (Pen pen = new Pen(outlineColor))
        {
            g.DrawRectangle(pen, x, y, width, height);
        }
    }
}