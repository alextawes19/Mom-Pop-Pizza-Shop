using System.IO;

namespace Sprint2UC
{
    public partial class Form1 : Form
    {
        double price = 0.0;
        double drinkPrice = 0.0;
        public Form1()
        {
            InitializeComponent();
            //loginTab.Enabled = false;
            //standardTab.Enabled = false;
            //byoTab.Enabled = false;
            //beveragesTab.Enabled = false;
            //orderTab.Enabled = false;
            //checkoutTab.Enabled = false;

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

            pizza1.Text = "";
            pizza2.Text = "";
            pizza3.Text = "";
            pizza4.Text = "";
            pizza5.Text = "";
            pizza6.Text = "";

            drink1.Text = "";
            drink2.Text = "";
            drink3.Text = "";
            drink4.Text = "";
            drink5.Text = "";

            dsize1.Text = "";
            dsize2.Text = "";
            dsize3.Text = "";
            dsize4.Text = "";
            dsize5.Text = "";

            qt1.Text = "";
            qt2.Text = "";
            qt3.Text = "";
            qt4.Text = "";
            qt5.Text = "";

            pizzaTotal.Text = "";
            drinkTotal.Text = "";
            orderTotal.Text = "";

            cokeSmallRB.Enabled = false;
            cokeMediumRB.Enabled = false;
            cokeLargeRB.Enabled = false;
            cokeNumerator.Enabled = false;

            spriteSmallRB.Enabled = false;
            spriteMediumRB.Enabled = false;
            spriteLargeRB.Enabled = false;
            spriteNumerator.Enabled = false;

            powerSmallRB.Enabled = false;
            powerMediumRB.Enabled = false;
            powerLargeRB.Enabled = false;
            powerNumerator.Enabled = false;

            dpSmallRB.Enabled = false;
            dpMediumRB.Enabled = false;
            dpLargeRB.Enabled = false;
            dpNumerator.Enabled = false;

            teaSmallRB.Enabled = false;
            teaMediumRB.Enabled = false;
            teaLargeRB.Enabled = false;
            teaNumerator.Enabled = false;

            

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
                price += 9.99;
                pizzaTotal.Text = Convert.ToString(price);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                sizeGBcheese.Enabled = true;
                crustGBcheese.Enabled=true;
                pizza1.Text = "Cheese Pizza";
            }
            if (!cheeseCheck.Checked)
            {
                price -= 9.99;
                pizzaTotal.Text = Convert.ToString(price);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

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
                price += 9.99;
                pizzaTotal.Text = Convert.ToString(price);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                sizeGBpep.Enabled = true;
                crustGBpep.Enabled = true;
                pizza2.Text = "Pepperoni Pizza";
            }
            if (!pepCheck.Checked)
            {
                price -= 9.99;
                pizzaTotal.Text = Convert.ToString(price);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

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
                price += 9.99;
                pizzaTotal.Text = Convert.ToString(price);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                sizeGBSausage.Enabled = true;
                crustGBSausage.Enabled = true;
                pizza3.Text = "Sausage Pizza";
            }
            if (!sausageCheck.Checked)
            {
                price -= 9.99;
                pizzaTotal.Text = Convert.ToString(price);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

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
                price += 9.99;
                pizzaTotal.Text = Convert.ToString(price);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                sizeGBHawaiian.Enabled = true;
                crustGBHawaiian.Enabled = true;
                pizza4.Text = "Hawaiian Pizza";
            }
            if (!hawaiianCheck.Checked)
            {
                price -= 9.99;
                pizzaTotal.Text = Convert.ToString(price);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

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
                price += 9.99;
                pizzaTotal.Text = Convert.ToString(price);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                sizeGBbbq.Enabled = true;
                crustGBbbq.Enabled = true;
                pizza5.Text = "BBQ Chicken Pizza";
            }
            if (!bbqCheck.Checked)
            {
                price -= 9.99;
                pizzaTotal.Text = Convert.ToString(price);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

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

        //BEVERAGES START

        //COKE BEVERAGES
        private void cokeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (cokeCheck.Checked)
            {
                drinkPrice += 2.49;
                drinkTotal.Text = Convert.ToString("$" + drinkPrice);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                drink1.Text = "Coke";

                cokeSmallRB.Enabled = true;
                cokeMediumRB.Enabled = true;
                cokeLargeRB.Enabled = true;
                cokeNumerator.Enabled = true;

            }
            if (!cokeCheck.Checked)
            {
                drinkPrice -= 2.49;
                drinkTotal.Text = Convert.ToString("$" + drinkPrice);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                cokeSmallRB.Enabled = false;
                cokeMediumRB.Enabled = false;
                cokeLargeRB.Enabled = false;

                cokeSmallRB.Checked = false;
                cokeMediumRB.Checked = false;
                cokeLargeRB.Checked = false;

                cokeNumerator.Enabled = false;
                cokeNumerator.Value = 0;



                drink1.Text = "";
                qt1.Text = "";
            }
        }

