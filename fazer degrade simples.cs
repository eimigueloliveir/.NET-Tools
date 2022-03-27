protected override void OnPaintBackground(PaintEventArgs e)
{
    using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                                               Color.FromArgb(36, 41, 47),
                                                               Color.FromArgb(36, 40, 51),
                                                               50F))
    {
        e.Graphics.FillRectangle(brush, this.ClientRectangle);
    }
}
