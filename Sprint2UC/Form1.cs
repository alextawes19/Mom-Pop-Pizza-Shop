using System.IO;

namespace Sprint2UC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //loginTab.Enabled = false;
            standardTab.Enabled = false;
            byoTab.Enabled = false;
            beveragesTab.Enabled = false;
            orderTab.Enabled = false;
            checkoutTab.Enabled = false;

            matchError.Text = "";
            eMatchError.Text = "";
            usernameError.Text = "";
            successPanel.Visible = false;

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
                usernamesWrite.WriteLine(username);
                usernamesWrite.Close();

                if ((password==conPassword) && (email==conEmail))
                {
                    registerTab.Enabled = false;
                    successPanel.Visible = true;
                    usernamesWrite.WriteLine(username);
                    passwordsWrite.WriteLine(password);
                    
                }

                usernamesWrite.Close();
                passwordsWrite.Close();
            }
            catch
            {

            }
            finally
            {

            }
            
           
        }
    }
}