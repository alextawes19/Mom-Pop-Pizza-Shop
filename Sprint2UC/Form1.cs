using System.IO;
using System.Text;
using static System.Windows.Forms.Design.AxImporter;

namespace Sprint2UC
{
    public partial class Form1 : Form
    {
        double price = 0.0;
        double drinkPrice = 0.0;
        int byoToppings = 0;
        string exCheeseSelect = "";
        string meatSelect = "";
        string vegSelect = "";
        string path = @"C:\Temp\usernames.txt";
        string path2 = @"C:\Temp\passwords.txt";
        public Form1()
        {
            InitializeComponent();
            //loginTab.Enabled = false;
            standardTab.Enabled = false;
            byoTab.Enabled = false;
            beveragesTab.Enabled = false;
            orderTab.Enabled = false;
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

            cut.Text = "";
            sauce.Text = "";
            cheese.Text = "";
            extraCheese.Text = "";
            meat.Text = "";
            veggies.Text = "";


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

            //CHECKOUT TAB
            accountNum.Visible = false;
            routingNum.Visible = false;
            accountNumInput.Visible = false;
            routingNumInput.Visible = false;

            completePanel.Visible = false;

            checkoutTotal.Text = "";
            checkoutButton.Enabled = false;

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
            string username = usernameBox.Text;
            string password = passwordBox.Text;

            bool userMatches = false;
            bool passwordMatches = false;

            using (StreamReader sr = File.OpenText(path))
            {
                string contents = sr.ReadToEnd();
                if (contents.Contains(username))
                {
                    userMatches = true;
                }
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string contents = sr.ReadToEnd();
                if (contents.Contains(password))
                {
                    passwordMatches = true;
                }
            }

            if ((userMatches == true) && (passwordMatches == true))
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

                if ((password == conPassword) && (email == conEmail))
                {
                    registerTab.Enabled = false;
                    successPanel.Visible = true;


                    if (!File.Exists(path))
                    {
                        using (FileStream fs = File.Create(path))
                        {
                            Byte[] usernameWrite = new UTF8Encoding(true).GetBytes(username);
                            fs.Write(usernameWrite, 0, usernameWrite.Length);

                        }

                        using (FileStream fs = File.Create(path2))
                        {

                            Byte[] passwordWrite = new UTF8Encoding(true).GetBytes(password);
                            fs.Write(passwordWrite, 0, passwordWrite.Length);

                        }
                    }
                    else
                    {
                        StreamWriter usernameRead = new StreamWriter(path, true);
                        StreamWriter passwordRead = new StreamWriter(path2, true);

                        usernameRead.WriteLine(username);
                        passwordRead.WriteLine(password);

                        usernameRead.Close();
                        passwordRead.Close();

                    }
                   
                }


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
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                sizeGBcheese.Enabled = true;
                crustGBcheese.Enabled=true;
                pizza1.Text = "Cheese Pizza";
            }
            if (!cheeseCheck.Checked)
            {
                price -= 9.99;
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                pizza1.Text = "";
                sizeGBcheese.Enabled = false;
                crustGBcheese.Enabled= false;

    
                smallCheese.Checked = false;
                mediumCheese.Checked = false;
                largeCheese.Checked = false;
                xlCheese.Checked = false;
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
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                sizeGBpep.Enabled = true;
                crustGBpep.Enabled = true;
                pizza2.Text = "Pepperoni Pizza";
            }
            if (!pepCheck.Checked)
            {
                price -= 9.99;
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                pizza2.Text = "";
                sizeGBpep.Enabled = false;
                crustGBpep.Enabled = false;


                smallPep.Checked = false;
                mediumPep.Checked = false;
                largePep.Checked = false;
                xlPep.Checked = false;
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
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                sizeGBSausage.Enabled = true;
                crustGBSausage.Enabled = true;
                pizza3.Text = "Sausage Pizza";
            }
            if (!sausageCheck.Checked)
            {
                price -= 9.99;
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                pizza3.Text = "";
                sizeGBSausage.Enabled = false;
                crustGBSausage.Enabled = false;


                smallSausage.Checked = false;
                mediumSausage.Checked = false;
                largeSausage.Checked = false;
                xlSausage.Checked = false;
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
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                sizeGBHawaiian.Enabled = true;
                crustGBHawaiian.Enabled = true;
                pizza4.Text = "Hawaiian Pizza";
            }
            if (!hawaiianCheck.Checked)
            {
                price -= 9.99;
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                pizza4.Text = "";
                sizeGBHawaiian.Enabled = false;
                crustGBHawaiian.Enabled = false;


                smallHawaiian.Checked = false;
                mediumHawaiian.Checked = false;
                largeHawaiian.Checked = false;
                xlHawaiian.Checked = false;
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
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                sizeGBbbq.Enabled = true;
                crustGBbbq.Enabled = true;
                pizza5.Text = "BBQ Chicken Pizza";
            }
            if (!bbqCheck.Checked)
            {
                price -= 9.99;
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                pizza5.Text = "";
                sizeGBbbq.Enabled = false;
                crustGBbbq.Enabled = false;


                smallBBQ.Checked = false;
                mediumBBQ.Checked = false;
                largeBBQ.Checked = false;
                xlBBQ.Checked = false;
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
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (drinkPrice < 0)
                {
                    drinkTotal.Text = "0";
                }

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
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (drinkPrice < 0)
                {
                    drinkTotal.Text = "0";
                }

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
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (drinkPrice < 0)
                {
                    drinkTotal.Text = "0";
                }

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
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (drinkPrice < 0)
                {
                    drinkTotal.Text = "0";
                }

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
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (drinkPrice < 0)
                {
                    drinkTotal.Text = "0";
                }

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
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (drinkPrice < 0)
                {
                    drinkTotal.Text = "0";
                }

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
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (drinkPrice < 0)
                {
                    drinkTotal.Text = "0";
                }

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
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (drinkPrice < 0)
                {
                    drinkTotal.Text = "0";
                }

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
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (drinkPrice < 0)
                {
                    drinkTotal.Text = "0";
                }

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
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (drinkPrice < 0)
                {
                    drinkTotal.Text = "0";
                }

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

        //CHECKOUT TAB CODE

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                accountNum.Visible = true;
                routingNum.Visible = true;
                accountNumInput.Visible = true;
                routingNumInput.Visible = true;
            }
            if (!check.Checked)
            {
                accountNum.Visible = false;
                routingNum.Visible = false;
                accountNumInput.Visible = false;
                routingNumInput.Visible = false;
            }
        }

