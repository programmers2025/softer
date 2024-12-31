using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms; // إضافة المكتبة الخاصة بـ Guna

namespace softer
{
    class PanelExpander
    {
        private Panel mainPanel;
        private List<Panel> panelsToMove;
        private Guna2Button buttonToMove;
        private int maxHeight;
        private int heightIncrement;
        private int buttonMoveLimit;
        private Panel scrollablePanel;  // Panel to scroll if needed

        // Constructor to initialize the class
        public PanelExpander(Panel mainPanel, List<Panel> panelsToMove, Guna2Button buttonToMove, int maxHeight, Panel scrollablePanel = null, int heightIncrement = 25, int buttonMoveLimit = 125)
        {
            this.mainPanel = mainPanel;
            this.panelsToMove = panelsToMove;
            this.buttonToMove = buttonToMove;
            this.maxHeight = maxHeight;
            this.heightIncrement = heightIncrement;
            this.buttonMoveLimit = buttonMoveLimit;
            this.scrollablePanel = scrollablePanel;  // Optional scrollable panel
        }

        // Method to expand the panel and move controls
        public void ExpandPanel()
        {
            int buttonY = buttonToMove.Location.Y;

            if (mainPanel.Height < maxHeight)
            {
                // Increase main panel height
                mainPanel.Height += heightIncrement;

                // Move other panels
                foreach (var panel in panelsToMove)
                {
                    panel.Location = new Point(panel.Location.X, panel.Location.Y + heightIncrement);
                }

                // Move the button
                if (buttonY < maxHeight)
                {
                    buttonY += heightIncrement;
                    buttonToMove.Location = new Point(buttonToMove.Location.X, buttonY);

                    // Scroll if a scrollable panel is provided
                    if (scrollablePanel != null)
                    {
                        scrollablePanel.AutoScrollPosition = new Point(0, scrollablePanel.VerticalScroll.Maximum);
                    }

                    // Hide the button if it reaches the specified limit
                    if (buttonY >= buttonMoveLimit)
                    {
                        buttonToMove.Hide();
                    }
                }
            }
        }
    }
}
