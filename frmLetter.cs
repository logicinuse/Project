using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AACSPROJECT_AD
{
    public partial class frmLetter : Form
    {
        public frmLetter()
        {
            InitializeComponent();
        }
        string formLetter = "";

        private void frmLetter_Load(object sender, EventArgs e)
        {
            txtFormOutput.Text = "\r\n\r\n\r\nTulsa Community   College" +
                "\r\n\r\n\r\nDear {0}{1}" + 
                "\r\n\r\n\r\nWe here at {2} want to let you know about a keen new program operated by the {3} department.  " +
                "Now for a limited time, you can take courses in {4}. which can lead to an exciting career in {5}, " +
                "which is going to be a growth industry in the coming years.  The cost for thid experience is a mere {6}." +
                "\r\n\r\n\r\nSign up today to get more {7} in this fantastic opportunity.  Call us at {8} to request an information bundle today" +
                "\r\n\r\n\r\nYours very truly," +
                "\r\n\r\n\r\n{9}";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtFormOutput.Text = txtFormOutput.Text.Replace("{0}", txtFirstName.Text + " ")
            .Replace("{1}", txtLastName.Text + ",")
            .Replace("{2}", txtOrg.Text)
            .Replace("{3}", txtDept.Text)
            .Replace("{4}", txtCourses.Text)
            .Replace("{5}", txtCareer.Text)
            .Replace("{6}", txtCost.Text)
            .Replace("{7}", txtResources.Text)
            .Replace("{8}", txtPhone.Text)
            .Replace("{9}", txtSender.Text);
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            formLetter = txtFormOutput.Text;
            int loc = formLetter.IndexOf("  ");
            if (loc > 0)
            {
                int newLine = 0;
                string sub = String.Empty;
                string secondSub = String.Empty;

                newLine = formLetter.IndexOf("\r\n", loc);
                int lengthForSubstring = newLine - loc;
                sub = formLetter.Substring(loc, lengthForSubstring);
                secondSub = sub.Trim();
                formLetter = formLetter.Replace(sub, " " + secondSub);

                txtFormOutput.Text = formLetter;
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            int iNoLines = 0;
            int iLength = 0;

            string formLetter = txtFormOutput.Text;

            iLength = formLetter.Length;
            iNoLines = System.Text.RegularExpressions.Regex.Matches(formLetter, "\n").Count;
            txtFormOutput.Text = (formLetter + "\r\n\r\nThe number of characters in the letter is " + iLength + "." + 
                "\r\n\r\nThe number of line feeds in the letter is " + iNoLines + ".");
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            txtFormOutput.Text = "\r\n\r\n\r\nTulsa Community   College" +
               "\r\n\r\n\r\nDear {0}{1}" +
               "\r\n\r\n\r\nWe here at {2} want to let you know about a keen new program operated by the {3} department.  " +
               "Now for a limited time, you can take courses in {4}. which can lead to an exciting career in {5}, " +
               "which is going to be a growth industry in the coming years.  The cost for thid experience is a mere {6}." +
               "\r\n\r\n\r\nSign up today to get more {7} in this fantastic opportunity.  Call us at {8} to request an information bundle today" +
               "\r\n\r\n\r\nYours very truly," +
               "\r\n\r\n\r\n{9}";
        }

        private void btnLcase_Click(object sender, EventArgs e)
        {
            formLetter = txtFormOutput.Text;
            if (formLetter.Contains("Tulsa Community   College"))
            {
                formLetter = txtFormOutput.Text;
                int loc = formLetter.IndexOf("Tulsa Community   College");
             
                if (loc > 0)
                {
                    int newLine = 0;
                    string sub = String.Empty;
                    string secondSub = String.Empty;

                    newLine = formLetter.IndexOf("\r\n", loc);
                    int lengthForSubstring = newLine - loc;
                    sub = formLetter.Substring(loc, lengthForSubstring);
                    secondSub = sub.ToLower();
                    if(secondSub.Contains("  "))
                    {
                        secondSub = secondSub.Replace("   ", " ");
                    }
                    formLetter = formLetter.Replace(sub, secondSub);

                    txtFormOutput.Text = formLetter;
                }
            }
            else if (formLetter.Contains("TULSA COMMUNITY COLLEGE"))
            {
                formLetter = txtFormOutput.Text;
                int loc = formLetter.IndexOf("TULSA COMMUNITY COLLEGE");
                if (loc > 0)
                {
                    int newLine = 0;
                    string sub = String.Empty;
                    string secondSub = String.Empty;

                    newLine = formLetter.IndexOf("\r\n", loc);
                    int lengthForSubstring = newLine - loc;
                    sub = formLetter.Substring(loc, lengthForSubstring);
                    secondSub = sub.ToLower();
                    formLetter = formLetter.Replace(sub, secondSub);

                    txtFormOutput.Text = formLetter;
                }
            }
        }

        private void btnUcase_Click(object sender, EventArgs e)
        {
            formLetter = txtFormOutput.Text;
            if (formLetter.Contains("Tulsa Community   College"))
            {
                formLetter = txtFormOutput.Text;
                int loc = formLetter.IndexOf("Tulsa Community   College");

                if (loc > 0)
                {
                    int newLine = 0;
                    string sub = String.Empty;
                    string secondSub = String.Empty;

                    newLine = formLetter.IndexOf("\r\n", loc);
                    int lengthForSubstring = newLine - loc;
                    sub = formLetter.Substring(loc, lengthForSubstring);
                    secondSub = sub.ToUpper();
                    if (secondSub.Contains("  "))
                    {
                        secondSub = secondSub.Replace("   ", " ");
                    }
                    formLetter = formLetter.Replace(sub, secondSub);

                    txtFormOutput.Text = formLetter;
                }
            }

            else if (formLetter.Contains("tulsa community college"))
            {
                formLetter = txtFormOutput.Text;
                int loc = formLetter.IndexOf("tulsa community college");
                if (loc > 0)
                {
                    int newLine = 0;
                    string sub = String.Empty;
                    string secondSub = String.Empty;

                    newLine = formLetter.IndexOf("\r\n", loc);
                    int lengthForSubstring = newLine - loc;
                    sub = formLetter.Substring(loc, lengthForSubstring);
                    secondSub = sub.ToUpper();
                    formLetter = formLetter.Replace(sub, secondSub);

                    txtFormOutput.Text = formLetter;
                }
            }

            else if (formLetter.Contains("Tulsa Community College"))
            {
                formLetter = txtFormOutput.Text;
                int loc = formLetter.IndexOf("Tulsa Community College");
                if (loc > 0)
                {
                    int newLine = 0;
                    string sub = String.Empty;
                    string secondSub = String.Empty;

                    newLine = formLetter.IndexOf("\r\n", loc);
                    int lengthForSubstring = newLine - loc;
                    sub = formLetter.Substring(loc, lengthForSubstring);
                    secondSub = sub.ToUpper();
                    formLetter = formLetter.Replace(sub, secondSub);

                    txtFormOutput.Text = formLetter;
                }
            }
        }
    }
}
