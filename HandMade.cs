using System;
using System.Drawing;
using System.Windows.Forms;

namespace CSharpGUI {
	//Creates the form
    public class WinFormExample : Form {
	//Creates a button instance
        private Button button;
	//Textbox instance
	TextBox hours = new TextBox();
	
	//pay rate textbox.
	TextBox rate = new TextBox();
	//Label instance
	Label hourLabel = new Label();
	
	Label rateLabel = new Label();
		
        public WinFormExample() {
            DisplayGUI();
        }

        private void DisplayGUI() {
			//https://stackoverflow.com/questions/27093017/how-to-add-ui-without-ide 
			//Made from this example
            this.Name = "HandMade GUI";
            this.Text = "PayCalc";
            this.Size = new Size(300, 200);
            this.StartPosition = FormStartPosition.CenterScreen;
			
			//Label for Hours textbox.	
			hourLabel.Text="Enter Hours";
			
			//Location for Hours TextBox.
			hourLabel.Location = new Point(1, 80);
			//dimensions for label.
			hourLabel.Size = new Size(hourLabel.PreferredWidth, hourLabel.PreferredHeight);
			
			//Adds the label to the gui.
			this.Controls.Add(hourLabel);
			
			//Dimensions for hours textbox.
			hours.Height = 50;
			hours.Width = 150;
			hours.Location = new Point(5, 100);
			hours.TabIndex = 2;
			//adding textbox to gui.
			this.Controls.Add(hours);
			
			
			//label for rate textbox.
			rateLabel.Text = "Enter Pay Rate";
			rateLabel.Location = new Point(1,5);
			rateLabel.Size = new Size(rateLabel.PreferredWidth, rateLabel.PreferredHeight);
			
			//adding label to gui.
			this.Controls.Add(rateLabel);
			
			
			//rate textbox dimensions.
			rate.Height = 50;
			rate.Width = 150;
			rate.Location = new Point(5, 25);
			rate.TabIndex = 1;
			//adds rate box to gui.
			this.Controls.Add(rate);
			
			
            button = new Button();
            button.Name = "button";
            button.Text = "Submit";
            button.Size = new Size(90, 30);
            button.Location = new Point(
                (180) ,
                (this.Height - button.Height) / 2);
            button.Click += new System.EventHandler(this.MyButtonClick);
			button.TabIndex = 3;
            this.Controls.Add(button);
        }

        private void MyButtonClick(object source, EventArgs e) {
            //MessageBox.Show(rate.Text);
			//hours.Text = "";
			Double result;
			bool checkRate = Double.TryParse(rate.Text, out  result);
			
			if (checkRate == false)
			{
				MessageBox.Show("Incorrect Amount", "PayCalc");
				rate.Text = "";
				rate.Focus();
			}
			else
			{
				int hourResult;
				bool checkHour = Int32.TryParse(hours.Text, out hourResult);
				
				if(checkHour == false)
				{
					MessageBox.Show("Incorrect AMount", "PayCalc");
					hours.Text = "";
					hours.Focus();
				}
				else{
					
					double grossPay = Math.Round(result * Convert.ToDouble(hourResult), 3);
					MessageBox.Show("Your gross pay is. $" + Convert.ToString(grossPay), "PayCalc");
					
					rate.Focus();
					rate.Text = "";
					hours.Text = "";
				}
				
				
			}
				
        }

        public static void Main(String[] args) {
            Application.Run(new WinFormExample());
        }
    }
}
