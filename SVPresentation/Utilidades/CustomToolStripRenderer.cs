namespace SVPresentation.Utilidades
{
    public class CustomToolStripRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            //base.OnRenderMenuItemBackground(e);

            if (e.Item.Selected)
            {
                //cambiar el color de fondo al pasar el cursor
                Color hoverColor = Color.FromArgb(70, 65, 75);
                e.Graphics.FillRectangle(new SolidBrush(hoverColor), e.Item.ContentRectangle);
                e.Item.ForeColor = Color.White; // cambia el color del texto
            }
            else
            {
                //color de fondo normal
                Color hoverColor = Color.FromArgb(58, 49, 69);
                e.Graphics.FillRectangle(new SolidBrush(hoverColor), e.Item.ContentRectangle);
                e.Item.ForeColor = Color.White;
            }
        }
    }
}
