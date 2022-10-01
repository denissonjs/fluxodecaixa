using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fluxoDeCaixa
{
    internal class Radius
    {
        private static GraphicsPath SuArredondaRect(Rectangle pRect, int pCanto, bool pTopo, bool pBase)
        {
            GraphicsPath gp = new GraphicsPath();

            if (pTopo)
            {
                gp.AddArc(pRect.X - 1, pRect.Y - 1, pCanto, pCanto, 180, 90);
                gp.AddArc(pRect.X + pRect.Width - pCanto, pRect.Y - 1, pCanto, pCanto, 270, 90);
            }
            else
            {
                gp.AddLine(pRect.X - 1, pRect.Y - 1, pRect.X + pRect.Width, pRect.Y - 1);
            }

            if (pBase)
            {
                gp.AddArc(pRect.X + pRect.Width - pCanto, pRect.Y + pRect.Height - pCanto, pCanto, pCanto, 0, 90);
                gp.AddArc(pRect.X - 1, pRect.Y + pRect.Height - pCanto, pCanto, pCanto, 90, 90);
            }
            else
            {               
                gp.AddLine(pRect.X + pRect.Width, pRect.Y + pRect.Height, pRect.X - 1, pRect.Y + pRect.Height);
            }

            return gp;
        }
        public static void ArredondaForm(Form pFormulario, int pCanto, bool pTopo, bool pBase)
        {

            Rectangle r = new Rectangle();
            r = pFormulario.ClientRectangle;

            pFormulario.Region = new System.Drawing.Region(SuArredondaRect(r, pCanto, pTopo, pBase));
        }

        public static void ArredondaPic(PictureBox pPicture, int pCanto, bool pTopo, bool pBase)
        {

            Rectangle r = new Rectangle();
            r = pPicture.ClientRectangle;

            pPicture.Region = new System.Drawing.Region(SuArredondaRect(r, pCanto, pTopo, pBase));
        }

        public static void ArredondaPanel(Panel pPainel, int pCanto, bool pTopo, bool pBase)
        {
            Rectangle r = new Rectangle();
            r = pPainel.ClientRectangle;

            pPainel.Region = new System.Drawing.Region(SuArredondaRect(r, pCanto, pTopo, pBase));
        }

        public static void ArredondaBt(Button pButton, int pCanto, bool pTopo, bool pBase)
        {
            Rectangle r = new Rectangle();
            r = pButton.ClientRectangle;

            pButton.Region = new System.Drawing.Region(SuArredondaRect(r, pCanto, pTopo, pBase));
        }
    }




}
