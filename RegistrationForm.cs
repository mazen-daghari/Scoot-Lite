using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace learnFireBase
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "Y54EM2RbRp6XCBCuurEiUuYQMwtJmzGnpSQooqb7",
            BasePath = "https://testing421-8db58-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("No Internet or Connection Problem");
            }
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(UsernameTbox.Text) &&
               string.IsNullOrWhiteSpace(passTbox.Text) &&
               string.IsNullOrWhiteSpace(GenderCbox.Text) &&
               string.IsNullOrWhiteSpace(nameTbox.Text) &&
               string.IsNullOrWhiteSpace(NicTbox.Text))
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            #endregion

            MyUser user = new MyUser()
            {
                Username = t1.Text,
                Password = t2.Text,
                Gender = t3.Text,
                Fullname =t4.Text,
                NICno = t5.Text
            };

            SetResponse set = client.Set(@"Users/" + t1.Text, user);

            MessageBox.Show("Successfully registered!");
        }


        private void xuiFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
                #region Condition
                if (string.IsNullOrWhiteSpace(t1.Text) &&
                   string.IsNullOrWhiteSpace(t2.Text) &&
                   string.IsNullOrWhiteSpace(t3.Text) &&
                   string.IsNullOrWhiteSpace(t4.Text) &&
                   string.IsNullOrWhiteSpace(t5.Text))
                {
                    MessageBox.Show("Please Fill All The Fields");
                    return;
                }
                #endregion

                MyUser user = new MyUser()
                {
                    Username = t1.Text,
                    Password =t2.Text,
                    Gender =t3.Text,
                    Fullname = t4.Text,
                    NICno = t5.Text
                };

                SetResponse set = client.Set(@"Users/" + t1.Text, user);

                MessageBox.Show("Successfully registered!");
            
        }

        private void xuiFormDesign1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