        private void delivery_CheckedChanged(object sender, EventArgs e)
        {
            if (delivery.Checked)
            {
                checkoutButton.Enabled = true;
            }
        }

        private void takeout_CheckedChanged(object sender, EventArgs e)
        {
            if (takeout.Checked)
            {
                checkoutButton.Enabled = true;
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            if (creditCard.Checked || cash.Checked || check.Checked)
            {
                standardTab.Enabled = false;
                byoTab.Enabled = false;
                beveragesTab.Enabled = false;
                orderTab.Enabled = false;
                checkoutTab.Enabled = false;

                completePanel.Visible = true;
                if (delivery.Checked)
                {
                    completeMessage.Text = "You completed your order! Expected Delivery Time: 35 minutes";
                }
                else
                {
                    completeMessage.Text = "You completed your order! It will be ready in the store";
                }
               
            }
        }

        //BYO PIZZA 

        private void byoSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (byoSmall.Checked)
            {
                price += 7.99;
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2))); 
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                pizza6.Text = "Custom";
                size6.Text = "Small";
            }
            if (!byoSmall.Checked)
            {
                price -= 7.99;
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                pizza6.Text = "";
                size6.Text = "";
            }
        }

        private void byoMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (byoMedium.Checked)
            {
                price += 8.99;
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                pizza6.Text = "Custom";
                size6.Text = "Medium";
            }
            if (!byoMedium.Checked)
            {
                price -= 8.99;
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                pizza6.Text = "";
                size6.Text = "";
            }
        }

        private void byoLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (byoLarge.Checked)
            {
                price += 9.99;
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                pizza6.Text = "Custom";
                size6.Text = "Large";
            }
            if (!byoLarge.Checked)
            {
                price -= 9.99;
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                pizza6.Text = "";
                size6.Text = "";
            }
        }

        private void byoRegularCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (byoRegularCrust.Checked)
            {
                crust6.Text = "Regular Crust";
            }
            
        }

        private void byoThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (byoThinCrust.Checked)
            {
                crust6.Text = "Thin Crust";
            }
        }

        private void byoStuffedCrust_CheckedChanged(object sender, EventArgs e)
        {
            if (byoStuffedCrust.Checked)
            {
                crust6.Text = "Stuffed Crust";
            }
        }

        private void byoNormalCut_CheckedChanged(object sender, EventArgs e)
        {
            if (byoNormalCut.Checked)
            {
                cut.Text = "Normal Cut";
            }
        }

        private void sauce_Click(object sender, EventArgs e)
        {

        }

        private void byoCleanCut_CheckedChanged(object sender, EventArgs e)
        {
            if (byoCleanCut.Checked)
            {
                cut.Text = "Clean Cut";
            }
        }

        private void byoSquareCut_CheckedChanged(object sender, EventArgs e)
        {
            if (byoSquareCut.Checked)
            {
                cut.Text = "Square Cut";
            }
        }

        private void byoOriginalSauce_CheckedChanged(object sender, EventArgs e)
        {
            if (byoOriginalSauce.Checked)
            {
                sauce.Text = "Original Sauce";
            }
        }

        private void byoBBQSauce_CheckedChanged(object sender, EventArgs e)
        {
            if (byoBBQSauce.Checked)
            {
                sauce.Text = "BBQ Sauce";
            }
        }

        private void byoRanchSauce_CheckedChanged(object sender, EventArgs e)
        {
            if (byoRanchSauce.Checked)
            {
                sauce.Text = "Ranch Sauce";
            }
        }

        private void byoNormalCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (byoNormalCheese.Checked)
            {
                cheese.Text = "Normal Cheese";
            }
        }

        private void byoLightCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (byoLightCheese.Checked)
            {
                cheese.Text = "Light Cheese";
            }
        }

        private void byoNoCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (byoNoCheese.Checked)
            {
                cheese.Text = "No Cheese";
            }
        }

        private void meat_Click(object sender, EventArgs e)
        {

        }

        private void xlCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (xlCheese.Checked)
            {
                size1.Text = "XL";
            }
            else
            {
                size1.Text = "";
            }
        }

        private void xlPep_CheckedChanged(object sender, EventArgs e)
        {
            if (xlPep.Checked)
            {
                size2.Text = "XL";
            }
            else
            {
                size2.Text = "";
            }
        }

        private void xlSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (xlSausage.Checked)
            {
                size3.Text = "XL";
            }
            else
            {
                size3.Text = "";
            }
        }

        private void xlHawaiian_CheckedChanged(object sender, EventArgs e)
        {
            if (xlHawaiian.Checked)
            {
                size4.Text = "XL";
            }
            else
            {
                size4.Text = "";
            }
        }

        private void xlBBQ_CheckedChanged(object sender, EventArgs e)
        {
            if (xlBBQ.Checked)
            {
                size5.Text = "XL";
            }
            else
            {
                size5.Text = "";
            }
        }

        private void byoExtraLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (byoExtraLarge.Checked)
            {
                price += 10.99;
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                pizza6.Text = "Custom";
                size6.Text = "XL";
            }
            if (!byoExtraLarge.Checked)
            {
                price -= 10.99;
                pizzaTotal.Text = Convert.ToString(Math.Round(price, 2));
                orderTotal.Text = Convert.ToString("$" + (Math.Round((price + drinkPrice), 2)));
                checkoutTotal.Text = Convert.ToString("$" + (Math.Round(((price + drinkPrice) * 1.04), 2)));
                if (price < 0)
                {
                    pizzaTotal.Text = "0";
                }

                pizza6.Text = "";
                size6.Text = "";
            }
        }

        private void byoExtra_CheckedChanged(object sender, EventArgs e)
        {
            if (byoExtra.Checked)
            {
                byoToppings += 1;
                if (byoToppings > 4)
                {
                    byoToppings += 1;
                    byoExtra.Checked = false;
                }
                exCheeseSelect += "Extra ";
                extraCheese.Text = exCheeseSelect;
            }
            if (!byoExtra.Checked)
            {
                byoToppings -= 1;
                exCheeseSelect = extraCheese.Text;
                exCheeseSelect = exCheeseSelect.Replace("Extra ", ""); 
                extraCheese.Text = exCheeseSelect;
            }
        }

        private void byoParmesan_CheckedChanged(object sender, EventArgs e)
        {
            if (byoParmesan.Checked)
            {
                byoToppings += 1;
                if (byoToppings > 4)
                {
                    byoToppings += 1;
                    byoParmesan.Checked = false;
                }
                exCheeseSelect += "Parmesan ";
                extraCheese.Text = exCheeseSelect;
            }
            if (!byoParmesan.Checked)
            {
                byoToppings -= 1;
                exCheeseSelect = extraCheese.Text;
                exCheeseSelect = exCheeseSelect.Replace("Parmesan ", "");
                extraCheese.Text = exCheeseSelect;
            }
        }

        private void byoTripleBlend_CheckedChanged(object sender, EventArgs e)
        {
            if (byoTripleBlend.Checked)
            {
                byoToppings += 1;
                if (byoToppings > 4)
                {
                    byoToppings += 1;
                    byoTripleBlend.Checked = false;
                }
                exCheeseSelect += "Triple Blend ";
                extraCheese.Text = exCheeseSelect;
            }
            if (!byoTripleBlend.Checked)
            {
                byoToppings -= 1;
                exCheeseSelect = extraCheese.Text;
                exCheeseSelect = exCheeseSelect.Replace("Triple Blend ", "");
                extraCheese.Text = exCheeseSelect;
            }
        }

        private void byoPep_CheckedChanged(object sender, EventArgs e)
        {
            if (byoPep.Checked)
            {
                byoToppings += 1;
                if (byoToppings > 4)
                {
                    byoToppings += 1;
                    byoPep.Checked = false;
                }
                meatSelect += "Pepperoni ";
                meat.Text = meatSelect;
            }
            if (!byoPep.Checked)
            {
                byoToppings -= 1;
                meatSelect = meat.Text;
                meatSelect = meatSelect.Replace("Pepperoni ", "");
                meat.Text = meatSelect;
            }
        }

        private void byoChk_CheckedChanged(object sender, EventArgs e)
        {
            if (byoChk.Checked)
            {
                byoToppings += 1;
                if (byoToppings > 4)
                {
                    byoToppings += 1;
                    byoChk.Checked = false;
                }
                meatSelect += "Chicken ";
                meat.Text = meatSelect;
            }
            if (!byoChk.Checked)
            {
                byoToppings -= 1;
                meatSelect = meat.Text;
                meatSelect = meatSelect.Replace("Chicken ", "");
                meat.Text = meatSelect;
            }
        }

        private void byoSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (byoSausage.Checked)
            {
                byoToppings += 1;
                if (byoToppings > 4)
                {
                    byoToppings += 1;
                    byoSausage.Checked = false;
                }
                meatSelect += "Sausage ";
                meat.Text = meatSelect;
            }
            if (!byoSausage.Checked)
            {
                byoToppings -= 1;
                meatSelect = meat.Text;
                meatSelect = meatSelect.Replace("Sausage ", "");
                meat.Text = meatSelect;
            }
        }

        private void byoPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (byoPeppers.Checked)
            {
                byoToppings += 1;
                if (byoToppings > 4)
                {
                    byoToppings += 1;
                    byoPeppers.Checked = false;
                }
                vegSelect += "Peppers ";
                veggies.Text = vegSelect;
            }
            if (!byoPeppers.Checked)
            {
                byoToppings -= 1;
                vegSelect = veggies.Text;
                vegSelect = vegSelect.Replace("Peppers ", "");
                veggies.Text = vegSelect;
            }
        }

        private void byoOnions_CheckedChanged(object sender, EventArgs e)
        {
            if (byoOnions.Checked)
            {
                byoToppings += 1;
                if (byoToppings > 4)
                {
                    byoToppings += 1;
                    byoOnions.Checked = false;
                }
                vegSelect += "Onions ";
                veggies.Text = vegSelect;
            }
            if (!byoOnions.Checked)
            {
                byoToppings -= 1;
                vegSelect = veggies.Text;
                vegSelect = vegSelect.Replace("Onions ", "");
                veggies.Text = vegSelect;
            }
        }

        private void byoMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (byoMushrooms.Checked)
            {
                byoToppings += 1;
                if (byoToppings > 4)
                {
                    byoToppings += 1;
                    byoMushrooms.Checked = false;
                }
                vegSelect += "Mushrooms ";
                veggies.Text = vegSelect;
            }
            if (!byoMushrooms.Checked)
            {
                byoToppings -= 1;
                vegSelect = veggies.Text;
                vegSelect = vegSelect.Replace("Mushrooms ", "");
                veggies.Text = vegSelect;
            }
        }

        private void byoClearButton_Click(object sender, EventArgs e)
        {
            byoSmall.Checked = false;
            byoMedium.Checked = false;
            byoLarge.Checked = false;
            byoExtraLarge.Checked = false;
            byoRegularCrust.Checked = false;
            byoThinCrust.Checked = false;
            byoStuffedCrust.Checked = false;
            byoNormalCut.Checked = false;
            byoCleanCut.Checked = false;
            byoSquareCut.Checked = false;
            byoOriginalSauce.Checked = false;
            byoBBQSauce.Checked = false;
            byoRanchSauce.Checked = false;
            byoNormalCheese.Checked = false;
            byoLightCheese.Checked = false;
            byoNoCheese.Checked = false;
            byoExtra.Checked = false;
            byoParmesan.Checked = false;
            byoTripleBlend.Checked = false;
            byoPep.Checked = false;
            byoChk.Checked = false;
            byoSausage.Checked = false;
            byoPeppers.Checked = false;
            byoOnions.Checked = false;
            byoMushrooms.Checked = false;
            crust6.Text = "";
            cut.Text = "";
            sauce.Text = "";
            cheese.Text = "";
        }
    }
}