        private void cokeSmallRB_CheckedChanged(object sender, EventArgs e)
        {
            if (cokeSmallRB.Checked)
            {
                dsize1.Text = "Small";
            }
            else
            {
                dsize1.Text = "";
            }
        }

        private void cokeMediumRB_CheckedChanged(object sender, EventArgs e)
        {
            if (cokeMediumRB.Checked)
            {
                dsize1.Text = "Medium";
            }
            else
            {
                dsize1.Text = "";
            }
        }

        private void cokeLargeRB_CheckedChanged(object sender, EventArgs e)
        {
            if (cokeLargeRB.Checked)
            {
                dsize1.Text = "Large";
            }
            else
            {
                dsize1.Text = "";
            }
        }

        private void cokeNumerator_ValueChanged(object sender, EventArgs e)
        {
            qt1.Text = Convert.ToString("x" + cokeNumerator.Value);
        }

        //SPRITE BEVERAGES
        private void spriteCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (spriteCheck.Checked)
            {
                drinkPrice += 2.49;
                drinkTotal.Text = Convert.ToString("$" + drinkPrice);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                drink2.Text = "Sprite";

                spriteSmallRB.Enabled = true;
                spriteMediumRB.Enabled = true;
                spriteLargeRB.Enabled = true;
                spriteNumerator.Enabled = true;

            }
            if (!spriteCheck.Checked)
            {
                drinkPrice -= 2.49;
                drinkTotal.Text = Convert.ToString("$" + drinkPrice);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                spriteSmallRB.Enabled = false;
                spriteMediumRB.Enabled = false;
                spriteLargeRB.Enabled = false;

                spriteSmallRB.Checked = false;
                spriteMediumRB.Checked = false;
                spriteLargeRB.Checked = false;

                spriteNumerator.Enabled = false;
                spriteNumerator.Value = 0;

                drink2.Text = "";
                qt2.Text = "";
            }
        }

        private void spriteSmallRB_CheckedChanged(object sender, EventArgs e)
        {
            if (spriteSmallRB.Checked)
            {
                dsize2.Text = "Small";
            }
            else
            {
                dsize2.Text = "";
            }
        }

        private void spriteMediumRB_CheckedChanged(object sender, EventArgs e)
        {
            if (spriteMediumRB.Checked)
            {
                dsize2.Text = "Medium";
            }
            else
            {
                dsize2.Text = "";
            }
        }

        private void spriteLargeRB_CheckedChanged(object sender, EventArgs e)
        {
            if (spriteLargeRB.Checked)
            {
                dsize2.Text = "Large";
            }
            else
            {
                dsize2.Text = "";
            }
        }

        private void spriteNumerator_ValueChanged(object sender, EventArgs e)
        {
            qt2.Text = Convert.ToString("x" + spriteNumerator.Value);
        }

