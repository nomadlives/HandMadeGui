using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSharpGUI {
	//Creates the form
    public class WinFormExample : Form {
	//Creates a button instance
        private Button button;
	//Textbox instance
	TextBox textbox1 = new TextBox();
	//Label instance
	Label label1 = new Label();
		
        public WinFormExample() {
            DisplayGUI();
        }

        private void DisplayGUI() {
			//https://stackoverflow.com/questions/27093017/how-to-add-ui-without-ide 
			//Made from this example
            this.Name = "HandMade GUI";
            this.Text = "HandMade Gui";
            this.Size = new Size(200, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
			label1.Text="Enter Text";
			label1.Location = new Point(1, 80);
			label1.Size = new Size(label1.PreferredWidth, label1.PreferredHeight);
			this.Controls.Add(label1);
			textbox1.Height = 50;
			textbox1.Width = 150;
			textbox1.Location = new Point(5, 100);
			this.Controls.Add(textbox1);
            button = new Button();
            button.Name = "button";
            button.Text = "Click Me!";
            button.Size = new Size(90, 30);
            button.Location = new Point(
                (this.Width - button.Width) / 3,
                (this.Height - button.Height) / 2);
            button.Click += new System.EventHandler(this.MyButtonClick);

            this.Controls.Add(button);
        }

        private void MyButtonClick(object source, EventArgs e) {
            MessageBox.Show(textbox1.Text);
			textbox1.Text = "";
        }

        public static void Main(String[] args) {
            Application.Run(new WinFormExample());
        }
    }
}
