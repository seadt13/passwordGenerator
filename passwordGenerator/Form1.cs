namespace passwordGenerator
{
    public partial class Form1 : Form
    {
        int currentPasswordLength=0;
        Random character=new Random();
        public Form1()
        {
            InitializeComponent();
            tbPasswordLength.Minimum = 5;
            tbPasswordLength.Maximum = 16;
            passwordGenerator(5);
        }
        private void passwordGenerator(int passwordLength)
        {
            string allChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            string randomPassword = "";
            
            for (int i = 0; i < passwordLength; i++)
            {
                int randomNum=character.Next(0,allChars.Length);
                randomPassword += allChars[randomNum];
            }
            password.Text= randomPassword;
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(password.Text);
        }

        private void tbPasswordLength_Scroll(object sender, EventArgs e)
        {
            lbPasswordLength.Text="Password Length: "+ tbPasswordLength.Value.ToString();
            currentPasswordLength=tbPasswordLength.Value;
            passwordGenerator(currentPasswordLength);
        }
    }
}