        //POWERADE
        private void powerCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (powerCheck.Checked)
            {
                drinkPrice += 2.49;
                drinkTotal.Text = Convert.ToString("$" + drinkPrice);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                drink3.Text = "Powerade";

                powerSmallRB.Enabled = true;
                powerMediumRB.Enabled = true;
                powerLargeRB.Enabled = true;
                powerNumerator.Enabled = true;

            }
            if (!powerCheck.Checked)
            {
                drinkPrice -= 2.49;
                drinkTotal.Text = Convert.ToString("$" + drinkPrice);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                powerSmallRB.Enabled = false;
                powerMediumRB.Enabled = false;
                powerLargeRB.Enabled = false;

                powerSmallRB.Checked = false;
                powerMediumRB.Checked = false;
                powerLargeRB.Checked = false;

                powerNumerator.Enabled = false;
                powerNumerator.Value = 0;



                drink3.Text = "";
                qt3.Text = "";
            }
        }

        private void powerSmallRB_CheckedChanged(object sender, EventArgs e)
        {
            if (powerSmallRB.Checked)
            {
                dsize3.Text = "Small";
            }
            else
            {
                dsize3.Text = "";
            }
        }

        private void powerMediumRB_CheckedChanged(object sender, EventArgs e)
        {
            if (powerMediumRB.Checked)
            {
                dsize3.Text = "Medium";
            }
            else
            {
                dsize3.Text = "";
            }
        }

        private void powerLargeRB_CheckedChanged(object sender, EventArgs e)
        {
            if (powerLargeRB.Checked)
            {
                dsize3.Text = "Large";
            }
            else
            {
                dsize3.Text = "";
            }
        }

        private void powerNumerator_ValueChanged(object sender, EventArgs e)
        {
            qt3.Text = Convert.ToString("x" + powerNumerator.Value);
        }

        //DR PEPPER BEVERAGES
        private void dpCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (dpCheck.Checked)
            {
                drinkPrice += 2.49;
                drinkTotal.Text = Convert.ToString("$" + drinkPrice);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                drink4.Text = "Dr Pepper";

                dpSmallRB.Enabled = true;
                dpMediumRB.Enabled = true;
                dpLargeRB.Enabled = true;
                dpNumerator.Enabled = true;

            }
            if (!dpCheck.Checked)
            {
                drinkPrice -= 2.49;
                drinkTotal.Text = Convert.ToString("$" + drinkPrice);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                dpSmallRB.Enabled = false;
                dpMediumRB.Enabled = false;
                dpLargeRB.Enabled = false;

                dpSmallRB.Checked = false;
                dpMediumRB.Checked = false;
                dpLargeRB.Checked = false;

                dpNumerator.Enabled = false;
                dpNumerator.Value = 0;



                drink4.Text = "";
                qt4.Text = "";
            }
        }

        private void dpSmallRB_CheckedChanged(object sender, EventArgs e)
        {
            if (dpSmallRB.Checked)
            {
                dsize4.Text = "Small";
            }
            else
            {
                dsize4.Text = "";
            }
        }

        private void dpMediumRB_CheckedChanged(object sender, EventArgs e)
        {
            if (dpMediumRB.Checked)
            {
                dsize4.Text = "Medium";
            }
            else
            {
                dsize4.Text = "";
            }
        }

        private void dpLargeRB_CheckedChanged(object sender, EventArgs e)
        {
            if (dpLargeRB.Checked)
            {
                dsize4.Text = "Large";
            }
            else
            {
                dsize4.Text = "";
            }
        }

        private void dpNumerator_ValueChanged(object sender, EventArgs e)
        {
            qt4.Text = Convert.ToString("x" + dpNumerator.Value);
        }

        //SWEET TEA BEVERAGES
        private void teaCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (teaCheck.Checked)
            {
                drinkPrice += 2.49;
                drinkTotal.Text = Convert.ToString("$" + drinkPrice);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                drink5.Text = "Sweet Tea";

                teaSmallRB.Enabled = true;
                teaMediumRB.Enabled = true;
                teaLargeRB.Enabled = true;
                teaNumerator.Enabled = true;

            }
            if (!teaCheck.Checked)
            {
                drinkPrice -= 2.49;
                drinkTotal.Text = Convert.ToString("$" + drinkPrice);
                orderTotal.Text = Convert.ToString("$" + (price + drinkPrice));

                teaSmallRB.Enabled = false;
                teaMediumRB.Enabled = false;
                teaLargeRB.Enabled = false;

                teaSmallRB.Checked = false;
                teaMediumRB.Checked = false;
                teaLargeRB.Checked = false;

                teaNumerator.Enabled = false;
                teaNumerator.Value = 0;



                drink5.Text = "";
                qt5.Text = "";
            }
        }

        private void teaSmallRB_CheckedChanged(object sender, EventArgs e)
        {
            if (teaSmallRB.Checked)
            {
                dsize5.Text = "Small";
            }
            else
            {
                dsize5.Text = "";
            }
        }

        private void teaMediumRB_CheckedChanged(object sender, EventArgs e)
        {
            if (teaMediumRB.Checked)
            {
                dsize5.Text = "Medium";
            }
            else
            {
                dsize5.Text = "";
            }
        }

        private void teaLargeRB_CheckedChanged(object sender, EventArgs e)
        {
            if (teaLargeRB.Checked)
            {
                dsize5.Text = "Large";
            }
            else
            {
                dsize5.Text = "";
            }
        }

        private void teaNumerator_ValueChanged(object sender, EventArgs e)
        {
            qt5.Text = Convert.ToString("x" + teaNumerator.Value);
        }

        private void pizzaTotal_Click(object sender, EventArgs e)
        {

        }

        private void dollaSign_Click(object sender, EventArgs e)
        {

        }
    }
}