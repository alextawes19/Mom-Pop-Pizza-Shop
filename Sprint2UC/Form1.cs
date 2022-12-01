using System.IO;

namespace Sprint2UC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //loginTab.Enabled = false;
            //standardTab.Enabled = false;
            byoTab.Enabled = false;
            beveragesTab.Enabled = false;
            //orderTab.Enabled = false;
            checkoutTab.Enabled = false;

            //register tab
            matchError.Text = "";
            eMatchError.Text = "";
            usernameError.Text = "";
            successPanel.Visible = false;

            //login tab
            matchingError.Text = "";
            successfullLoginPanel.Visible = false;

            //standard tab
            sizeGBcheese.Enabled = false;
            crustGBcheese.Enabled=false;

            sizeGBpep.Enabled = false;
            crustGBpep.Enabled = false;

            sizeGBSausage.Enabled = false;
            crustGBSausage.Enabled = false;

            sizeGBHawaiian.Enabled = false;
            crustGBHawaiian.Enabled = false;

            sizeGBbbq.Enabled = false;
            crustGBbbq.Enabled = false;

            size1.Text = "";
            size2.Text = "";
            size3.Text = "";
            size4.Text = "";
            size5.Text = "";
            size6.Text = "";

            crust1.Text = "";
            crust2.Text = "";
            crust3.Text = "";
            crust4.Text = "";
            crust5.Text = "";
            crust6.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            StreamReader usernameRead = new StreamReader("D:\\usernames.txt");
            StreamReader passwordRead = new StreamReader("D:\\passwords.txt");
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            bool userMatches = false;
            bool passwordMatches = false;

            using (usernameRead)
            {
                string contents = usernameRead.ReadToEnd();
                if (contents.Contains(username))
                {
                    userMatches = true;
                }
            }

            using (passwordRead)
            {
                string contents = passwordRead.ReadToEnd();
                if (contents.Contains(password))
                {
                    passwordMatches = true;
                }
            }

            if ((userMatches==true) && (passwordMatches==true))
            {
                loginTab.Enabled = false;
                matchingError.Text = "";
                successfullLoginPanel.Visible = true;

                standardTab.Enabled = true;
                byoTab.Enabled = true;
                beveragesTab.Enabled = true;
                orderTab.Enabled = true;
                checkoutTab.Enabled = true;
            }
            else
            {
                matchingError.Text = "Your username or password is incorrect!";
            }


            usernameRead.Close();
            passwordRead.Close();
        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void loginCompletionLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            //login info
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            string conPassword = conPasswordInput.Text;
            //personal info
            string fName = fNameInput.Text;
            string lName = LNameInput.Text;
            string address = addyInput.Text;
            string phoneNum = phoneInput.Text;
            string email = emailInput.Text;
            string conEmail = conEmailInput.Text;
            //card
            string cardNum = cardNumInput.Text;
            string expDate = expDateInput.Text;
            string cvv = cvvInput.Text;

            bool accountCreated = false;

            //error catching
            if (password != conPassword)
            {
                matchError.Text = "Your passwords do not match!";
            }


            if (password == conPassword)
            {
                matchError.Text = "";
            }

            if (email != conEmail)
            {
                eMatchError.Text = "Your emails do not match!";
            }

            if (email == conEmail)
            {
                eMatchError.Text = "";
            }

            //writes the username to the usernames file and password to passwords file
            try
            {
                
                StreamWriter usernamesWrite = new StreamWriter("D:\\usernames.txt");
                StreamWriter passwordsWrite = new StreamWriter("D:\\passwords.txt");
                

                if ((password==conPassword) && (email==conEmail))
                {
                    registerTab.Enabled = false;
                    successPanel.Visible = true;
                    usernamesWrite.WriteLine(username);
                    passwordsWrite.WriteLine(password);
                    
                }

                passwordsWrite.Close();
                usernamesWrite.Close();
            }
            catch
            {

            }
            finally
            {

            }
            
           
        }

        // CHEESE PIZZA STANDARD
        private void cheeseCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cheeseCheck.Checked)
            {
                sizeGBcheese.Enabled = true;
                crustGBcheese.Enabled=true;
                pizza1.Text = "Cheese Pizza";
            }
            if (!cheeseCheck.Checked)
            {
                pizza1.Text = "";
                sizeGBcheese.Enabled = false;
                crustGBcheese.Enabled= false;

    
                smallCheese.Checked = false;
                mediumCheese.Checked = false;
                largeCheese.Checked = false;
                regCheese.Checked = false;
                thinCheese.Checked = false;
                stuffedCheese.Checked = false;
            }

        }

        private void smallCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (smallCheese.Checked)
            {
                size1.Text = "Small";
            }
            else
            {
                size1.Text = "";
            }
        }

        private void mediumCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumCheese.Checked)
            {
                size1.Text = "Medium";
            }
            else
            {
                size1.Text = "";
            }
        }

        private void largeCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (largeCheese.Checked)
            {
                size1.Text = "Large";
            }
            else
            {
                size1.Text = "";
            }
        }

        private void regCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (regCheese.Checked)
            {
                crust1.Text = "Regular Crust";
            }
            else
            {
                crust1.Text = "";
            }
        }

        private void thinCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (thinCheese.Checked)
            {
                crust1.Text = "Thin Crust";
            }
            else
            {
                crust1.Text = "";
            }
        }

        private void stuffedCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (stuffedCheese.Checked)
            {
                crust1.Text = "Stuffed Crust";
            }
            else
            {
                crust1.Text = "";
            }
        }

        //PEPPERONI PIZZA STANDARD
        private void pepCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (pepCheck.Checked)
            {
                sizeGBpep.Enabled = true;
                crustGBpep.Enabled = true;
                pizza2.Text = "Pepperoni Pizza";
            }
            if (!pepCheck.Checked)
            {
                pizza2.Text = "";
                sizeGBpep.Enabled = false;
                crustGBpep.Enabled = false;


                smallPep.Checked = false;
                mediumPep.Checked = false;
                largePep.Checked = false;
                regPep.Checked = false;
                thinPep.Checked = false;
                stuffedPep.Checked = false;
            }
        }

        private void smallPep_CheckedChanged(object sender, EventArgs e)
        {
            if (smallPep.Checked)
            {
                size2.Text = "Small";
            }
            else
            {
                size2.Text = "";
            }
        }

        private void mediumPep_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumPep.Checked)
            {
                size2.Text = "Medium";
            }
            else
            {
                size2.Text = "";
            }
        }

        private void largePep_CheckedChanged(object sender, EventArgs e)
        {
            if (largePep.Checked)
            {
                size2.Text = "Large";
            }
            else
            {
                size2.Text = "";
            }
        }

        private void regPep_CheckedChanged(object sender, EventArgs e)
        {
            if (regPep.Checked)
            {
                crust2.Text = "Regular Crust";
            }
            else
            {
                crust2.Text = "";
            }
        }

        private void thinPep_CheckedChanged(object sender, EventArgs e)
        {
            if (thinPep.Checked)
            {
                crust2.Text = "Thin Crust";
            }
            else
            {
                crust2.Text = "";
            }
        }

        private void stuffedPep_CheckedChanged(object sender, EventArgs e)
        {
            if (stuffedPep.Checked)
            {
                crust2.Text = "Stuffed Crust";
            }
            else
            {
                crust2.Text = "";
            }
        }

        //SAUSAGE PIZZA STANDARD
        private void sausageCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (sausageCheck.Checked)
            {
                sizeGBSausage.Enabled = true;
                crustGBSausage.Enabled = true;
                pizza3.Text = "Sausage Pizza";
            }
            if (!sausageCheck.Checked)
            {
                pizza3.Text = "";
                sizeGBSausage.Enabled = false;
                crustGBSausage.Enabled = false;


                smallSausage.Checked = false;
                mediumSausage.Checked = false;
                largeSausage.Checked = false;
                regSausage.Checked = false;
                thinSausage.Checked = false;
                stuffedSausage.Checked = false;
            }
        }

        private void smallSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (smallSausage.Checked)
            {
                size3.Text = "Small";
            }
            else
            {
                size3.Text = "";
            }
        }

        private void mediumSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumSausage.Checked)
            {
                size3.Text = "Medim";
            }
            else
            {
                size3.Text = "";
            }
        }

        private void largeSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (largeSausage.Checked)
            {
                size3.Text = "Large";
            }
            else
            {
                size3.Text = "";
            }
        }

        private void regSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (regSausage.Checked)
            {
                crust3.Text = "Regular Crust";
            }
            else
            {
                crust3.Text = "";
            }
        }

        private void thinSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (thinSausage.Checked)
            {
                crust3.Text = "Thin Crust";
            }
            else
            {
                crust3.Text = "";
            }
        }

        private void stuffedSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (stuffedSausage.Checked)
            {
                crust3.Text = "Stuffed Crust";
            }
            else
            {
                crust3.Text = "";
            }
        }

        //HAWAIIAN PIZZA STANDARD
        private void hawaiianCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (hawaiianCheck.Checked)
            {
                sizeGBHawaiian.Enabled = true;
                crustGBHawaiian.Enabled = true;
                pizza4.Text = "Hawaiian Pizza";
            }
            if (!hawaiianCheck.Checked)
            {
                pizza4.Text = "";
                sizeGBHawaiian.Enabled = false;
                crustGBHawaiian.Enabled = false;


                smallHawaiian.Checked = false;
                mediumHawaiian.Checked = false;
                largeHawaiian.Checked = false;
                regHawaiian.Checked = false;
                thinHawaiian.Checked = false;
                stuffedHawaiian.Checked = false;
            }
        }

        private void smallHawaiian_CheckedChanged(object sender, EventArgs e)
        {
            if (smallHawaiian.Checked)
            {
                size4.Text = "Small";
            }
            else
            {
                size4.Text = "";
            }
        }

        private void mediumHawaiian_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumHawaiian.Checked)
            {
                size4.Text = "Medium";
            }
            else
            {
                size4.Text = "";
            }
        }

        private void largeHawaiian_CheckedChanged(object sender, EventArgs e)
        {
            if (largeHawaiian.Checked)
            {
                size4.Text = "Large";
            }
            else
            {
                size4.Text = "";
            }
        }

        private void regHawaiian_CheckedChanged(object sender, EventArgs e)
        {
            if (regHawaiian.Checked)
            {
                crust4.Text = "Regular Crust";
            }
            else
            {
                crust4.Text = "";
            }
        }

        private void thinHawaiian_CheckedChanged(object sender, EventArgs e)
        {
            if (thinHawaiian.Checked)
            {
                crust4.Text = "Thin Crust";
            }
            else
            {
                crust4.Text = "";
            }
        }

        private void stuffedHawaiian_CheckedChanged(object sender, EventArgs e)
        {
            if (stuffedHawaiian.Checked)
            {
                crust4.Text = "Stuffed Crust";
            }
            else
            {
                crust4.Text = "";
            }
        }

        //BBQ CHICKEN STANDARD
        private void bbqCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (bbqCheck.Checked)
            {
                sizeGBbbq.Enabled = true;
                crustGBbbq.Enabled = true;
                pizza5.Text = "BBQ Chicken Pizza";
            }
            if (!bbqCheck.Checked)
            {
                pizza5.Text = "";
                sizeGBbbq.Enabled = false;
                crustGBbbq.Enabled = false;


                smallBBQ.Checked = false;
                mediumBBQ.Checked = false;
                largeBBQ.Checked = false;
                regBBQ.Checked = false;
                thinBBQ.Checked = false;
                stuffedBBQ.Checked = false;
            }
        }

        private void smallBBQ_CheckedChanged(object sender, EventArgs e)
        {
            if (smallBBQ.Checked)
            {
                size5.Text = "Small";
            }
            else
            {
                size5.Text = "";
            }
        }

        private void mediumBBQ_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumBBQ.Checked)
            {
                size5.Text = "Medium";
            }
            else
            {
                size5.Text = "";
            }
        }

        private void largeBBQ_CheckedChanged(object sender, EventArgs e)
        {
            if (largeBBQ.Checked)
            {
                size5.Text = "Large";
            }
            else
            {
                size5.Text = "";
            }
        }

        private void regBBQ_CheckedChanged(object sender, EventArgs e)
        {
            if (regBBQ.Checked)
            {
                crust5.Text = "Regular Crust";
            }
            else
            {
                crust5.Text = "";
            }
        }

        private void thinBBQ_CheckedChanged(object sender, EventArgs e)
        {
            if (thinBBQ.Checked)
            {
                crust5.Text = "Thin Crust";
            }
            else
            {
                crust5.Text = "";
            }
        }

        private void stuffedBBQ_CheckedChanged(object sender, EventArgs e)
        {
            if (stuffedBBQ.Checked)
            {
                crust5.Text = "stuffed Crust";
            }
            else
            {
                crust5.Text = "";
            }
        }
    }
}