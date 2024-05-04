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
    public partial class RealApp : Form
    {
        public RealApp()
        {
            InitializeComponent();
        }
        IFirebaseConfig fcon = new FirebaseConfig()
        {
            AuthSecret = "Y54EM2RbRp6XCBCuurEiUuYQMwtJmzGnpSQooqb7",
            BasePath = "https://testing421-8db58-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        private void xuiFormDesign1_WorkingArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xuiFormDesign1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            var result = client.Delete("ProjetList/" + rollTbox.Text);
            MessageBox.Show("data deleted successfully");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            DateTime reqdt = DateTime.Now.Date;
            DateTime retdt = datefin.Value.Date;

            TimeSpan ts = retdt - reqdt;
            int days = ts.Days;
            if (days <= 3)
            {
                resume.Text = days.ToString() + " Jours restant ";
                MessageBox.Show("moin de 3 jours");
                resume.BackColor = Color.Red;
            }
            else
            {


                resume.Text = days.ToString() + " Jours";
                resume.BackColor = Color.Green;

            }
            budgetp.Text = Budget.Text;
            budgetc.Text = (int.Parse(loyer.Text) + int.Parse(Communication.Text) + int.Parse(autre.Text) + int.Parse(internet.Text)).ToString();
            if (budgetc.Text == Budget.Text)
            {
                budgetc.BackColor = (Color.Red);
            }
            else
            {
                budgetc.BackColor = Color.Green;
            }
            rest.Text = (int.Parse(Budget.Text) - int.Parse(budgetc.Text)).ToString();

            if (int.Parse(rest.Text) <= 3)
            {
                rest.BackColor = (Color.Red);
            }
            else
            {
                rest.BackColor = Color.Green;
            }
            if (int.Parse(Budget.Text) >= int.Parse(budgetc.Text))
            {
                state.Text = " Correcte ";
                state.BackColor = Color.Green;
            }

            else
            {
                MessageBox.Show("Faute de sesair !!" +
                    " Budget Total doit etre superieur au total de budget élementaire");
                state.Text = " non stable ";

                state.BackColor = Color.Red;

            }


            #region store in the studentlist
            Student std = new Student()
            {
                Projet = projet.Text,
                RollNo = rollTbox.Text,
                Budget = Budget.Text,
                salaire1 = Salaire1.Text,
                salaire2 = Salaire2.Text,
                salaire3 = Salaire3.Text,
                datedeb = datedeb.Text,
                datefin = datefin.Text,
                datefinr = datefinR.Text,
                com = Communication.Text,
                loyer = loyer.Text,
                internet = internet.Text,
                rest = rest.Text,
                resume = resume.Text,
                budgetc = budgetc.Text,
                Autre = autre.Text

            };
            var setter = client.Set("ProjetList/" + rollTbox.Text, std);
            MessageBox.Show("data inserted successfully");
            #endregion

            //store in sno
            FirebaseResponse res = client.Get(@"Counter");
            int Counter = int.Parse(res.ResultAs<string>());

            MyRoll roll = new MyRoll()
            {
                RollNo = rollTbox.Text
            };

            var set2 = client.Set(@"Counter", ++Counter);
            var set3 = client.Set(@"Sno/" + Counter, roll);

            MessageBox.Show("INSERTED SUCCESSFULLY");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            var result = client.Get("ProjetList/" + rollTbox.Text);
            Student std = result.ResultAs<Student>();
            projet.Text = std.Projet;

            Budget.Text = std.Budget;
            Salaire1.Text = std.salaire1;
            Salaire2.Text = std.salaire2;
            Salaire3.Text = std.salaire3;
            datedeb.Text = std.datedeb;
            datefin.Text = std.datefin;
            datefinR.Text = std.datefinr;
            resume.Text = std.resume;
            rest.Text = std.rest;
            budgetc.Text = std.budgetc;
            Communication.Text = std.com;
            loyer.Text = std.loyer;
            internet.Text = std.internet;
            autre.Text = std.Autre;
            MessageBox.Show("data retrieved successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Projet");
            dt.Columns.Add("No");
            dt.Columns.Add("Budget");
            dt.Columns.Add("dateon");
            dt.Columns.Add("dateoff");
            dt.Columns.Add("datelimit");
            dt.Columns.Add("com");
            dt.Columns.Add("Budgetre");
            dt.Columns.Add("datelimit1");
            dt.Columns.Add("com1");

            advancedDataGridView1.Rows.Clear();
            FirebaseResponse res = client.Get(@"Counter");
            int Counter = int.Parse(res.ResultAs<string>());

            for (int i = 1; i <= Counter; i++)
            {
                FirebaseResponse res2 = client.Get(@"Sno/" + i + "/RollNo");
                string RollNo = res2.ResultAs<string>();

                var res3 = client.Get(@"ProjetList/" + RollNo);
                Student std = res3.ResultAs<Student>();


                if (std.Projet != "") // (std!=null)
                {
                    dt.Rows.Add(std.Projet, std.RollNo, std.Budget, std.datedeb, std.datefin, std.datefinr, std.com, std.budgetc, std.rest, std.resume);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                advancedDataGridView1.Rows.Add(item.ItemArray);
            }

            }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void RealApp_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(fcon);
            }
            catch
            {
                MessageBox.Show("there was problem in the internet.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

          
            
        }

        private void button10_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Projet");
            dt.Columns.Add("No");
            dt.Columns.Add("Budget");
            dt.Columns.Add("dateon");
            dt.Columns.Add("dateoff");
            dt.Columns.Add("datelimit");
            dt.Columns.Add("com");
            dt.Columns.Add("Budgetre");
            dt.Columns.Add("datelimit1");
            dt.Columns.Add("com1");

            advancedDataGridView2.Rows.Clear();
            FirebaseResponse res1 = client.Get(@"Counter1");
            int Counter1 = int.Parse(res1.ResultAs<string>());

            for (int i = 1; i <= Counter1; i++)
            {
                FirebaseResponse res12 = client.Get(@"Sno1/" + i + "/RollNo1");
                string RollNo1 = res12.ResultAs<string>();

                var res13 = client.Get(@"ActionList/" + RollNo1);
                action std = res13.ResultAs<action>();


                if (std.Projet1 != "") // (std!=null)
                {
                    dt.Rows.Add(std.Projet1, std.RollNo1, std.budget, std.datedeb1, std.datefin1, std.datefinr1, std.responsable, std.budgetc1, std.rest1, std.resume1);
                }
            }

            foreach (DataRow item in dt.Rows)
            {
                advancedDataGridView2.Rows.Add(item.ItemArray);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DateTime reqdt = DateTime.Now.Date;
            DateTime retdt = datefin.Value.Date;

            TimeSpan ts = retdt - reqdt;
            int days = ts.Days;
            if (days <= 3)
            {
                resume1.Text = days.ToString() + " Jours restant ";
                MessageBox.Show("moin de 3 jours");
                resume1.BackColor = Color.Red;
            }
            else
            {


                resume1.Text = days.ToString() + " Jours";
                resume1.BackColor = Color.Green;

            }

            budgetp1.Text = budget1.Text;
            budgetc.Text = (int.Parse(transport.Text) + int.Parse(alimentation.Text) + int.Parse(location.Text) + int.Parse(achatm.Text)).ToString();
            if (budgetc1.Text == budget1.Text)
            {
                budgetc1.BackColor = (Color.Red);
            }
            else
            {
                budgetc1.BackColor = Color.Green;
            }
            rest1.Text = (int.Parse(budget1.Text) - int.Parse(budgetc1.Text)).ToString();

            if (int.Parse(rest1.Text) <= 3)
            {
                rest1.BackColor = (Color.Red);
            }
            else
            {
                rest1.BackColor = Color.Green;
            }
            if (int.Parse(budget1.Text) >= int.Parse(budgetc1.Text))
            {
                state1.Text = " Correcte ";
                state1.BackColor = Color.Green;
            }

            else
            {
                MessageBox.Show("Faute de sesair !!" +
                    " Budget Total doit etre superieur au total de budget élementaire");
                state1.Text = " non stable ";

                state1.BackColor = Color.Red;

            }


            rest.Text = (int.Parse(budget1.Text) - int.Parse(budgetc.Text)).ToString();
            action std = new action()
            {
                Projet1 = projet1.Text,
                RollNo1 = rollTbox1.Text,
                budget = budget1.Text,
                hebergement = hebergement.Text,
                responsable = responsable.Text,
                lieu = lieu.Text,
                datedeb1 = datedeb1.Text,
                datefin1 = datefin1.Text,
                datefinr1 = datefr.Text,
                achat = achatm.Text,
                alimentation = alimentation.Text,
                location = location.Text,
                rest1 = rest1.Text,
                resume1 = resume1.Text,
                budgetc1 = budgetc1.Text,
                transport = transport.Text
            };
            var setter = client.Update("ActionList/" + rollTbox1.Text, std);
            MessageBox.Show("data inserted successfully");
        }

        private void button7_Click(object sender, EventArgs e)
        {

            DateTime reqdt = DateTime.Now.Date;
            DateTime retdt = datefin.Value.Date;

            TimeSpan ts = retdt - reqdt;
            int days = ts.Days;
            if (days <= 3)
            {
                resume1.Text = days.ToString() + " Jours restant ";
                MessageBox.Show("moin de 3 jours");
                resume1.BackColor = Color.Red;
            }
            else
            {


                resume1.Text = days.ToString() + " Jours";
                resume1.BackColor = Color.Green;

            }
            budgetp1.Text = budget1.Text;
            budgetc1.Text = (int.Parse(transport.Text) + int.Parse(alimentation.Text) + int.Parse(location.Text) + int.Parse(achatm.Text)).ToString();
            if (budgetc1.Text == budget1.Text)
            {
                budgetc1.BackColor = (Color.Red);
            }
            else
            {
                budgetc1.BackColor = Color.Green;
            }
            rest1.Text = (int.Parse(budget1.Text) - int.Parse(budgetc1.Text)).ToString();

            if (int.Parse(rest1.Text) >= 10)
            {
                rest1.BackColor = (Color.Red);
            }
            else
            {
                rest1.BackColor = Color.Green;
            }
            if (int.Parse(budget1.Text) >= int.Parse(budgetc1.Text))
            {
                state1.Text = " Correcte ";
                state1.BackColor = Color.Green;
            }

            else
            {
                MessageBox.Show("Faute de sesair !!" +
                    " Budget Total doit etre superieur au total de budget élementaire");
                state1.Text = " non stable ";

                state1.BackColor = Color.Red;

            }


            #region store in the studentlist
            action std = new action()
            {
                Projet1 = projet1.Text,
                RollNo1 = rollTbox1.Text,
                budget = budget1.Text,
                hebergement = hebergement.Text,
                responsable = responsable.Text,
                lieu = lieu.Text,
                datedeb1 = datedeb1.Text,
                datefin1 = datefin1.Text,
                datefinr1 = datefr.Text,
                achat = achatm.Text,
                alimentation = alimentation.Text,
                location = location.Text,
                rest1 = rest1.Text,
                resume1 = resume1.Text,
                budgetc1 = budgetc1.Text,
                transport = transport.Text

            };
            var setter = client.Set("ActionList/" + rollTbox1.Text, std);
            MessageBox.Show("data inserted successfully");
            #endregion

            //store in sno
            FirebaseResponse res1 = client.Get(@"Counter1");
            int Counter1 = int.Parse(res1.ResultAs<string>());

            MyRoll1 roll1 = new MyRoll1()
            {
                RollNo1 = rollTbox1.Text
            };

            var set12 = client.Set(@"Counter1", ++Counter1);
            var set13 = client.Set(@"Sno1/" + Counter1, roll1);

            MessageBox.Show("INSERTED SUCCESSFULLY");
        }

        private void button9_Click(object sender, EventArgs e)
        {

            var result = client.Delete("ActiontList/" + rollTbox1.Text);
            MessageBox.Show("data deleted successfully");
        }

        private void button8_Click(object sender, EventArgs e)
        {

            var result = client.Get("ActionList/" + rollTbox1.Text);
            action std = result.ResultAs<action>();
            projet1.Text = std.Projet1;

            budget1.Text = std.budget;
            lieu.Text = std.lieu;
            hebergement.Text = std.hebergement;
            responsable.Text = std.responsable;
            datedeb1.Text = std.datedeb1;
            datefin1.Text = std.datefin1;
            datefr.Text = std.datefinr1;
            resume1.Text = std.resume1;
            rest1.Text = std.rest1;
            budgetc1.Text = std.budgetc1;
            achatm.Text = std.achat;
            location.Text = std.location;
            alimentation.Text = std.alimentation;
            transport.Text = std.transport;
            MessageBox.Show("data retrieved successfully");
        }

        private void butonup_Click(object sender, EventArgs e)
        {
            DateTime reqdt = DateTime.Now.Date;
            DateTime retdt = datefin.Value.Date;

            TimeSpan ts = retdt - reqdt;
            int days = ts.Days;
            if (days <= 3)
            {
                resume.Text = days.ToString() + " Jours restant ";
                MessageBox.Show("moin de 3 jours");
                resume.BackColor = Color.Red;
            }
            else
            {


                resume.Text = days.ToString() + " Jours";
                resume.BackColor = Color.Green;

            }

            budgetp.Text = Budget.Text;
            budgetc.Text = (int.Parse(loyer.Text) + int.Parse(Communication.Text) + int.Parse(autre.Text) + int.Parse(internet.Text)).ToString();
            if (budgetc.Text == Budget.Text)
            {
                budgetc.BackColor = (Color.Red);
            }
            else
            {
                budgetc.BackColor = Color.Green;
            }
            rest.Text = (int.Parse(Budget.Text) - int.Parse(budgetc.Text)).ToString();

            if (int.Parse(rest.Text) <= 3)
            {
                rest.BackColor = (Color.Red);
            }
            else
            {
                rest.BackColor = Color.Green;
            }
            if (int.Parse(Budget.Text) >= int.Parse(budgetc.Text))
            {
                state.Text = " Correcte ";
                state.BackColor = Color.Green;
            }

            else
            {
                MessageBox.Show("Faute de sesair !!" +
                    " Budget Total doit etre superieur au total de budget élementaire");
                state.Text = " non stable ";

                state.BackColor = Color.Red;

            }


            rest.Text = (int.Parse(Budget.Text) - int.Parse(budgetc.Text)).ToString();
            Student std = new Student()
            {
                Projet = projet.Text,
                RollNo = rollTbox.Text,
                salaire1 = Salaire1.Text,
                salaire2 = Salaire2.Text,
                salaire3 = Salaire3.Text,
                Budget = Budget.Text,

                datedeb = datedeb.Text,
                datefin = datefin.Text,
                datefinr = datefinR.Text,
                com = Communication.Text,
                Autre = autre.Text,
                loyer = loyer.Text,
                rest = rest.Text,
                resume = resume.Text,
                budgetc = budgetc.Text,
                internet = internet.Text,
            };
            var setter = client.Update("ProjetList/" + rollTbox.Text, std);
            MessageBox.Show("data inserted successfully");
        }

        private void resume_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
